use Yarok_MyBASE;

Select ������������_������, ����_������� From ������
	Where ����_������� >=all (select ����_������� From ������
							   where ������������_������ like 'c%')