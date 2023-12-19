-- ���� ������ �����ݷ�(;) �ֱ�
-- ��ҹ��� ���� ����

-- CRUD :: CREATE / READ / UPDATE / DELETE => ����/�б�/����/����
-- SQL�� :: ���� CRUD ����� �����ϱ� ���� ��ɹ�(���ǹ�)
-- => DQL / DDL / DML / DCL / TCL

-- DQL(QUERY) :: ������ ��ȸ 
-- => SELECT�� :: �����͸� �˻��ϴ� ��ɾ� (�˻��� ����� ��µ�)
-- => SELECT Į���� FROM ���̺�� WHERE ���ǹ�;

SELECT LENGTH('HELLOSQL') FROM DUAL WHERE LENGTH('HELLOSQL') >=5; 
-- �̶� DUAL �� �ӽ� ���̺����.

-- DDL(DEFINATION) :: ������ ����(DB, TABLE, ...)�� ���� 
-- => CREATE(����), ALTER(����), DROP, TRUNCATE(����)

-- DML(MANIPULATION) :: ������ ����
-- => INSERT(����), UPDATE(����), DELETE(����), (SELECT �굵 DML ��)
-- CRUD = DDL + DML

-- EX)��α� ����Ʈ�� ���� ���̺� ����
-- ����Ʈ ����, �ۼ� ��¥, ����
CREATE TABLE POST (TITLE VARCHAR2(30), DAY VARCHAR2(10), BODY VARCHAR2(100));

-- ����Ʈ ���̺� ���Ͽ� ������ ����
INSERT INTO POST(TITLE, DAY, BODY) VALUES('�ȳ�', '10��13��', '������ 13���� �ݿ����̾�');
INSERT INTO POST(TITLE, DAY, BODY) VALUES('�׷�', '10��13��', '�����ض�');
INSERT INTO POST(TITLE, DAY, BODY) VALUES('����?', '10��13��', '������ ���̴�');
INSERT INTO POST(TITLE, DAY, BODY) VALUES('�ָ�', '10��13��', '��� ������ �ָ��̾�');
INSERT INTO POST(TITLE, DAY, BODY) VALUES('�ູ', '10��13��', '�ູ�� �ݿ����̵Ǳ�');

-- DELETE
-- POST ���̺� �־ BODY�� ���� '�����ض�' �� ������ ����
DELETE FROM POST WHERE BODY = '�����ض�';
-- DELETE FROM POST; <= ��� TRUNCATE �� �Ȱ��� POST�� �����͸� ��ü ���Ű� �ȴ�. 

-- ORACLE �ڷ���
-- ������ 
-- => CHAR(N) :: ���� ũ���� ������ Ÿ��, ������ N���� ������ �Ҵ��Ѵ�.(�ټ� ��ȿ����)
-- => VARCHAR2(N) :: ���� ũ���� ������ Ÿ��, �ִ� N�������� ���� �Ҵ��� �����ϴ�.
-- => NVARCHAR2(N) 
-- ������
-- => INT :: ����
-- => FLOAT :: �Ǽ�
-- => NUMBER(P,S) :: ����/�Ǽ� ��� ����
--    = P(�����κ�+�Ǽ��κ� �ִ� �ۼ� ������ ����)
--    = S(�Ǽ��κ� �ִ� �ۼ� ������ ����)

-- * :: ��ü
-- ����Ʈ ���̺� ���� ��ü �˻��Ͽ� ���
SELECT * FROM POST;

-- DROP :: ���̺� ���� (������, ���̺� ���� ��� ����) 
-- TRUNCATE :: ���̺� ���� (�����͸� ��ü ����, ���̺� ������ ��������)
-- ����Ʈ ���̺� ����
DROP TABLE POST;

COMMIT







