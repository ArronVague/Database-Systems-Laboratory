-- Active: 1700816473701@@gz-cynosdbmysql-grp-04b3z61j.sql.tencentcdb.com@20464@eas_db
SHOW INDEX
FROM
    student_info;

EXPLAIN
SELECT
    *
FROM
    student_info;

EXPLAIN
SELECT
    *
FROM
    employees
WHERE
    first_name = 'Georgi'
    AND gender = 'M'
    AND hire_date = '1986-06-26';

INSERT INTO
    employees
VALUES
    (
        NULL,
        '1970-01-01',
        'Georgi',
        'Facello',
        'M',
        '1986-06-26'
    );