use Yarok_MyBASE;

Select Наименование From Товары
	Where not exists (Select * From Заказы
		Where Заказы.Наименование_заказа = Товары.Наименование)