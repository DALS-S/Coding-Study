-- 한줄 주석 (컨트롤+/)
/*
여러줄 주석
*/

-- 지금까지는 하나의 파일에 대해 전체 코드에 대해 실행해왔으나 
-- 단일 실행(컨트롤+엔터) / 스크립트 실행(전체 코드 실행, 단축키 F5) 별도로 주어짐

-- DataBase = Data + Base
-- DBMS :: DB 를 관리하는 시스템 => Oracle, MySql, MongoDB, ...

-- SQL문(쿼리문) :: DBMS 에서 CRUD 를 수행하기 위해 사용하는 코드
-- CRUD :: Create / Read / Update / Delete => 생성, 읽기, 갱신, 삭제

-- DQL(Data Query Language) :: 데이터를 조회하는 언어
-- => SELECT :: 데이터를 검색하는 문법
-- => SELECT 속성이름 FROM 테이블명 WHERE 조건식;
-- DUAL :: 임시 테이블

SELECT LENGTH('이경민') FROM DUAL;
SELECT LENGTHB('이경민') FROM DUAL;    -- 한글은 한 글자에 3바이트

SELECT LENGTH('GyungMinYi') FROM DUAL;
SELECT LENGTHB('GyungMinYi') FROM DUAL;

-- where 조건식에 대해서 거짓이기에 검색결과 출력 하지 않음
SELECT LENGTH('HELLO') FROM DUAL WHERE LENGTH('HELLO')>=5;

-- DDL(Data Definition Language) :: 데이터 구조(DB, 테이블, ...)를 정의하는 언어
-- => CREATE, ALTER, DROP, TRUNCATE, RENAME

-- CREATE :: 데이터를 저장할 공간을 생성
-- CREATE TABLE 테이블명 (
--    속성이름, 속성타입, ...
-- );

create table STUDENT (
    hak_bun VARCHAR2 (10) PRIMARY KEY, 
    name VARCHAR2(20) NOT NULL,
    age INT NOT NULL,
    score FLOAT
);

-- NOT NULL :: NULL 이 되면 안되는 속성에 작성
-- PRIMARY KEY :: 기본키 = 데이터들끼리 구분하기 위한 속성에 부여

SELECT * FROM STUDENT;
-- 이때 * 의 의미는 전체속성 이라고 보면 된다

-- VARCHAR2 타입과 INT, NUMBER 를 주로 사용

-- 문자형
-- CHAR(n) :: 고정 길이를 갖는 문자열
-- => 무조건 n 의 크기를 할당

-- VARCHAR2(n)  :: 가변 길이를 갖는 문자열
-- => 최대 크기를 n 으로 갖고 필요에 따라 0~n 까지의 범위 할당
-- => 한글 하나에 대해 n개 중 3개의 공간을 차지한다
-- NVARCHAR2(n) :: 가변 길이를 갖는 문자열
-- => 최대 크기를 n 으로 갖고 필요에 따라 0~n 까지의 범위 할당
-- => 한글 하나에 대해 n개 중 1개의 공간을 차지한다

-- 숫자형
-- INT :: 정수 숫자형
-- FLOAT :: 실수 숫자형
-- NUMBER(p, s) :: 정수/실수 둘다 저장 가능한 숫자형
-- => p :: 정수&실수 부분에서 최대로 저장 가능한 범위
-- => s :: 실수 부분에서 최대로 저장 가능한 범위
-- 예시) 속성명이 HEIGHT 이고 속성타입이 NUMBER(4,1) 이라 한다면 000.0 형태로 저장 가능

-- 그 외에도 날짜 타입, LOB형 도 있음

-- DML :: 데이터를 조작하는 명령어
-- INSERT :: 테이블에 데이터 삽입하는 명령어
-- INSERT INTO 테이블명 VALUES(데이터값1, 데이터값2, ...);
-- => 속성들이 선언된 순서대로 데이터 값을 삽입
-- INSERT INTO 테이블명(속성명1, 속성명2, ...) VALUES(데이터값1, 데이터값2, ...);
-- => 속성값1에는 데이터값1 삽입, 속성값2에는 데이터값2 삽입, ...

INSERT INTO STUDENT VALUES(21402149, '이경민', 30, 5.5);
SELECT * FROM STUDENT;

-- DROP, TRUNCATE :: 테이블을 삭제하는 명령어
-- DROP :: 테이블 데이터 모두 삭제
-- DROP TABLE IF EXISTS 테이블명
-- TRUNCATE :: 테이블의 형태는 남겨두고 데이터들만 모두 삭제
-- TRUNCATE TABLE IF EXISTS 테이블명
-- IF EXISTS 사용 시, 테이블이 존재할 때만 명령문 수행 (오라클에서는 지원하지 않는다.)

-- ALTER :: 데이터 구조에 대한 수정
-- => ADD, DROP, MODIFY, RENAME, RENAME COLUMN

-- ALTER :: 칼럼 추가 (ADD)
-- ALTER TABLE 테이블명 ADD 추가할속성이름 추가할속성타입
ALTER TABLE STUDENT ADD GRADE INT;

-- ALTER :: 칼럼 삭제 (DROP)
-- ALTER TABLE 테이블명 DROP 제거할속성이름 제거할속성타입
ALTER TABLE STUDENT DROP COLUMN AGE;

-- ALTER :: 테이블명 변경 (RENAME)
-- ALTER TABLE 테이블명 RENAME TO 변경할테이블명
ALTER TABLE STUDENT RENAME TO HAKSANG;

-- ALTER :: 칼럼명 변경(RENAME COLUMN)
-- ALTER TABLE 테이블명 RENAME COLUMN 컬럼명(기존 속성이름) TO 변경할컬럼명
ALTER TABLE HAKSANG RENAME COLUMN HAK_BUN TO NUM;
SELECT * FROM HAKSANG;

--TRUNCATE TABLE STUDENT; -- table student 가 잘렸습니다 수행
--DROP TABLE IF EXISTS STUDENT;     -- table student 가 삭제되었습니다 수행
--SELECT * FROM STUDENT;
SELECT * FROM HAKSANG;
--DROP TABLE STUDENT;
DROP TABLE HAKSANG;

COMMIT;










