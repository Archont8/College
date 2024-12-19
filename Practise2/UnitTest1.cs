using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Data.SQLite;
using WinFormsApp1;
using System.Collections.Generic;
using ConsoleTableExt;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public Ticket newticket { get; private set; }
        [TestMethod]
        public void TestMethod2()
        {
            string departure = "Санкт-Петербург";
            string arrive = "Сочи";
            string category = "Купе";
            int cost = 4000;
            newticket = new Ticket
            {
                departure = departure,
                arrive = arrive,
                category = category,
                cost = cost
            };

            Assert.AreEqual(departure, newticket.departure);
            Assert.AreEqual(arrive, newticket.arrive);
            Assert.AreEqual(category, newticket.category);
            Assert.AreEqual(cost, newticket.cost);
        }
        [TestMethod]
        public void TestMethod1()
        {
            TestMethod2();
        }
        [TestMethod]
        public void selectCostTicketsInfo()
        {
            string con = $"Data Source = E:/courseworkshch – копия/WinFormsApp1/WinFormsApp1/bin/Release/db_1.db";
            using (var connect = new SQLiteConnection(con))
            {

                string tbname = "login";
                string departure = "Ейск";
                string arrive = "Сочи";
                string category = "Купе";
                connect.Open();
                var command = connect.CreateCommand();

                command.CommandText = $@"SELECT cost FROM ticketsInfo WHERE departure = @departure AND arrive = @arrive AND category = @category";
                command.Parameters.AddWithValue("@departure", departure);
                command.Parameters.AddWithValue("@arrive", arrive);
                command.Parameters.AddWithValue("@category", category);

                var cost = command.ExecuteScalar();

                if (cost != null)
                {

                    BuyForm bf = new BuyForm(departure, arrive, category, (int)cost, tbname);
                }
                else
                {
                    Console.WriteLine("Билет не найден.");
                }
            }
        }
        [TestMethod]
        public void deleteTicketsInfo()
        {
            string con = $"Data Source = E:/courseworkshch – копия/WinFormsApp1/WinFormsApp1/bin/Release/db_1.db";
            string sql = $"DELETE FROM ticketsInfo WHERE id = 3";
            using (var connect = new SQLiteConnection(con))
            {
                connect.Open();
                using (var cmd = new SQLiteCommand(sql, connect))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                        }
                    }
                }
            }
        }
        [TestMethod]
        public void selectTicketsInfo()
        {
            string TicketsFile = "E:/courseworkshch – копия/Информация о билетах.txt";
            string con = $"Data Source = E:/courseworkshch – копия/WinFormsApp1/WinFormsApp1/bin/Release/db_1.db";

            using (var SW = File.CreateText(TicketsFile))
            {
                string query = @"SELECT * FROM ticketsInfo;";
                using (var connection = new SQLiteConnection(con))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        SQLiteDataReader reader = command.ExecuteReader();
                        using (reader)
                        {
                            if (reader.HasRows)
                            {
                                var data = new List<List<string>>();
                                var columns = new List<string>();

                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    columns.Add(reader.GetName(i));
                                }

                                columns.Remove("id");

                                while (reader.Read())
                                {
                                    var rows = new List<string>();
                                    foreach (var column in columns)
                                    {
                                        rows.Add(reader[column].ToString());
                                    }
                                    data.Add(rows);
                                }

                                var tableString = ConsoleTableBuilder
                                    .From(data)
                                    .WithColumn(columns.ToArray())
                                    .Export();

                                SW.WriteLine(tableString);
                            }
                        }
                    }
                }
            }
        }
        [TestMethod]
        public void updateAdminInfo()
        {
            string con = $"Data Source = E:/courseworkshch – копия/WinFormsApp1/WinFormsApp1/bin/Release/db_1.db";
            using (var connect = new SQLiteConnection(con))
            {
                connect.OpenAsync();

                string login = "login";
                string password = "paswrd";
                int admID = 2;

                string updateQuery = "UPDATE adminInfo SET login = @login, password = @password WHERE id = @id";
                using (var command = new SQLiteCommand(updateQuery, connect))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@id", admID);

                    command.ExecuteNonQueryAsync();
                }
            }
        }
        [TestMethod]
        public void CityChanging()
        {
            string SelectedCity = "Москва";

            foreach (string city in new string[] { "Москва", "Санкт-Петербург", "Сочи", "Ейск", "Краснодар", "Нижний Новгород" })
            {
                if (city != SelectedCity)
                {

                }
            }
        }
        [TestMethod]
        public void Nagruz()
        {
            for (int i = 0; i < 100; i++)
            {
                var t1 = Task.Run(() => selectTicketsInfo());
                var t2 = Task.Run(() => selectCostTicketsInfo());
                var t3 = Task.Run(() => deleteTicketsInfo());
                Task.WaitAll(t1, t2, t3);
            }
        }
    }
}