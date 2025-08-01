use Yarok_MyBASE;

select * from Товары full outer join Заказы
	on Заказы.Наименование_заказа = Товары.Наименование
		Order by Заказы.Наименование_заказа, Товары.Наименование

select COUNT(*) from Товары Full outer join Заказы
	on Заказы.Наименование_заказа = Товары.Наименование
		where Номер_заказа is null