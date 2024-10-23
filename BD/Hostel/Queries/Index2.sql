use Hostel1;

create index idx_RoomAndPrice
    on Номер (ID_Номера, Цена_проживания);


select ID_Номера, Тип_номера, Описание
from Номер
where ID_Номера like '1%' and Цена_проживания > 900

drop index idx_NumberOfBooking on Бронирование;