--1
CREATE TABLE ������� (
    �����ȣ VARCHAR2(10) primary key,
    �̸� VARCHAR2(20) not null,
    �μ� varchar2(30) not null,
    ���� int
);

--2
create table �μ���� (
    �μ���ȣ varchar2(5) primary key,
    �μ��̸� varchar2(30) not null,
    ������ int
);

--3
insert into �������(�����ȣ,�̸�,�μ�,����) values('521', '��浿', '�濵������', 25);
insert into �������(�����ȣ,�̸�,�μ�,����) values('525', '�̱浿', '������', 40);
insert into �������(�����ȣ,�̸�,�μ�,����) values('523', '�ֱ浿', '������', 30);
insert into �������(�����ȣ,�̸�,�μ�,����) values('524', '���浿', '����������', 29);

--4
insert into �μ����(�μ���ȣ,�μ��̸�,������) values('1', '������', 30);
insert into �μ����(�μ���ȣ,�μ��̸�,������) values('2', '����������', 15);
insert into �μ����(�μ���ȣ,�μ��̸�,������) values('3', '�濵������', 10);

--5
select * from �������;
select * from �μ����;

--6
select �̸�, �μ� from �������;

--7
select �����ȣ, �̸�, �μ� from ������� where �μ� = '������';
--8
select �μ��̸�, ������ from �μ���� where ������ > 10;

--9
select * from �μ���� where �μ���ȣ = '2';

--10
drop table �������;
drop table �μ����;

commit;