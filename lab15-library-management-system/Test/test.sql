-- Active: 1701051173366@@gz-cynosdbmysql-grp-04b3z61j.sql.tencentcdb.com@20464@library_management_system
INSERT INTO
    reader_category
VALUES
    (NULL, 'test', 10, 10);

SELECT
    Rid,
    PASSWORD,
    reader_category.name AS category,
    reader_information.name,
    gender,
    number,
    registration,
    valid,
    currently,
    cumulative,
    loss,
    violations,
    remark
FROM
    reader_information,
    reader_category
WHERE
    reader_information.`Cid` = reader_category.`Cid`;

INSERT INTO
    reader_information
VALUES
    (
        5,
        '123456',
        2,
        'test',
        'male',
        '12345678901',
        '2021-01-01',
        'NULL',
        0,
        0,
        FALSE,
        0,
        NULL
    );

SELECT
    *
FROM
    reader_category;

INSERT INTO
    publisher_information
VALUES
    (
        NULL,
        'name',
        'person',
        'number',
        'fax',
        'address'
    );