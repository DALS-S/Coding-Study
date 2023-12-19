-- DJStudent 테이블 만들기
-- 학번, 이름, 학과명을 저장함 (모두 Varchar2 로 할 것)
CREATE TABLE djstudent (
    학번  VARCHAR2(20),
    이름  VARCHAR2(20),
    학과명 VARCHAR2(20)
);

-- KBMajor 테이블 만들기
-- 학과코드(char(3)) 학과명(varchar2)
CREATE TABLE kbmajor (
    학과코드 CHAR(3) PRIMARY KEY,
    학과명  VARCHAR2(20)
);

-- KBStudent 테이블 만들기
-- 학번, 이름, 학과코드(char(3))
CREATE TABLE kbstudent (
    학번   VARCHAR2(20) primary key,
    이름   VARCHAR2(20),
    학과코드 CHAR(3)
);

-- 각각 예시 데이터 5개 이상 추가하기
INSERT INTO djstudent VALUES (
    '21402417',
    '이경민',
    '일문과'
);

INSERT INTO djstudent VALUES (
    '21402418',
    '박현욱',
    '체육과'
);

INSERT INTO djstudent VALUES (
    '21402419',
    '임성환',
    '전기과'
);

INSERT INTO djstudent VALUES (
    '21502420',
    '손준호',
    '설계과'
);

INSERT INTO djstudent VALUES (
    '21502421',
    '배진석',
    '영문과'
);

INSERT INTO kbmajor VALUES (
    '경영학과',
    '600'
);

INSERT INTO kbmajor VALUES (
    '일문과',
    '500'
);

INSERT INTO kbmajor VALUES (
    '체육과',
    '400'
);

INSERT INTO kbmajor VALUES (
    '전기과',
    '300'
);

INSERT INTO kbmajor VALUES (
    '영문과',
    '200'
);

INSERT INTO kbmajor VALUES (
    '설계과',
    '100'
);

INSERT INTO kbstudent VALUES (
    '21402417',
    '이경민',
    '500'
);

INSERT INTO kbstudent VALUES (
    '21402418',
    '박현욱',
    '400'
);

INSERT INTO kbstudent VALUES (
    '21402419',
    '임성환',
    '300'
);

INSERT INTO kbstudent VALUES (
    '21502420',
    '손준호',
    '100'
);

INSERT INTO kbstudent VALUES (
    '21502421',
    '배진석',
    '200'
);

-- 오류 예시
INSERT INTO kbstudent VALUES (
    '2023',
    '홍길동',
    '800'
);

-- 실행 예시
INSERT INTO kbstudent VALUES (
    '2023',
    '최치수',
    '500'
);

INSERT INTO kbstudent VALUES (
    '2023',
    '이재용',
    '600'
);

-- 전공 테이블의 학과코드를 참조하여서 학생 테이블의 데이터를 관리하겠다는 의미
-- 전공 테이블에 없는 전공은 추가할 수가 없다.
ALTER TABLE kbstudent
    ADD CONSTRAINT fk_code FOREIGN KEY ( 학과코드 )
        REFERENCES kbmajor ( 학과코드 );
        
-- 외래키 삭제
alter table kbstudent drop constraint fk_code;

-- join = 두개 이상의 테이블을 공통된 칼럼으로 묶는다.
SELECT
    학번,
    kbstudent.이름,
    kbmajor.학과명
FROM
         kbstudent
    JOIN kbmajor ON kbstudent.학과코드 = kbmajor.학과코드;
    
    
-- 뷰(view) 
-- 가상 테이블
-- 기본적인 삭제 수정 삽입은 안됨, 대신 원본이 바끼면 view 값도 바뀜(복잡할땐 안되고 단순한 구조에는 가능)
-- view == select 결과물
-- select 문이 너무 복작해지거나 혹은 좀 자주 쓰이는 select 문을 좀 더 편하게 불러오고자 쓰는 것
-- 기본 용도 자체가 데이터를 보기 위한 용도임.
create view mystudent as select 학번, kbstudent.이름 name, kbmajor.이름 maj_name from kbstudent join kbmajor on kbstudent.학과코드 = kbmajor.학과코드;

-- 이때 mystudent 는 실제 값이 아님
-- kbstudent, kbmajor 로 만들어진 가상의 표
-- deletem update, insert 가 단순한 구조의 view 에서는 되지만 복잡합 구조의 view 에서는 안됨 (존재하지 않는 칼럼에 대해서는 추가 수정 삭제 불가능)
select * from djstudent where maj_name = '화공';
select * from djstudent;

-- view를 통해서 select문을 단순화하고 보다 복잡한 형대의 join 등도 구현 가능.
insert into kbstduent VALUES(2, '유지웅', '002');

--------------------------------------------------------
-- 순서대로 출력(순서를 지정해서 출력)
-- order by
select * from kbstudent;
select * from kbstudent order by 학번;      -- (오름차순)
select * from kbstudent order by 학번 desc; -- (내림차순)

-- 그룹 별로 출력(group by, having)
-- 예시) 
-- 학생 100명 있다.
-- 남학생 n명, 여학생 m명이 있을 때, 학생별로 평균 나이 등을 구하는 것을 그룹별로 묶는다고 한다

-- kbstudent 로 예를 들면 학과별로 몇 몇있는지 출력해볼수있다
-- 만약 kbstudent 에 나이 정보가 있었다면 학과별로 평균 나이 등구 구할 수 있을 것이다.
select 학과코드, count(*) from kbstudent group by 학과코드;

-- view 사용
-- count(*) :: 행의 수(row 개수)
select maj_name, count(*) from djstudent group by maj_name;

-- group by용 where절이 있는데 바로 having절
-- group by 전용 where 절
-- 예시)
select maj_name,count(*) from djstudent group by maj_name having count(*) > 1;