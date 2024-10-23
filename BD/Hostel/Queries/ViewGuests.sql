create view ViewGuests as
    select ID_Гостя, 
    Фамилия_гостя, 
    concat(substring(Паспорт_Гостя, 1, 2), '****', substring(Паспорт_гостя, -1, 2)) as НомерПаспорта
    from Гость;