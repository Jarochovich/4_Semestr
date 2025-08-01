USE Yarok_MyBASE;

CREATE TABLE Заказы
(Номер_заказа int primary key,
Наименование_заказа nvarchar(20) foreign key references Товары(Наименование),
Цена_продажи real,
Количество int,
Дата_поставки date,
Заказчик nvarchar(20) foreign key references Заказчики(Наименование_фирмы)
);