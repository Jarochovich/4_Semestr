use Yarok_MyBASE;

Select ������������_������, ����_�������
	From ������ a
		Where �������� = (select top(1) �������� From ������ aa
						  Where aa.������������_������ = a.������������_������
						  Order by ����_������� desc);	