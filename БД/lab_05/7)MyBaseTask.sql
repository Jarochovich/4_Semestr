use Yarok_MyBASE;

Select Наименование_заказа, Цена_продажи From Заказы
	Where Цена_продажи >=all (select Цена_продажи From Заказы
							   where Наименование_заказа like 'c%')