SELECT TOP 2 ������.ID_������, ������.��������_������, COUNT(�����_������.ID_�����������) AS ����������_�������
FROM ������ INNER JOIN �����_������ ON ������.ID_������ = �����_������.ID_������
GROUP BY ������.ID_������, ������.��������_������
ORDER BY COUNT(�����_������.ID_�����������) DESC;