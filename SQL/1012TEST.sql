--SNACK TABLE ����
--�����̸�, ��ȣ��, ����, ����
create table snack (snack_name VARCHAR2(20), hope INT, price INT, kcal INT);

--5~10���� ������ SNACK TABLE �� ����
--���Ƿ�
INSERT INTO snack (snack_name, hope, price, kcal) VALUES ('�ٳ���ű', 5, 1500, 315);
INSERT INTO snack (snack_name, hope, price, kcal) VALUES ('�����', 4, 1000, 215);
INSERT INTO snack (snack_name, hope, price, kcal) VALUES ('����ƽ', 3, 2000, 415);
INSERT INTO snack (snack_name, hope, price, kcal) VALUES ('������', 2, 1500, 315);
INSERT INTO snack (snack_name, hope, price, kcal) VALUES ('�ܯ�', 1, 3500, 515);

--1. ��� SNACK ������ �˻��Ͽ� ���
SELECT * FROM snack;

--2. SNACK ���̺��� ������ ���� ���
--(COUNT �Լ� ����)
SELECT COUNT(*) FROM snack;

--3. �Ʒ��� ���ϴ� �����͵� ������ �� �����ִ� ���������
--- ������ 2000�� �̻��� ���� ������ ����
--- ��ȣ���� 1 ������ ���� ������ ����
--- ������ 500 �̻��� ���� ������ ����
DELETE from snack WHERE price>=2000;
DELETE from snack WHERE hope<=1;
DELETE from snack WHERE kcal>=500;
SELECT * FROM snack;

-- DELETE :: �����͸� �����ϴ� ��ɹ�
-- DELETE FROM ���̺�� WHERE ���ǹ�;
-- WHERE ���ǹ� <- �� �κ��� ������, ���̺� �ִ� ��� ������ ������.

--- SNACK ���̺� ���� (���̺� ��� ����)
DROP TABLE snack;

COMMIT;


