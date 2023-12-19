-- 문장 끝마다 세미콜론(;) 넣기
-- 대소문자 구분 없음

-- CRUD :: CREATE / READ / UPDATE / DELETE => 생성/읽기/갱신/삭제
-- SQL문 :: 위의 CRUD 기능을 수행하기 위한 명령문(질의문)
-- => DQL / DDL / DML / DCL / TCL

-- DQL(QUERY) :: 데이터 조회 
-- => SELECT문 :: 데이터를 검색하는 명령어 (검색된 결과는 출력됨)
-- => SELECT 칼럼명 FROM 테이블명 WHERE 조건문;

SELECT LENGTH('HELLOSQL') FROM DUAL WHERE LENGTH('HELLOSQL') >=5; 
-- 이때 DUAL 은 임시 테이블명임.

-- DDL(DEFINATION) :: 데이터 구조(DB, TABLE, ...)를 정의 
-- => CREATE(생성), ALTER(수정), DROP, TRUNCATE(삭제)

-- DML(MANIPULATION) :: 데이터 조작
-- => INSERT(삽입), UPDATE(수정), DELETE(삭제), (SELECT 얘도 DML 임)
-- CRUD = DDL + DML

-- EX)블로그 포스트에 대한 테이블 생성
-- 포스트 제목, 작성 날짜, 본문
CREATE TABLE POST (TITLE VARCHAR2(30), DAY VARCHAR2(10), BODY VARCHAR2(100));

-- 포스트 테이블에 대하여 데이터 삽입
INSERT INTO POST(TITLE, DAY, BODY) VALUES('안녕', '10월13일', '오늘은 13일의 금요일이야');
INSERT INTO POST(TITLE, DAY, BODY) VALUES('그래', '10월13일', '조심해라');
INSERT INTO POST(TITLE, DAY, BODY) VALUES('알지?', '10월13일', '무서운 날이다');
INSERT INTO POST(TITLE, DAY, BODY) VALUES('주말', '10월13일', '대신 내일은 주말이야');
INSERT INTO POST(TITLE, DAY, BODY) VALUES('행복', '10월13일', '행복한 금요일이되길');

-- DELETE
-- POST 테이블에 있어서 BODY의 값이 '조심해라' 인 데이터 제거
DELETE FROM POST WHERE BODY = '조심해라';
-- DELETE FROM POST; <= 얘는 TRUNCATE 랑 똑같이 POST의 데이터만 전체 제거가 된다. 

-- ORACLE 자료형
-- 문자형 
-- => CHAR(N) :: 고정 크기의 문자형 타입, 무조건 N개의 공간을 할당한다.(다소 비효율적)
-- => VARCHAR2(N) :: 가변 크기의 문자형 타입, 최대 N개까지의 공간 할당이 가능하다.
-- => NVARCHAR2(N) 
-- 숫자형
-- => INT :: 정수
-- => FLOAT :: 실수
-- => NUMBER(P,S) :: 정수/실수 모두 가능
--    = P(정수부분+실수부분 최대 작성 가능한 공간)
--    = S(실수부분 최대 작성 가능한 공간)

-- * :: 전체
-- 포스트 테이블에 대해 전체 검색하여 출력
SELECT * FROM POST;

-- DROP :: 테이블 삭제 (데이터, 테이블 구조 모두 삭제) 
-- TRUNCATE :: 테이블 삭제 (데이터만 전체 삭제, 테이블 구조는 남아있음)
-- 포스트 테이블 삭제
DROP TABLE POST;

COMMIT







