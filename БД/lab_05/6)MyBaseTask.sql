use Yarok_MyBASE;

Select top 1
	(select avg(Цена_продажи) from Заказы
		where Наименование_заказа like 'Стол') [Стол],
	(select avg(Цена_продажи) from Заказы
		where Наименование_заказа like 'Стул') [Стул]
From Заказы