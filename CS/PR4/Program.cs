/* 
Работа студента И-31 Сафронова Данила
Проверил преподаватель Фомин Андрей Томасович
Вариант 17: Найти количество строк в файле, в которых содержится ровно 5 букв "и" 
*/

class Program {
    public static void Main() {
        string inputFile = "input.txt"; 
        try {
            var Task1 = Task.Factory.StartNew(() => {
                string[] lines = File.ReadAllLines(inputFile);
                int countOfSymbols = 0;
                int countOfStrings = 0;
                    if (lines.Length > 0) {
                        foreach(var line in lines) {
                            foreach (var letter in line) {
                                if (letter == 'и') {
                                    ++countOfSymbols;
                                }
                                if (countOfSymbols > 5)  {
                                    continue;
                                }
                            }
                                if (countOfSymbols == 5) {
                                    ++countOfStrings;
                                }
                            countOfSymbols = 0;
                        }
                    }
                Console.WriteLine($"Количество строк, содержащих ровно 5 букв 'и' {countOfStrings}");
            });
            Task1.Wait();
        }
        catch (FileNotFoundException) {
            Console.WriteLine("Ошибка! Неверно указан путь к файлу!");
        }
        catch (UnauthorizedAccessException) {
            Console.WriteLine("Ошибка! Несанкционированный доступ! Самоуничтожение файла через 5...4...3...2...1 \nФайл удален!");
            Thread.Sleep(1000);
            File.Delete(inputFile);
        }
        catch (DirectoryNotFoundException) {
            Console.WriteLine("Ошибка! Директория не найдена!");
        }
        catch (Exception ex) {
            Console.WriteLine($"Ошибка! {ex.Message}");
        }
    }
}

/* ВЫВОД ПРОГРАММЫ:
 Количество строк, содержащих ровно 5 букв 'и' 2
*/