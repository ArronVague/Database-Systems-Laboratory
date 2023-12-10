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

CREATE TRIGGER `update_basic_information_books`
AFTER
UPDATE
    ON book_collection_information FOR EACH ROW BEGIN
UPDATE
    basic_information_books
SET
    quantity = (
        SELECT
            COUNT(*)
        FROM
            book_collection_information
        WHERE
            book_collection_information.`ISBN` = NEW.`ISBN`
            AND book_collection_information.status = 'not lent'
    ),
    total = (
        SELECT
            COUNT(*)
        FROM
            book_collection_information
        WHERE
            book_collection_information.`ISBN` = NEW.`ISBN`
    )
WHERE
    `ISBN` = NEW.`ISBN`;

UPDATE
    basic_information_books
SET
    quantity = (
        SELECT
            COUNT(*)
        FROM
            book_collection_information
        WHERE
            book_collection_information.`ISBN` = OLD.`ISBN`
            AND book_collection_information.status = 'not lent'
    ),
    total = (
        SELECT
            COUNT(*)
        FROM
            book_collection_information
        WHERE
            book_collection_information.`ISBN` = OLD.`ISBN`
    )
WHERE
    `ISBN` = OLD.`ISBN`;

END;

UPDATE
    basic_information_books
SET
    quantity = (
        SELECT
            COUNT(*)
        FROM
            book_collection_information
        WHERE
            book_collection_information.`ISBN` = 2
            AND book_collection_information.status = 'not lent'
    ),
    total = (
        SELECT
            COUNT(*)
        FROM
            book_collection_information
        WHERE
            book_collection_information.`ISBN` = 2
    )
WHERE
    `ISBN` = 2;

CREATE TRIGGER `insert_basic_information_books`
AFTER
INSERT
    ON book_collection_information FOR EACH ROW BEGIN
UPDATE
    basic_information_books
SET
    quantity = (
        SELECT
            COUNT(*)
        FROM
            book_collection_information
        WHERE
            book_collection_information.`ISBN` = NEW.`ISBN`
            AND book_collection_information.status = 'not lent'
    ),
    total = (
        SELECT
            COUNT(*)
        FROM
            book_collection_information
        WHERE
            book_collection_information.`ISBN` = NEW.`ISBN`
    )
WHERE
    `ISBN` = NEW.`ISBN`;

END;

CREATE TRIGGER `delete_basic_information_books`
AFTER
    DELETE ON book_collection_information FOR EACH ROW BEGIN
UPDATE
    basic_information_books
SET
    quantity = (
        SELECT
            COUNT(*)
        FROM
            book_collection_information
        WHERE
            book_collection_information.`ISBN` = OLD.`ISBN`
            AND book_collection_information.status = 'not lent'
    ),
    total = (
        SELECT
            COUNT(*)
        FROM
            book_collection_information
        WHERE
            book_collection_information.`ISBN` = OLD.`ISBN`
    )
WHERE
    `ISBN` = OLD.`ISBN`;

END;

INSERT INTO
    basic_information_books
VALUES
    (
        'ISBN',
        7,
        'name',
        'type',
        'author',
        'edition',
        '2022/12/12',
        10.0,
        'introduction',
        1,
        1
    );

SELECT
    ISBN,
    publisher_information.name AS publisher,
    basic_information_books.name,
    TYPE,
    author,
    edition,
    publication_date,
    price,
    introduction,
    quantity,
    total
FROM
    basic_information_books,
    publisher_information
WHERE
    basic_information_books.`id` = publisher_information.`id`;