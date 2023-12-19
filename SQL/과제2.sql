--1
CREATE TABLE 직원명단 (
    사원번호 VARCHAR2(10) primary key,
    이름 VARCHAR2(20) not null,
    부서 varchar2(30) not null,
    나이 int
);

--2
create table 부서명단 (
    부서번호 varchar2(5) primary key,
    부서이름 varchar2(30) not null,
    직원수 int
);

--3
insert into 직원명단(사원번호,이름,부서,나이) values('521', '김길동', '경영행정부', 25);
insert into 직원명단(사원번호,이름,부서,나이) values('525', '이길동', '교무부', 40);
insert into 직원명단(사원번호,이름,부서,나이) values('523', '최길동', '교무부', 30);
insert into 직원명단(사원번호,이름,부서,나이) values('524', '정길동', '교무지원부', 29);

--4
insert into 부서명단(부서번호,부서이름,직원수) values('1', '교무부', 30);
insert into 부서명단(부서번호,부서이름,직원수) values('2', '교무지원부', 15);
insert into 부서명단(부서번호,부서이름,직원수) values('3', '경영행정부', 10);

--5
select * from 직원명단;
select * from 부서명단;

--6
select 이름, 부서 from 직원명단;

--7
select 사원번호, 이름, 부서 from 직원명단 where 부서 = '교무부';
--8
select 부서이름, 직원수 from 부서명단 where 직원수 > 10;

--9
select * from 부서명단 where 부서번호 = '2';

--10
drop table 직원명단;
drop table 부서명단;

commit;