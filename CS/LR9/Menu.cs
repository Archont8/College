using Microsoft.Data.Sqlite;
using static System.Console;

class Menu {
    public static void MainMenu(SqliteConnection con) {
        bool CheckingInput = true;
        while (CheckingInput) {
            try {
                WriteLine("1. Create new table");
                WriteLine("2. Show all tables");
                WriteLine("3. Exit");
                Write("-> ");
                int choose = Convert.ToInt32(ReadLine());
                switch (choose) {
                    case 1:
                        CreationMenu(con);
                    break;
                    case 2:
                        ShowTablesMenu(con);
                    break;
                    case 3:
                        CheckingInput = false;
                    break;
                    default:
                        WriteLine("Wrong choise!");
                    break;
                }
            } catch (FormatException) {
                WriteLine("\nError! Wrong type");
            } catch (Exception ex) {
                WriteLine($"\nError! {ex.Message}");
            }
        }
    }
    static void CreationMenu(SqliteConnection con) {
        Write("\nEnter the name of the new table: ");
        string tableName = ReadLine()!;

        CreateTable.Create(con, tableName);

        bool CheckingInput = true;
        while (CheckingInput) {
            WriteLine("1. Add data");
            WriteLine("2. Show data");
            WriteLine("3. Return");
            
            Write("-> ");
            int choose = Convert.ToInt32(ReadLine());

            switch (choose) {
                case 1:
                    InputInfo.Input(con, tableName);
                break;
                case 2:
                    OutputInfo.Output(con, tableName);
                break;
                case 3:
                    CheckingInput = false;
                break;
                default: WriteLine("Wrong choise!");
                break;
            }
        }
    }
    static void ShowTablesMenu(SqliteConnection con) {
        AllTablesDB.Tables(con);
        
        bool CheckingInput = true;
        while (CheckingInput) {
            WriteLine("1. Insert data");
            WriteLine("2. Show data");
            WriteLine("3. Return");
        
            Write("-> ");
            int choose = Convert.ToInt32(ReadLine());

            switch (choose) {
                case 1:
                    Write("Enter the name of the table: ");
                    string tableName = ReadLine()!;
                    InputInfo.Input(con, tableName);
                break;
                case 2:
                    Write("Enter the name of the table: ");
                    tableName = ReadLine()!;
                    OutputInfo.Output(con, tableName);
                break;
                case 3:
                    CheckingInput = false;
                break;
                default: WriteLine("Неверный выбор!");
                break;
            }
        }
    }
}