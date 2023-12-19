--SNACK TABLE ª˝º∫
--∞˙¿⁄¿Ã∏ß, º±»£µµ, ∞°∞›, ø≠∑Æ
create table snack (snack_name VARCHAR2(20), hope INT, price INT, kcal INT);

--5~10∞≥¿« µ•¿Ã≈Õ SNACK TABLE ø° ª¿‘
--¿”¿«∑Œ
INSERT INTO snack (snack_name, hope, price, kcal) VALUES ('πŸ≥™≥™≈±', 5, 1500, 315);
INSERT INTO snack (snack_name, hope, price, kcal) VALUES ('ªıøÏ±¯', 4, 1000, 215);
INSERT INTO snack (snack_name, hope, price, kcal) VALUES ('∆˜Ω∫∆Ω', 3, 2000, 415);
INSERT INTO snack (snack_name, hope, price, kcal) VALUES ('ø¿∞®¿⁄', 2, 1500, 315);
INSERT INTO snack (snack_name, hope, price, kcal) VALUES ('ƒ‹ØÖ', 1, 3500, 515);

--1. ∏µÁ SNACK µ•¿Ã≈Õ ∞Àªˆ«œø© √‚∑¬
SELECT * FROM snack;

--2. SNACK ≈◊¿Ã∫Ì¿« µ•¿Ã≈Õ ∞≥ºˆ √‚∑¬
--(COUNT «‘ºˆ ¿¿øÎ)
SELECT COUNT(*) FROM snack;

--3. æ∆∑°ø° º”«œ¥¬ µ•¿Ã≈ÕµÈ ªË¡¶«— µ⁄ ≥≤æ∆¿÷¥¬ µ•¿Ã≈Õ√‚∑¬
--- ∞°∞›¿Ã 2000ø¯ ¿ÃªÛ¿Œ ∞˙¿⁄ µ•¿Ã≈Õ ¡¶∞≈
--- º±»£µµ∞° 1 ¿Ã«œ¿Œ ∞˙¿⁄ µ•¿Ã≈Õ ¡¶∞≈
--- ø≠∑Æ¿Ã 500 ¿ÃªÛ¿Œ ∞˙¿⁄ µ•¿Ã≈Õ ¡¶∞≈
DELETE from snack WHERE price>=2000;
DELETE from snack WHERE hope<=1;
DELETE from snack WHERE kcal>=500;
SELECT * FROM snack;

-- DELETE :: µ•¿Ã≈Õ∏¶ ªË¡¶«œ¥¬ ∏Ì∑…πÆ
-- DELETE FROM ≈◊¿Ã∫Ì∏Ì WHERE ¡∂∞«πÆ;
-- WHERE ¡∂∞«πÆ <- ¿Ã ∫Œ∫–¿Ã æ¯¿∏∏È, ≈◊¿Ã∫Ìø° ¿÷¥¬ ∏µÁ µ•¿Ã≈Õ æ¯æÓ¡¸.

--- SNACK ≈◊¿Ã∫Ì ªË¡¶ (≈◊¿Ã∫Ì ∏µŒ ªË¡¶)
DROP TABLE snack;

COMMIT;


