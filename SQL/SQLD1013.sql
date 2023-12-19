-- COMMIT :: 변경 사항을 영구적으로 적용
-- COMMIT 을 하지 않는다면, 계정에 적용을 하였던 모든 변경 사항들이 날라간다.
-- 계정에 적용한 변경 사항 중 중요한 내용이 있으면 되도록 커밋 하는 것이 좋음.
COMMIT;

-- ROLLBACK :: 회귀한다/돌아간다
-- => 그냥 ROLLBACK 만 사용하게 되면 마지막으로 COMMIT 한 내용으로 돌아간다.
-- => ROLLBACK TO 세이브포인트명; (지정된 세이브포인트로 돌아간다.)
ROLLBACK;

-- SAVEPOINT :: 커밋을 하기엔 애매하지만, 해당 지점을 저장하고 싶을 때 사용한다.
-- => SAVEPOINT 저장할세이브포인트명;
SAVEPOINT 세이브1;
ROLLBACK TO 세이브1;