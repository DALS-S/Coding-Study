-- DDL(DEFINATION) :: ������ ����(DB, TABLE, ...)�� ���� 
-- => CREATE(����), ALTER(����), DROP, TRUNCATE(����)

-- DML(MANIPULATION) :: ������ ����
-- => INSERT(����), UPDATE(����), DELETE(����), (SELECT �굵 DML ��)
-- CRUD = DDL + DML

-- �޴��� ���̺� ����
CREATE TABLE phone (
    name  VARCHAR2(20),     -- ����
    os    VARCHAR2(50),     -- �ü��
    day   INT,              -- ��ó⵵
    wat   INT,              -- ���͸� �ִ� ��Ʈ
    color VARCHAR2(20)      -- ����
);

-- PHONE ���̺� ������ �߰�
INSERT INTO PHONE(NAME,OS,DAY,COLOR,INCH) VALUES('������S23', '�ȵ���̵�14', 2023, '��ȭ��Ʈ', 10.5);
INSERT INTO PHONE(NAME,OS,DAY,COLOR,INCH) VALUES('������S22', '�ȵ���̵�14', 2022, '��޺��', 9.6);
INSERT INTO PHONE(NAME,OS,DAY,COLOR,INCH) VALUES('������13', 'IOS13', 2021, '�ٶ��̷���', 8.2);

-- ALTER :: ������ ������ ���� �����ϴ� ��ɾ�
-- => ADD :: Į�� �߰�
-- => DROP COLUMN :: Į�� ����
-- => MODIFY :: Į���� Ÿ�� ����
-- => RENAME :: ���̺�� ����
-- => RENAME COLUMN :: Į���� ����

-- ADD
-- ALTER TABLE ���̺�� ADD Į���� Į��Ÿ��;
-- PHONE ���̺��� FLOAT �� INCH Į�� �߰�
ALTER TABLE PHONE ADD INCH FLOAT;

-- DROP COLUMN
-- ALTER TABLE ���̺�� DROP COLUMN Į����;
-- PHONE ���̺��� WAT Į�� ����
ALTER TABLE PHONE DROP COLUMN WAT;

-- RENAME :: ���̺�� ����
-- ALTER TABLE ���̺�� RENAME TO ���������̺��
-- PHONE ���̺��� SMARTPHONE_LIST �� ����
ALTER TABLE PHONE RENAME TO SMARTPHONE_LIST;
ALTER TABLE SMARTPHONE_LIST RENAME TO PHONE;

-- RENAME COLUMN :: Į���� ����
-- ALTER TABLE ���̺�� RENAME COLUMN ����Į���� TO ������Į����
-- PHONE ���̺��� DAY�� YEAR�� ����
ALTER TABLE PHONE RENAME COLUMN DAY TO YEAR;

-- MODIFY :: ������ Į���� Ÿ�� ����
-- ALTER TABLE ���̺�� MODIFY Į���� �����ҼӼ�Ÿ��;
-- PHONE ���̺��� INCH Į���� Ÿ���� FLOAT ���� INT�� ����
-- �����͸� ��� ���·� MODIFY �� �����ؾ��Ѵ�.
-- ALTER TABLE PHONE MODIFY INCH INT;

-- UPDATE :: Ư�� �����͸� �����ϴ� ��ɾ�
-- UPDATE ���̺�� SET Į��1=���氪1, ... WHERE ������;
-- ��ó⵵�� 2022�� �������� OS ���� �ȵ���̵�13���� ����
UPDATE PHONE SET OS='�ȵ���̵�13' WHERE DAY=2022;
UPDATE PHONE SET COLOR='��' WHERE NAME='������13';

SELECT * FROM PHONE;
DROP TABLE PHONE;
COMMIT;

