-- PEN_LIST ���̺� ���� => ����ȸ��(COMPANY), ����(COLOR)
-- PEN_LIST ���̺� ���
CREATE TABLE PEN_LIST (COMPANY VARCHAR2(20), COLOR VARCHAR2(20));
SELECT * FROM PEN_LIST;

-- PEN_LIST ���̺�� PEN���� ����
ALTER TABLE PEN_LIST RENAME TO PEN;

-- PEN ���̺� �� COMPANY Į���� COM���� ����
ALTER TABLE PEN RENAME COLUMN COMPANY TO COM;

-- PEN ���̺� ����(THICKNESS) Į�� �߰�
-- PEN ���̺� ����(PRICE) Į�� �߰�
ALTER TABLE PEN ADD THICKNESS FLOAT;
ALTER TABLE PEN ADD PRICE INT;

-- PEN ���̺� ���
SELECT * FROM PEN;

commit;

-- PEN ���̺� ���� ������ 5-10�� ����
INSERT INTO PEN(COM, COLOR, THICKNESS, PRICE) VALUES ('�����', '��', 1.5, 700000);
INSERT INTO PEN(COM, COLOR, THICKNESS, PRICE) VALUES ('�縮ĭ', '���', 2.0, 400000);
INSERT INTO PEN(COM, COLOR, THICKNESS, PRICE) VALUES ('��Ŀ', '�ǹ�', 0.5, 300000);
INSERT INTO PEN(COM, COLOR, THICKNESS, PRICE) VALUES ('���̷�Ʈ', '����', 0.25, 200000);
INSERT INTO PEN(COM, COLOR, THICKNESS, PRICE) VALUES ('���Ϸ�', '�׸�', 0.3, 100000);

-- PEN ���̺� ��ü ������ ���
SELECT * FROM PEN;

COMMIT;

-- PEN ������ ��, ������ 2000�� �̻��� �������� ����ȸ�縦 ��� '�𳪹�'�� ����
UPDATE PEN SET COM ='�𳪹�' WHERE PRICE >=2000;

-- PEN ������ ��, ���Ⱑ 0.5�� �������� ������ 1500���� ����
UPDATE PEN SET PRICE = 1500 WHERE THICKNESS = 0.5;

-- PEN ���̺� ��ü ������ ���
SELECT * FROM PEN;

-- PEN ���̺� �� ����, ���� Į�� �����͸� ���
SELECT THICKNESS, COLOR FROM PEN;
-- PEN ������ ��, ������ 'BLACK'�� �������� ����, ����, ���� Į�� �����͸� ���
SELECT COLOR, THICKNESS, PRICE FROM PEN WHERE COLOR = '��';

commit;

-- PEN ���̺��� ��� ������ ����
TRUNCATE TABLE PEN;
-- PEN ���̺� ��ü ���
SELECT * FROM PEN;
-- PEN ���̺� ��ü ����
DROP TABLE PEN;

COMMIT;