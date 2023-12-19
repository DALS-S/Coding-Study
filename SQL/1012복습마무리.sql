-- DDL(DEFINATION) :: 데이터 구조(DB, TABLE, ...)를 정의 
-- => CREATE(생성), ALTER(수정), DROP, TRUNCATE(삭제)

-- DML(MANIPULATION) :: 데이터 조작
-- => INSERT(삽입), UPDATE(수정), DELETE(삭제), (SELECT 얘도 DML 임)
-- CRUD = DDL + DML

-- 휴대폰 테이블 생성
CREATE TABLE phone (
    name  VARCHAR2(20),     -- 기종
    os    VARCHAR2(50),     -- 운영체제
    day   INT,              -- 출시년도
    wat   INT,              -- 배터리 최대 와트
    color VARCHAR2(20)      -- 색상
);

-- PHONE 테이블에 데이터 추가
INSERT INTO PHONE(NAME,OS,DAY,COLOR,INCH) VALUES('갤럭시S23', '안드로이드14', 2023, '펄화이트', 10.5);
INSERT INTO PHONE(NAME,OS,DAY,COLOR,INCH) VALUES('갤럭시S22', '안드로이드14', 2022, '용달블루', 9.6);
INSERT INTO PHONE(NAME,OS,DAY,COLOR,INCH) VALUES('아이폰13', 'IOS13', 2021, '다라이레드', 8.2);

-- ALTER :: 데이터 구조에 대해 수정하는 명령어
-- => ADD :: 칼럼 추가
-- => DROP COLUMN :: 칼럼 제거
-- => MODIFY :: 칼럼의 타입 수정
-- => RENAME :: 테이블명 변경
-- => RENAME COLUMN :: 칼럼명 변경

-- ADD
-- ALTER TABLE 테이블명 ADD 칼럼명 칼럼타입;
-- PHONE 테이블의 FLOAT 형 INCH 칼럼 추가
ALTER TABLE PHONE ADD INCH FLOAT;

-- DROP COLUMN
-- ALTER TABLE 테이블명 DROP COLUMN 칼럼명;
-- PHONE 테이블의 WAT 칼럼 제거
ALTER TABLE PHONE DROP COLUMN WAT;

-- RENAME :: 테이블명 변경
-- ALTER TABLE 테이블명 RENAME TO 변결할테이블명
-- PHONE 테이블을 SMARTPHONE_LIST 로 변경
ALTER TABLE PHONE RENAME TO SMARTPHONE_LIST;
ALTER TABLE SMARTPHONE_LIST RENAME TO PHONE;

-- RENAME COLUMN :: 칼럼명 변경
-- ALTER TABLE 테이블명 RENAME COLUMN 기존칼럼명 TO 변경할칼럼명
-- PHONE 테이블의 DAY를 YEAR로 변경
ALTER TABLE PHONE RENAME COLUMN DAY TO YEAR;

-- MODIFY :: 데이터 칼럼의 타입 변경
-- ALTER TABLE 테이블명 MODIFY 칼럼명 변경할속성타입;
-- PHONE 테이블에서 INCH 칼럼의 타입을 FLOAT 에서 INT로 변경
-- 데이터를 비운 상태로 MODIFY 를 수행해야한다.
-- ALTER TABLE PHONE MODIFY INCH INT;

-- UPDATE :: 특정 데이터를 수정하는 명령어
-- UPDATE 테이블명 SET 칼럼1=변경값1, ... WHERE 조건절;
-- 출시년도가 2022인 데이터의 OS 값을 안드로이드13으로 변경
UPDATE PHONE SET OS='안드로이드13' WHERE DAY=2022;
UPDATE PHONE SET COLOR='블랙' WHERE NAME='아이폰13';

SELECT * FROM PHONE;
DROP TABLE PHONE;
COMMIT;

