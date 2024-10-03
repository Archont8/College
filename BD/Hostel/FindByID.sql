declare @id int = 1;
print 'Введите ID гостя';

SELECT Гость.*
FROM Гость
WHERE Гость.ID_Гостя = @id;
