using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace aquarium
{
    static class SQLData
    {
        private static string stringConnection = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\tank.mdf;Integrated Security=True";
        private static string sqlSelectFishes = "SELECT * FROM Fishes;";
        private static string sqlSelectFlora = "SELECT * FROM Flora";

        private static SqlConnection connection = new SqlConnection(stringConnection);
        
        private static SqlDataAdapter fishesAdapter;
        private static SqlDataAdapter floraAdapter;
        
        private static DataSet fishesDataSet;
        private static DataSet floraDataSet;

        public static void RetrieveData()
        {
            try
            {
                connection.Open();
                fishesAdapter = new SqlDataAdapter(sqlSelectFishes, connection);
                fishesDataSet = new DataSet();
                fishesAdapter.Fill(fishesDataSet);

                floraAdapter = new SqlDataAdapter(sqlSelectFlora, connection);
                floraDataSet = new DataSet();
                floraAdapter.Fill(floraDataSet);

                for (int i = 0; i < fishesDataSet.Tables[0].Rows.Count; i++)
                {
                    Fish f = new Fish()
                    {
                        id = Convert.ToInt32(fishesDataSet.Tables[0].Rows[i]["Id"]),
                        info = new Species()
                        {
                            species = fishesDataSet.Tables[0].Rows[i]["species"].ToString(),
                            name = fishesDataSet.Tables[0].Rows[i]["name"].ToString()
                        },
                        age = Convert.ToInt32(fishesDataSet.Tables[0].Rows[i]["age"]),
                        dietStr = fishesDataSet.Tables[0].Rows[i]["diet"].ToString(),
                        conditions = fishesDataSet.Tables[0].Rows[i]["conditions"].ToString()
                    };

                    LocalData.AddData(f);
                    
                }

                for (int i = 0; i < floraDataSet.Tables[0].Rows.Count; i++)
                {
                    Flora f = new Flora()
                    {
                        id = Convert.ToInt32(floraDataSet.Tables[0].Rows[i]["Id"]),
                        info = new Species()
                        {
                            species = floraDataSet.Tables[0].Rows[i]["species"].ToString(),
                            name = floraDataSet.Tables[0].Rows[i]["name"].ToString()
                        },
                        age = Convert.ToInt32(floraDataSet.Tables[0].Rows[i]["age"]),
                        conditions = floraDataSet.Tables[0].Rows[i]["conditions"].ToString()
                    };
                    LocalData.AddData(f);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection is impossible! Code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void ClearDatabase()
        {
            SqlCommand delete = new SqlCommand("DELETE FROM Fishes; DELETE FROM Flora;", connection);
            delete.ExecuteNonQuery();
            fishesDataSet.Tables[0].Clear();
            floraDataSet.Tables[0].Clear();
        }

        public static void SyncData()
        {
            connection.Open();

            ClearDatabase();
            

            DataTable fishTable = fishesDataSet.Tables[0];
            foreach(Fish f in LocalData.GetFishList)
            {
                DataRow fishInfo = fishTable.NewRow();
                fishInfo["id"] = f.id;
                fishInfo["species"] = f.info.species;
                fishInfo["name"] = f.info.name;
                fishInfo["age"] = f.age;
                fishInfo["diet"] = f.dietStr;
                fishInfo["conditions"] = f.conditions;
                fishTable.Rows.Add(fishInfo);
            }
           
            
            DataTable floraTable = floraDataSet.Tables[0];
            foreach (Flora f in LocalData.GetFloraList)
            {
                DataRow floraInfo = floraTable.NewRow();
                floraInfo["id"] = f.id;
                floraInfo["species"] = f.info.species;
                floraInfo["name"] = f.info.name;
                floraInfo["age"] = f.age;
                floraInfo["conditions"] = f.conditions;
                floraTable.Rows.Add(floraInfo);
            }

            SqlCommandBuilder commandBuilder1 = new SqlCommandBuilder(fishesAdapter);
            SqlCommandBuilder commandBuilder2 = new SqlCommandBuilder(floraAdapter);

            fishesAdapter.Update(fishesDataSet);
            floraAdapter.Update(floraDataSet);

            connection.Close();

        }
    }
}
