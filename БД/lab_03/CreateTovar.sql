Use Yarok_MyBASE;
CREATE TABLE Товары
(
	Наименование nvarchar(20) primary  key,
	Цена real unique not null,
	Количество int
);
