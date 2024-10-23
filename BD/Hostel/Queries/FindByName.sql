declare @SecondName nvarchar(50) = 'Иванов';

SELECT *
FROM Гость
WHERE Гость.Фамилия_гостя = @SecondName;
