-- ���� �ּ� (��Ʈ��+/)
/*
������ �ּ�
*/

-- ���ݱ����� �ϳ��� ���Ͽ� ���� ��ü �ڵ忡 ���� �����ؿ����� 
-- ���� ����(��Ʈ��+����) / ��ũ��Ʈ ����(��ü �ڵ� ����, ����Ű F5) ������ �־���

-- DataBase = Data + Base
-- DBMS :: DB �� �����ϴ� �ý��� => Oracle, MySql, MongoDB, ...

-- SQL��(������) :: DBMS ���� CRUD �� �����ϱ� ���� ����ϴ� �ڵ�
-- CRUD :: Create / Read / Update / Delete => ����, �б�, ����, ����

-- DQL(Data Query Language) :: �����͸� ��ȸ�ϴ� ���
-- => SELECT :: �����͸� �˻��ϴ� ����
-- => SELECT �Ӽ��̸� FROM ���̺�� WHERE ���ǽ�;
-- DUAL :: �ӽ� ���̺�

SELECT LENGTH('�̰��') FROM DUAL;
SELECT LENGTHB('�̰��') FROM DUAL;    -- �ѱ��� �� ���ڿ� 3����Ʈ

SELECT LENGTH('GyungMinYi') FROM DUAL;
SELECT LENGTHB('GyungMinYi') FROM DUAL;

-- where ���ǽĿ� ���ؼ� �����̱⿡ �˻���� ��� ���� ����
SELECT LENGTH('HELLO') FROM DUAL WHERE LENGTH('HELLO')>=5;

-- DDL(Data Definition Language) :: ������ ����(DB, ���̺�, ...)�� �����ϴ� ���
-- => CREATE, ALTER, DROP, TRUNCATE, RENAME

-- CREATE :: �����͸� ������ ������ ����
-- CREATE TABLE ���̺�� (
--    �Ӽ��̸�, �Ӽ�Ÿ��, ...
-- );

create table STUDENT (
    hak_bun VARCHAR2 (10) PRIMARY KEY, 
    name VARCHAR2(20) NOT NULL,
    age INT NOT NULL,
    score FLOAT
);

-- NOT NULL :: NULL �� �Ǹ� �ȵǴ� �Ӽ��� �ۼ�
-- PRIMARY KEY :: �⺻Ű = �����͵鳢�� �����ϱ� ���� �Ӽ��� �ο�

SELECT * FROM STUDENT;
-- �̶� * �� �ǹ̴� ��ü�Ӽ� �̶�� ���� �ȴ�

-- VARCHAR2 Ÿ�԰� INT, NUMBER �� �ַ� ���

-- ������
-- CHAR(n) :: ���� ���̸� ���� ���ڿ�
-- => ������ n �� ũ�⸦ �Ҵ�

-- VARCHAR2(n)  :: ���� ���̸� ���� ���ڿ�
-- => �ִ� ũ�⸦ n ���� ���� �ʿ信 ���� 0~n ������ ���� �Ҵ�
-- => �ѱ� �ϳ��� ���� n�� �� 3���� ������ �����Ѵ�
-- NVARCHAR2(n) :: ���� ���̸� ���� ���ڿ�
-- => �ִ� ũ�⸦ n ���� ���� �ʿ信 ���� 0~n ������ ���� �Ҵ�
-- => �ѱ� �ϳ��� ���� n�� �� 1���� ������ �����Ѵ�

-- ������
-- INT :: ���� ������
-- FLOAT :: �Ǽ� ������
-- NUMBER(p, s) :: ����/�Ǽ� �Ѵ� ���� ������ ������
-- => p :: ����&�Ǽ� �κп��� �ִ�� ���� ������ ����
-- => s :: �Ǽ� �κп��� �ִ�� ���� ������ ����
-- ����) �Ӽ����� HEIGHT �̰� �Ӽ�Ÿ���� NUMBER(4,1) �̶� �Ѵٸ� 000.0 ���·� ���� ����

-- �� �ܿ��� ��¥ Ÿ��, LOB�� �� ����

-- DML :: �����͸� �����ϴ� ��ɾ�
-- INSERT :: ���̺� ������ �����ϴ� ��ɾ�
-- INSERT INTO ���̺�� VALUES(�����Ͱ�1, �����Ͱ�2, ...);
-- => �Ӽ����� ����� ������� ������ ���� ����
-- INSERT INTO ���̺��(�Ӽ���1, �Ӽ���2, ...) VALUES(�����Ͱ�1, �����Ͱ�2, ...);
-- => �Ӽ���1���� �����Ͱ�1 ����, �Ӽ���2���� �����Ͱ�2 ����, ...

INSERT INTO STUDENT VALUES(21402149, '�̰��', 30, 5.5);
SELECT * FROM STUDENT;

-- DROP, TRUNCATE :: ���̺��� �����ϴ� ��ɾ�
-- DROP :: ���̺� ������ ��� ����
-- DROP TABLE IF EXISTS ���̺��
-- TRUNCATE :: ���̺��� ���´� ���ܵΰ� �����͵鸸 ��� ����
-- TRUNCATE TABLE IF EXISTS ���̺��
-- IF EXISTS ��� ��, ���̺��� ������ ���� ��ɹ� ���� (����Ŭ������ �������� �ʴ´�.)

-- ALTER :: ������ ������ ���� ����
-- => ADD, DROP, MODIFY, RENAME, RENAME COLUMN

-- ALTER :: Į�� �߰� (ADD)
-- ALTER TABLE ���̺�� ADD �߰��ҼӼ��̸� �߰��ҼӼ�Ÿ��
ALTER TABLE STUDENT ADD GRADE INT;

-- ALTER :: Į�� ���� (DROP)
-- ALTER TABLE ���̺�� DROP �����ҼӼ��̸� �����ҼӼ�Ÿ��
ALTER TABLE STUDENT DROP COLUMN AGE;

-- ALTER :: ���̺�� ���� (RENAME)
-- ALTER TABLE ���̺�� RENAME TO ���������̺��
ALTER TABLE STUDENT RENAME TO HAKSANG;

-- ALTER :: Į���� ����(RENAME COLUMN)
-- ALTER TABLE ���̺�� RENAME COLUMN �÷���(���� �Ӽ��̸�) TO �������÷���
ALTER TABLE HAKSANG RENAME COLUMN HAK_BUN TO NUM;
SELECT * FROM HAKSANG;

--TRUNCATE TABLE STUDENT; -- table student �� �߷Ƚ��ϴ� ����
--DROP TABLE IF EXISTS STUDENT;     -- table student �� �����Ǿ����ϴ� ����
--SELECT * FROM STUDENT;
SELECT * FROM HAKSANG;
--DROP TABLE STUDENT;
DROP TABLE HAKSANG;

COMMIT;










