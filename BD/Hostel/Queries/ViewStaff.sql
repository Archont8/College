create view ViewStaff as
    select ID_Сотрудника, Фамилия_сотрудника, Имя_сотрудника, 
    concat(substring(Телефон_сотрудника, 1, 5), '****') as НомерТелефона
from Сотрудник;