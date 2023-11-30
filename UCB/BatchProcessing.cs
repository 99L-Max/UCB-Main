using System;
using System.Linq;

namespace UCB
{
    enum TypeProcessingData
    {
        BatchSize,
        TotalNumberData
    }

    class BatchProcessing : Bandit
    {
        public static TypeProcessingData TypeProcessingData = TypeProcessingData.BatchSize;
        public static EstimationDispersion EstimationDispersion = EstimationDispersion.Never;

        //Конструктор для симуляции
        public BatchProcessing(int countArms, int numberBatchs, int batchSize, int initialDataSize, double parameter) :
            base(countArms, numberBatchs * batchSize, parameter)
        {
            SetSettings(numberBatchs, batchSize, initialDataSize);
        }

        //Конструктор для чтения файла
        public BatchProcessing(int countArms, int numberBatchs, int batchSize, int initialDataSize, double parameter, double[] regrets) :
            base(countArms, numberBatchs * batchSize, parameter, regrets)
        {
            SetSettings(numberBatchs, batchSize, initialDataSize);
        }

        public int NumberBatches { private set; get; }

        public int BatchSize { private set; get; }

        public int InitialDataSize { private set; get; }

        private void SetSettings(int numberBatchs, int batchSize, int initialDataSize)
        {
            if (initialDataSize > batchSize)
                throw new ArgumentException("Количество начальных данных M0 должно быть меньше либо равно размеру пакета M.");

            if (batchSize % initialDataSize != 0)
                throw new ArgumentException("Размер пакета M должен быть кратен числу начальных данных M0.");

            //Из формулы несмещённой оценки дисперсии нужно минимум 2 элемента выборки
            if (EstimationDispersion != EstimationDispersion.Never && initialDataSize < 2)
                throw new ArgumentException("При неизвестных дисперсиях минимальный размер пакета 2.");

            NumberBatches = numberBatchs;
            BatchSize = batchSize;
            InitialDataSize = initialDataSize;
        }

        public override void RunSimulation()
        {
            regrets = new double[NumberDeviations];
            double maxIncome;
            /*
             * Коэффициент выравнивания до кратности.
             * После применения J раз по M0 данных нужно применить
             * ещё раз по M0 данных, чтобы оставшееся число данных было кратно M
             */
            int otherMinBatches = (int)Math.Ceiling((double)CountArms * InitialDataSize / BatchSize) * BatchSize / InitialDataSize - CountArms;
            /*
             * Затем нужно применять по M данных, пока не будут обработаны
             * все данные в количестве N = M * K
            */
            int otherBatches = NumberBatches - (CountArms + otherMinBatches) * InitialDataSize / BatchSize;
            int initialIncrement, mainIncrement;

            if (TypeProcessingData == TypeProcessingData.TotalNumberData)
            {
                initialIncrement = InitialDataSize;
                mainIncrement = BatchSize;
            }
            else
            {
                initialIncrement = 1;
                mainIncrement = BatchSize / InitialDataSize;
            }

            for (int mainIndex = 0; mainIndex < NumberDeviations; mainIndex++)
            {
                if (GetDeviation(mainIndex) == 0d)
                {
                    EventPointProcessed();
                    continue;
                }

                for (int i = 0; i < arms.Length; i++)
                    arms[i] = new Arm(Expectation + (i == 0 ? GetDeviation(mainIndex) : -GetDeviation(mainIndex)) * SqrtDivDN, MaxDispersion);

                maxIncome = arms.Select(x => x.Expectation).Max() * Horizon;

                for (int num = 0; num < NumberSimulations; num++)
                {
                    sumCounter = 0;

                    foreach (var arm in arms)
                    {
                        arm.Reset();
                        arm.Select(InitialDataSize, initialIncrement, ref sumCounter);

                        if (EstimationDispersion != EstimationDispersion.Never)
                            arm.EstimateDispersion(TypeProcessingData, InitialDataSize);
                    }

                    //Выравнивание до M данных
                    for (int i = 0; i < otherMinBatches; i++)
                    {
                        UCB();
                        arms[IndexMaxUCB].Select(InitialDataSize, initialIncrement, ref sumCounter);

                        if (EstimationDispersion != EstimationDispersion.Never)
                            arms[IndexMaxUCB].EstimateDispersion(TypeProcessingData, InitialDataSize);
                    }

                    //Оставшиеся данные
                    for (int i = 0; i < otherBatches; i++)
                    {
                        UCB();
                        arms[IndexMaxUCB].Select(BatchSize, mainIncrement, ref sumCounter);

                        if (EstimationDispersion == EstimationDispersion.Always)
                            arms[IndexMaxUCB].EstimateDispersion(TypeProcessingData, InitialDataSize);
                    }

                    regrets[mainIndex] += maxIncome - arms.Select(x => x.Income).Sum();
                }

                regrets[mainIndex] /= NumberSimulations * SqrtMulDN;

                if (MaxRegrets < regrets[mainIndex])
                {
                    MaxRegrets = regrets[mainIndex];
                    MaxDeviation = GetDeviation(mainIndex);
                }

                EventPointProcessed();
            }

            EventSimulationFinished();
        }
    }
}