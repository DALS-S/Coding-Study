--SNACK TABLE 생성
--과자이름, 선호도, 가격, 열량
create table snack (snack_name VARCHAR2(20), hope INT, price INT, kcal INT);

--5~10개의 데이터 SNACK TABLE 에 삽입
--임의로
INSERT INTO snack (snack_name, hope, price, kcal) VALUES ('바나나킥', 5, 1500, 315);
INSERT INTO snack (snack_name, hope, price, kcal) VALUES ('새우깡', 4, 1000, 215);
INSERT INTO snack (snack_name, hope, price, kcal) VALUES ('포스틱', 3, 2000, 415);
INSERT INTO snack (snack_name, hope, price, kcal) VALUES ('오감자', 2, 1500, 315);
INSERT INTO snack (snack_name, hope, price, kcal) VALUES ('콘칲', 1, 3500, 515);

--1. 모든 SNACK 데이터 검색하여 출력
SELECT * FROM snack;

--2. SNACK 테이블의 데이터 개수 출력
--(COUNT 함수 응용)
SELECT COUNT(*) FROM snack;

--3. 아래에 속하는 데이터들 삭제한 뒤 남아있는 데이터출력
--- 가격이 2000원 이상인 과자 데이터 제거
--- 선호도가 1 이하인 과자 데이터 제거
--- 열량이 500 이상인 과자 데이터 제거
DELETE from snack WHERE price>=2000;
DELETE from snack WHERE hope<=1;
DELETE from snack WHERE kcal>=500;
SELECT * FROM snack;

-- DELETE :: 데이터를 삭제하는 명령문
-- DELETE FROM 테이블명 WHERE 조건문;
-- WHERE 조건문 <- 이 부분이 없으면, 테이블에 있는 모든 데이터 없어짐.

--- SNACK 테이블 삭제 (테이블 모두 삭제)
DROP TABLE snack;

COMMIT;


