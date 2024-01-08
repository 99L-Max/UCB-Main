using System.Linq;

namespace UCB
{
    class BanditGauss : Bandit
    {
        public BanditGauss(int arms, int horizon, double parameter) :
            base(arms, horizon, parameter)
        { }

        //Конструктор для чтения файла
        public BanditGauss(int arms, int horizon, double parameter, double[] regrets) :
            base(arms, horizon, parameter, regrets)
        { }

        public override void RunSimulation()
        {
            regrets = new double[NumberDeviations];
            double maxIncome;

            for (int mainIndex = 0; mainIndex < NumberDeviations; mainIndex++)
            {
                if (GetDeviation(mainIndex) == 0d)
                {
                    EventPointProcessed();
                    continue;
                }

                for (int i = 0; i < arms.Length; i++)
                    arms[i] = new Arm(Expectation + (i == 0 ? 1 : -1) * GetDeviation(mainIndex) * SqrtDivDN, MaxDispersion);

                maxIncome = arms.Select(x => x.Expectation).Max() * Horizon;

                for (int num = 0; num < NumberSimulations; num++)
                {
                    sumCounter = 0;

                    foreach (var arm in arms)
                    {
                        arm.Reset();
                        arm.Select(ref sumCounter);
                    }

                    for (int i = CountArms; i < Horizon; i++)
                    {
                        UCB();
                        arms[IndexMaxUCB].Select(ref sumCounter);
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