use Yarok_MyBASE;

Select ������������_������, ����_������� From ������
	Where ����_������� >any (select ����_������� From ������
							   where ������������_������ like '�%')