using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aquarium
{
    static class LocalData
    {
        //Данные о рыбах
        private static BindingList<Fish> fishData = new BindingList<Fish>();

        //Получение данных о рыбах
        public static BindingList<Fish> GetFishList => fishData;
        public static int FishMaxInd
        {
            get
            {
                int maxInd = 0;
                foreach (Fish f in fishData)
                {
                    if (f.id > maxInd)
                        maxInd = f.id;
                }
                return maxInd;
            }
        }

        //Данные о флоре
        private static BindingList<Flora> floraData = new BindingList<Flora>();

        //Получение данных о флоре
        public static BindingList<Flora> GetFloraList => floraData;

        public static int FloraMaxInd
        {
            get
            {
                int maxInd = 0;
                foreach (Flora f in floraData)
                {
                    if (f.id > maxInd)
                        maxInd = f.id;
                }
                return maxInd;
            }
        }

        #region Функции базы данных - добавление, удаление, обновление
        
        /// <summary>
        /// Добавление записи
        /// </summary>
        /// <param name="obj"></param>
        public static void AddData(IWaterCreature obj)
        {
            if(obj.GetType() == typeof(Fish))
            {
                fishData.Add((Fish)obj);
            }
            else if(obj.GetType() == typeof(Flora))
            {
                floraData.Add((Flora)obj);
            }
        }

        /// <summary>
        /// Удаление записи
        /// </summary>
        /// <param name="obj"></param>
        public static void DeleteData(IWaterCreature obj)
        {
            if(obj.GetType() == typeof(Fish))
            {
                fishData.Remove((Fish)obj);
            }
            else if(obj.GetType() == typeof(Flora))
            {
                floraData.Remove((Flora)obj);
            }
            
        }

        /// <summary>
        /// Обновление записи
        /// </summary>
        /// <param name="objId"></param>
        /// <param name="obj"></param>
        public static void RefreshData(int objId, IWaterCreature obj)
        {
            if (obj.GetType() == typeof(Fish))
            {
                Fish imp = (Fish)obj;
                for (int i = 0; i < fishData.Count; i++)
                {
                    if (fishData[i].id == objId)
                    {
                        fishData[i].age = imp.age;
                        fishData[i].conditions = imp.conditions;
                        fishData[i].info = imp.info;
                        fishData[i].dietStr = imp.dietStr;
                        fishData.ResetItem(i);
                        break;
                    }
                }
            }
            else if (obj.GetType() == typeof(Flora))
            {
                for (int i = 0; i < floraData.Count; i++)
                {
                    if (floraData[i].id == objId)
                    {
                        floraData[i].age = obj.age;
                        floraData[i].conditions = obj.conditions;
                        floraData[i].info = obj.info;
                        floraData.ResetItem(i);
                        break;
                    }
                }
            }
        }
        #endregion

        #region Функции поиска
        /// <summary>
        /// Поиск в базе данных рыб
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static BindingList<Fish> FishBuildSearchList(string request)
        {
            BindingList<Fish> result = new BindingList<Fish>();
            //Поиск по ID и возрасту
            if (int.TryParse(request, out int num))
            {
                foreach (Fish f in fishData)
                {
                    if (f.age == num || f.id == num)
                    {
                        result.Add(f);
                        continue;
                    }
                }
            }
            else
            {
                //Поиск по имени вида и обычному имени
                request = request.ToLower();
                foreach (Fish f in fishData)
                {
                    if (f.info.name.ToLower().Contains(request) || f.info.species.ToLower().Contains(request))
                    {
                        result.Add(f);
                        continue;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Поиск в базе данных флоры
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static BindingList<Flora> FloraBuildSearchList(string request)
        {
            BindingList<Flora> result = new BindingList<Flora>();
            //Поиск по ID и возрасту
            if (int.TryParse(request, out int num))
            {
                foreach (Flora f in floraData)
                {
                    if (f.age == num || f.id == num)
                    {
                        result.Add(f);
                        continue;
                    }
                }
            }
            else
            {
                //Поиск по имени вида и обычному имени
                request = request.ToLower();
                foreach (Flora f in floraData)
                {
                    if (f.info.name.ToLower().Contains(request) || f.info.species.ToLower().Contains(request))
                    {
                        result.Add(f);
                        continue;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Поиск объекта во всей базе данных (и рыбы, и растения) по общему имени
        /// </summary>
        /// <param name="commonName"></param>
        /// <returns></returns>
        public static IWaterCreature SearchObject(string commonName)
        {
            IWaterCreature searchResult = null;

            foreach (Fish f in fishData)
            {
                if (f.info.name.ToLower() == commonName.ToLower())
                {
                    searchResult = f;
                    return searchResult;
                }
            }

            foreach (Flora f in floraData)
            {
                if (f.info.name.ToLower() == commonName.ToLower())
                {
                    searchResult = f;
                    return searchResult;
                }
            }

            return searchResult;
        }
        #endregion



        /// <summary>
        /// Создание лога несоответствия условиям для каждого организма
        /// </summary>
        /// <returns></returns>
        public static string BuildLog()
        {
            string log = "";
            string logstring;

            int tempDiff = Utilities.aqmparameters.temperatureDifference;
            foreach (Fish f in fishData)
            {
                logstring = "";
                string[] conditions = f.CondArray;
                string waterRequire = conditions[0];
                int tempRequire = Convert.ToInt32(conditions[1]);
                

                if(conditions[0] != Utilities.aqmparameters.water)
                {
                    logstring += $"Water does not match (aquarium water is {Utilities.aqmparameters.water.ToUpper()}; species require {conditions[0].ToUpper()}); ";
                }
                if(Utilities.aqmparameters.temperature > tempRequire + tempDiff || Utilities.aqmparameters.temperature < tempRequire - tempDiff)
                {
                    logstring += $"Temperature does not match (aquarium temperature is {Utilities.aqmparameters.temperature}°C; species require {tempRequire - tempDiff}-{tempRequire + tempDiff}°С); ";
                }

                List<IWaterCreature> foodSupply = new List<IWaterCreature>();
                foreach(string food in f.DietArray)
                {
                    IWaterCreature foodObject = SearchObject(food);
                    if(foodObject != null)
                    {
                        foodSupply.Add(SearchObject(food));
                    }
                   
                }

                if(foodSupply.Count == 0)
                {
                    logstring += "No available food supply - check DietList";
                }

                if (logstring != "")
                    log += $"[Fish {f.info.name}, ID = {f.id}]: Conditions Mismatch - {logstring}{Environment.NewLine}";
            }

            foreach (Flora f in floraData)
            {
                logstring = "";
                string[] conditions = f.CondArray;
                string waterRequire = conditions[0];
                int tempRequire = Convert.ToInt32(conditions[1]);


                if (conditions[0] != Utilities.aqmparameters.water)
                {
                    logstring += $"Water does not match (aquarium water is {Utilities.aqmparameters.water.ToUpper()}; species require {conditions[0].ToUpper()}); ";
                }
                if (Utilities.aqmparameters.temperature > tempRequire + tempDiff || Utilities.aqmparameters.temperature < tempRequire - tempDiff)
                {
                    logstring += $"Temperature does not match (aquarium temperature is {Utilities.aqmparameters.temperature}°C; species require {tempRequire - tempDiff}-{tempRequire + tempDiff}°С); ";
                }

                if (logstring != "")
                    log += $"[Flora {f.info.name}, ID = {f.id}]: Conditions Mismatch - {logstring}{Environment.NewLine}";
            }

            return log;
        }
    }
}
