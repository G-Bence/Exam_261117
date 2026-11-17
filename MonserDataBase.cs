using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace Exam_261117
{
    internal class MonserDataBase
    {
        private readonly string connectionString = "Server=localhost;Port=3306;Database=exam_261117_db;Uid=root;Pwd=;";
        
        public List<Monsters> uploadMonster(List<Monsters> monster)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SELECT example
                    string selectQuery = "SELECT * FROM szornyek";
                    using (var cmd = new MySqlCommand(selectQuery, connection))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            monster.Add(new Monsters(
                                reader.GetInt32("id"),
                                reader.GetString("Nev"),
                                reader.GetInt32("VeszelyessegiSzint"),
                                reader.GetString("Elohely"),
                                reader.GetString("FoGyengeseg"),
                                reader.GetString("LeggyakoribbZsakmany"),
                                reader.GetBoolean("VeszelyesE")
                            ));
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General error: " + ex.Message);
            }

            return monster;

        }
    }
}
