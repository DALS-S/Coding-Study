-- 1
CREATE TABLE �л���� (
    �й� VARCHAR2(10) primary key,
    �̸� VARCHAR2(20) not null,
    �г� INT,
    ���� VARCHAR2(50)
);

-- 2
create table ������� (
    ��ȣ varchar2(5) primary key,
    �̸� varchar2(20) not null,
    ��ȭ��ȣ varchar2(15) not null,
    �Ҽ����� varchar2(30) not null,
    ���� int
);

-- 3
insert into �л����(�й�,�̸�,�г�,����) VALUES('123', '��浿', 1, '��ǻ�Ͱ���');
insert into �л����(�й�,�̸�,�г�,����) VALUES('124', '�Ǳ浿', 2, '���');
insert into �л����(�й�,�̸�,�г�,����) VALUES('125', '�ڱ浿', 4, '�����');
insert into �л����(�й�,�̸�,�г�,����) VALUES('126', '���浿', 4, '����');
insert into �л����(�й�,�̸�,�г�,����) VALUES('127', '�̱浿', 3, '�����');

-- 4
insert into �������(��ȣ,�̸�,��ȭ��ȣ,�Ҽ�����,����) VALUES('1', '��ö��', '010-0000-0000', '�����', 25);
insert into �������(��ȣ,�̸�,��ȭ��ȣ,�Ҽ�����,����) VALUES('2', '�̿���', '010-1111-1111', '���', 45);
insert into �������(��ȣ,�̸�,��ȭ��ȣ,�Ҽ�����,����) VALUES('3', '����', '010-2222-2222', '��ǻ�Ͱ���', 35);

-- 5
select * from �л����;
select * from �������;

-- 6
select �̸�, ���� from �л����;

-- 7
select �й�, �̸�, �г� from �л���� where �г� >= 3;

-- 8
select �̸�, ��ȭ��ȣ, �Ҽ����� from ������� where ��ȣ=1;

-- 9
select �̸�, ���� from ������� where ���� >=35;

-- 10
drop table �л����;
drop table �������;

commit;