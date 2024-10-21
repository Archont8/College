use Hostel1;

create index idx_NumberOfBooking
    on Бронирование (Номер_Бронирования);

select ID, Дата_бронирования, Статус, ID_Номера
from Бронирование
where Номер_бронирования > 10

drop index idx_NumberOfBooking on Бронирование;