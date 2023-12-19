-- DJStudent ���̺� �����
-- �й�, �̸�, �а����� ������ (��� Varchar2 �� �� ��)
CREATE TABLE djstudent (
    �й�  VARCHAR2(20),
    �̸�  VARCHAR2(20),
    �а��� VARCHAR2(20)
);

-- KBMajor ���̺� �����
-- �а��ڵ�(char(3)) �а���(varchar2)
CREATE TABLE kbmajor (
    �а��ڵ� CHAR(3) PRIMARY KEY,
    �а���  VARCHAR2(20)
);

-- KBStudent ���̺� �����
-- �й�, �̸�, �а��ڵ�(char(3))
CREATE TABLE kbstudent (
    �й�   VARCHAR2(20) primary key,
    �̸�   VARCHAR2(20),
    �а��ڵ� CHAR(3)
);

-- ���� ���� ������ 5�� �̻� �߰��ϱ�
INSERT INTO djstudent VALUES (
    '21402417',
    '�̰��',
    '�Ϲ���'
);

INSERT INTO djstudent VALUES (
    '21402418',
    '������',
    'ü����'
);

INSERT INTO djstudent VALUES (
    '21402419',
    '�Ӽ�ȯ',
    '�����'
);

INSERT INTO djstudent VALUES (
    '21502420',
    '����ȣ',
    '�����'
);

INSERT INTO djstudent VALUES (
    '21502421',
    '������',
    '������'
);

INSERT INTO kbmajor VALUES (
    '�濵�а�',
    '600'
);

INSERT INTO kbmajor VALUES (
    '�Ϲ���',
    '500'
);

INSERT INTO kbmajor VALUES (
    'ü����',
    '400'
);

INSERT INTO kbmajor VALUES (
    '�����',
    '300'
);

INSERT INTO kbmajor VALUES (
    '������',
    '200'
);

INSERT INTO kbmajor VALUES (
    '�����',
    '100'
);

INSERT INTO kbstudent VALUES (
    '21402417',
    '�̰��',
    '500'
);

INSERT INTO kbstudent VALUES (
    '21402418',
    '������',
    '400'
);

INSERT INTO kbstudent VALUES (
    '21402419',
    '�Ӽ�ȯ',
    '300'
);

INSERT INTO kbstudent VALUES (
    '21502420',
    '����ȣ',
    '100'
);

INSERT INTO kbstudent VALUES (
    '21502421',
    '������',
    '200'
);

-- ���� ����
INSERT INTO kbstudent VALUES (
    '2023',
    'ȫ�浿',
    '800'
);

-- ���� ����
INSERT INTO kbstudent VALUES (
    '2023',
    '��ġ��',
    '500'
);

INSERT INTO kbstudent VALUES (
    '2023',
    '�����',
    '600'
);

-- ���� ���̺��� �а��ڵ带 �����Ͽ��� �л� ���̺��� �����͸� �����ϰڴٴ� �ǹ�
-- ���� ���̺� ���� ������ �߰��� ���� ����.
ALTER TABLE kbstudent
    ADD CONSTRAINT fk_code FOREIGN KEY ( �а��ڵ� )
        REFERENCES kbmajor ( �а��ڵ� );
        
-- �ܷ�Ű ����
alter table kbstudent drop constraint fk_code;

-- join = �ΰ� �̻��� ���̺��� ����� Į������ ���´�.
SELECT
    �й�,
    kbstudent.�̸�,
    kbmajor.�а���
FROM
         kbstudent
    JOIN kbmajor ON kbstudent.�а��ڵ� = kbmajor.�а��ڵ�;
    
    
-- ��(view) 
-- ���� ���̺�
-- �⺻���� ���� ���� ������ �ȵ�, ��� ������ �ٳ��� view ���� �ٲ�(�����Ҷ� �ȵǰ� �ܼ��� �������� ����)
-- view == select �����
-- select ���� �ʹ� ���������ų� Ȥ�� �� ���� ���̴� select ���� �� �� ���ϰ� �ҷ������� ���� ��
-- �⺻ �뵵 ��ü�� �����͸� ���� ���� �뵵��.
create view mystudent as select �й�, kbstudent.�̸� name, kbmajor.�̸� maj_name from kbstudent join kbmajor on kbstudent.�а��ڵ� = kbmajor.�а��ڵ�;

-- �̶� mystudent �� ���� ���� �ƴ�
-- kbstudent, kbmajor �� ������� ������ ǥ
-- deletem update, insert �� �ܼ��� ������ view ������ ������ ������ ������ view ������ �ȵ� (�������� �ʴ� Į���� ���ؼ��� �߰� ���� ���� �Ұ���)
select * from djstudent where maj_name = 'ȭ��';
select * from djstudent;

-- view�� ���ؼ� select���� �ܼ�ȭ�ϰ� ���� ������ ������ join � ���� ����.
insert into kbstduent VALUES(2, '������', '002');

--------------------------------------------------------
-- ������� ���(������ �����ؼ� ���)
-- order by
select * from kbstudent;
select * from kbstudent order by �й�;      -- (��������)
select * from kbstudent order by �й� desc; -- (��������)

-- �׷� ���� ���(group by, having)
-- ����) 
-- �л� 100�� �ִ�.
-- ���л� n��, ���л� m���� ���� ��, �л����� ��� ���� ���� ���ϴ� ���� �׷캰�� ���´ٰ� �Ѵ�

-- kbstudent �� ���� ��� �а����� �� ���ִ��� ����غ����ִ�
-- ���� kbstudent �� ���� ������ �־��ٸ� �а����� ��� ���� � ���� �� ���� ���̴�.
select �а��ڵ�, count(*) from kbstudent group by �а��ڵ�;

-- view ���
-- count(*) :: ���� ��(row ����)
select maj_name, count(*) from djstudent group by maj_name;

-- group by�� where���� �ִµ� �ٷ� having��
-- group by ���� where ��
-- ����)
select maj_name,count(*) from djstudent group by maj_name having count(*) > 1;