using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labatehpr
{
    class MultiLevelHangar
    {
        List<Hangar<ITransport>> HangarStages;
        private const int countPlaces = 15;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int pictureHeight;
        public MultiLevelHangar(int countStages, int pictureWidth, int pictureHeight)
        {
            HangarStages = new List<Hangar<ITransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            for (int i = 0; i < countStages; ++i)
            {
                HangarStages.Add(new Hangar<ITransport>(countPlaces, pictureWidth,
                pictureHeight));
            }
        }
        public Hangar<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < HangarStages.Count)
                {
                    return HangarStages[ind];
                }
                return null;
            }
        }
        /// <summary>
        /// Сохранение информации по автомобилям на парковках в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    //Записываем количество уровней
                    WriteToFile("CountLeveles:" + HangarStages.Count +
                    Environment.NewLine, fs);
                    foreach (var level in HangarStages)
                    {
                        //Начинаем уровень
                        WriteToFile("Level" + Environment.NewLine, fs);
                        for (int i = 0; i < countPlaces; i++)
                        {
                            var car = level[i];
                            if (car != null)
                            {
                                //если место не пустое
                                //Записываем тип мшаины
                                if (car.GetType().Name == "Aircraft")
                                {
                                    WriteToFile(i + ":Aircraft:", fs);
                                }
                                if (car.GetType().Name == "FighterAircraft")
                                {
                                    WriteToFile(i + ":FighterAircraft:", fs);
                                }
                                //Записываемые параметры
                                WriteToFile(car + Environment.NewLine, fs);
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Метод записи информации в файл
        /// </summary>
        /// <param name="text">Строка, которую следует записать</param>
        /// <param name="stream">Поток для записи</param>
        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }
        /// <summary>/// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>

        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            string bufferTextFromFile = "";
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b, 0, b.Length) > 0)
                    {
                        bufferTextFromFile += temp.GetString(b);
                    }
                }
            }
            bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
            var strs = bufferTextFromFile.Split('\n');
            if (strs[0].Contains("CountLeveles"))
            {
                //считываем количество уровней
                int count = Convert.ToInt32(strs[0].Split(':')[1]);
                if (HangarStages != null)
                {
                    HangarStages.Clear();
                }
                HangarStages = new List<Hangar<ITransport>>(count);
            }
            else
            {
                //если нет такой записи, то это не те данные
                throw new Exception("Неверный формат файла");
            }
            int counter = -1;
            ITransport car = null;
            for (int i = 1; i < strs.Length; ++i)
            {
                //идем по считанным записям
                if (strs[i] == "Level")
                {
                    //начинаем новый уровень
                    counter++;
                    HangarStages.Add(new Hangar<ITransport>(countPlaces, pictureWidth,
                    pictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(strs[i]))
                {
                    continue;
                }
                if (strs[i].Split(':')[1] == "Aircraft")
                {
                    car = new Aircraft(strs[i].Split(':')[2]);
                }
                else if (strs[i].Split(':')[1] == "FighterAircraft")
                {
                    car = new FighterAircraft(strs[i].Split(':')[2]);
                }
                HangarStages[counter][Convert.ToInt32(strs[i].Split(':')[0])] = car;
            }
        }
        
    }
}
