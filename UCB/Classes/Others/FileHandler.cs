using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UCB
{
    static class FileHandler
    {
        public static Player Open()
        {
            using (var ofDialog = new OpenFileDialog())
            {
                ofDialog.Filter = "Файлы Json|*.json";

                if (ofDialog.ShowDialog() != DialogResult.OK)
                    return null;

                try
                {
                    var jObj = JObject.Parse(File.ReadAllText(ofDialog.FileName));
                    var jArr = JArray.Parse(JToken.FromObject(jObj.SelectToken("Bandits")).ToString());

                    var distribution = (Distribution)jObj["Distribution"].Value<int>();
                    var typeProcessingData = (TypeProcessingData)jObj["TypeProcessingData"].Value<int>();
                    var expectation = jObj["Expectation"].Value<double>();
                    var maxVariance = jObj["MaxVariance"].Value<double>();
                    var variancesKnown = jObj["VariancesKnown"].Value<bool>();
                    var deviations = jObj["Deviations"].ToObject<double[]>();
                    var gamesCount = jObj["GamesCount"].Value<int>();
                    var gameResult = jObj["GameResult"].Value<string>();

                    var bandits = jArr.Select(b => new Bandit(
                            b["Expectation"].Value<double>(),
                            b["MaxVariance"].Value<double>(),
              (Distribution)b["Distribution"].Value<int>(),
        (TypeProcessingData)b["TypeProcessingData"].Value<int>(),
                            b["CountArms"].Value<int>(),
                            b["NumberBatches"].Value<int>(),
                            b["BatchSize"].Value<int>(),
                            b["Parameter"].Value<double>(),
                            b["EstimationVariance"].ToObject<bool>(),
                            b["Regrets"].ToObject<Dictionary<double, double>>())).ToArray();

                    return new Player(expectation, maxVariance, distribution, typeProcessingData, variancesKnown, deviations, gamesCount, bandits, gameResult);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "Ошибка чтения файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        public static void Save(Player player, out bool isSaved)
        {
            using (var sfDialog = new SaveFileDialog())
            {
                isSaved = false;
                sfDialog.Filter = "Файлы Json|*.json";

                if (sfDialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    File.WriteAllText(sfDialog.FileName, player.ToString());
                    isSaved = true;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "Ошибка записи файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void Save(RegretTable table)
        {
            using (var sfDialog = new SaveFileDialog())
            {
                sfDialog.Filter = "Текстовые файлы|*.txt";

                if (sfDialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (StreamWriter writer = new StreamWriter(sfDialog.FileName))
                        writer.WriteLine(table.ToString());
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "Ошибка записи файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void Save(Chart chart)
        {
            using (var sfDialog = new SaveFileDialog())
            {
                sfDialog.Filter = "Изображения|*.png";

                if (sfDialog.ShowDialog() != DialogResult.OK)
                    return;

                chart.SaveImage(sfDialog.FileName, ImageFormat.Png);
            }
        }
    }
}
