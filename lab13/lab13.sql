-- Active: 1700816473701@@gz-cynosdbmysql-grp-04b3z61j.sql.tencentcdb.com@20464@eas_db
CREATE PROCEDURE getAvgScore(sn VARCHAR(10), out avgs NUMERIC(5, 2))
SELECT
    AVG(Score)
FROM
    score_info
WHERE
    SNo = sn INTO avgs;

call `getAvgScore`('20200101', @a);

SELECT
    @a;

CREATE PROCEDURE maxnum(a int, b int, c int) BEGIN DECLARE s int;

SET
    s = a;

IF b > s THEN
SET
    s = b;

END IF;

IF c > s THEN
SET
    s = c;

END IF;

SELECT
    s;

END;

CALL maxnum(10, 6, 8);

CREATE PROCEDURE calsum(a int, b int) BEGIN DECLARE c int;

SET
    c = a + b;

SELECT
    c AS sum;

END;

CALL calsum(10, 20);

CREATE TRIGGER tri_insert_stu
AFTER
INSERT
    ON student_info FOR EACH ROW
INSERT INTO
    log_info
VALUES
    ('insert a row into student_info');

INSERT INTO
    student_info
VALUES
    (
        '20220801',
        'Linda',
        2,
        '2010-10-01',
        2,
        0,
        NULL,
        NULL
    );

CREATE TRIGGER tri_update_stu
AFTER
UPDATE
    ON student_info FOR EACH ROW
INSERT INTO
    log_info
VALUES
    ('update a row in student_info');

UPDATE
    student_info
SET
    `SName` = 'c'
WHERE
    `SNo` = '20200102';

CREATE TRIGGER tri_update_stu2
AFTER
UPDATE
    ON student_info FOR EACH ROW
INSERT INTO
    log_info
VALUES
    (
        CONCAT(
            'update a row in student_info ',
            OLD.SName,
            ' to ',
            NEW.SName
        )
    );

UPDATE
    student_info
SET
    `SName` = 'ddd'
WHERE
    `SNo` = '20220103';