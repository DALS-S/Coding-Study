-- 1
CREATE TABLE 학생명단 (
    학번 VARCHAR2(10) primary key,
    이름 VARCHAR2(20) not null,
    학년 INT,
    전공 VARCHAR2(50)
);

-- 2
create table 교수명단 (
    번호 varchar2(5) primary key,
    이름 varchar2(20) not null,
    전화번호 varchar2(15) not null,
    소속전공 varchar2(30) not null,
    나이 int
);

-- 3
insert into 학생명단(학번,이름,학년,전공) VALUES('123', '김길동', 1, '컴퓨터공학');
insert into 학생명단(학번,이름,학년,전공) VALUES('124', '권길동', 2, '통계');
insert into 학생명단(학번,이름,학년,전공) VALUES('125', '박길동', 4, '국어국문');
insert into 학생명단(학번,이름,학년,전공) VALUES('126', '정길동', 4, '무역');
insert into 학생명단(학번,이름,학년,전공) VALUES('127', '이길동', 3, '국어국문');

-- 4
insert into 교수명단(번호,이름,전화번호,소속전공,나이) VALUES('1', '김철수', '010-0000-0000', '국어국문', 25);
insert into 교수명단(번호,이름,전화번호,소속전공,나이) VALUES('2', '이영희', '010-1111-1111', '통계', 45);
insert into 교수명단(번호,이름,전화번호,소속전공,나이) VALUES('3', '박훈', '010-2222-2222', '컴퓨터공학', 35);

-- 5
select * from 학생명단;
select * from 교수명단;

-- 6
select 이름, 전공 from 학생명단;

-- 7
select 학번, 이름, 학년 from 학생명단 where 학년 >= 3;

-- 8
select 이름, 전화번호, 소속전공 from 교수명단 where 번호=1;

-- 9
select 이름, 나이 from 교수명단 where 나이 >=35;

-- 10
drop table 학생명단;
drop table 교수명단;

commit;