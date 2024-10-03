declare @SecondName nvarchar(50) = 'Иванов';
SELECT Гость.*
FROM Гость
WHERE Гость.Фамилия_гостя = @SecondName;
