use Yarok_MyBASE;

Select Наименование_заказа, Цена_продажи
	From Заказы a
		Where Заказчик = (select top(1) Заказчик From Заказы aa
						  Where aa.Наименование_заказа = a.Наименование_заказа
						  Order by Цена_продажи desc);	