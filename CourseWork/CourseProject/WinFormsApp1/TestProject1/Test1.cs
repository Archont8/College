using System.Data.SQLite;

namespace WinFormsApp1 {
    [TestClass]
    public sealed class Test1 {
        string connect = "Data Source = soldiers.db";
        [TestMethod]
        
        public void TestMethod1() 
        {
            string FIO = "Коваленко Владислав Герасимович";
            string ValidityCategory = "A";
            string MilitaryBranch = "Инженерные";
            string Address = "пос. Моревка";
            string PassportNumber = "4223";
            string PassportSeries = "232323";
            using (var connection = new SQLiteConnection(connect)) {
                connection.Open();
                string createTable = @"
                CREATE TABLE IF NOT EXISTS SoldiersTest(
                id INTEGER NOT NULL PRIMARY KEY, 
                FIO nvarchar (50),
                ValidityCategory nvarchar (50),
                MilitaryBranch nvarchar (50),
                Address nvarchar (50),
                PassportNumber nvarchar (50),
                PassportSeries nvarchar (50)
                )";
                string sql = @"
                INSERT INTO SoldiersTest(FIO, ValidityCategory, MilitaryBranch, Address, PassportNumber, PassportSeries)
                SELECT @FIO, @ValidityCategory, @MilitaryBranch, @Address, @PassportNumber, @PassportSeries
                ";
                string checkFill = @"
                SELECT COUNT(*) FROM SoldiersTest
                ";
                using (var command = new SQLiteCommand(createTable, connection)) {
                    command.ExecuteNonQuery();
                }

                using (var command = new SQLiteCommand(sql, connection)) {
                    command.Parameters.AddWithValue("@FIO", FIO);
                    command.Parameters.AddWithValue("@ValidityCategory", ValidityCategory);
                    command.Parameters.AddWithValue("@MilitaryBranch", MilitaryBranch);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@PassportNumber", PassportNumber);
                    command.Parameters.AddWithValue("@PassportSeries", PassportSeries);
                    command.ExecuteNonQuery();
                }

                using (var command = new SQLiteCommand(checkFill, connection)) {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
