use Yarok_MyBASE;

select Товары.Наименование, Товары.Цена, Заказы.Цена_продажи
	from Заказы Cross Join Товары