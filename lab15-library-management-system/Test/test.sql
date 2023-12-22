-- Active: 1700816473701@@gz-cynosdbmysql-grp-04b3z61j.sql.tencentcdb.com@20464@library_management_system
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

UPDATE
    basic_information_books
SET
    `ISBN` = '11',
    `id` = 7,
    `name` = '',
    `TYPE` = '',
    `author` = '',
    `edition` = '',
    `publication_date` = NULL,
    `price` = 0,
    `introduction` = '',
    `quantity` = 0,
    `total` = 0
WHERE
    `ISBN` = '11';

SELECT
    *
FROM
    book_collection_information;

INSERT INTO
    book_collection_information
VALUES
    (
        NULL,
        'ISBN',
        '2021-01-01',
        'not lent'
    );

UPDATE
    book_collection_information
SET
    STATUS = 'not lent';

SELECT
    *
FROM
    book_borrowing_records;

SELECT
    *
FROM
    book_collection_information;

SELECT
    *
FROM
    reader_information;

INSERT INTO
    book_borrowing_records
VALUES
    (
        NULL,
        203,
        1,
        2,
        1,
        '2021-01-01',
        '2021-01-01',
        1,
        '2021-01-01',
        0,
        0
    );

SELECT
    *
FROM
    overdue_fine;

INSERT INTO
    overdue_fine
VALUES
    (
        NULL,
        16,
        1,
        20.0,
        0,
        '2023/12/14',
        'remark'
    );

UPDATE
    overdue_fine
SET
    BBid = 14,
    Aid = 3,
    penalty = 107.29,
    pay = 0,
    fine_date = '2022/01/21',
    remark = 'haha'
WHERE
    id = 10
UPDATE
    overdue_fine
SET
    BBid = 14,
    Aid = 3,
    penalty = 107.29,
    pay = 0,
    fine_date = '2022/01/21',
    remark = 'The first step is as good as half over. Genius is an infinite capacity for taking pains. If you wait, all that happens is you get older. A query is used to extract data from the database in a readable format according to the user''s request. To connect to a database or schema, simply double-click it in the pane. Flexible settings enable you to set up a custom key for comparison and synchronization. Difficult circumstances serve as a textbook of life for people. A man is not old until regrets take the place of dreams. Navicat provides a wide range advanced features, such as compelling code editing capabilities, smart code-completion, SQL formatting, and more. Monitored servers include MySQL, MariaDB and SQL Server, and compatible with cloud databases like Amazon RDS, Amazon Aurora, Oracle Cloud, Google Cloud and Microsoft Azure. You will succeed because most people are lazy. Import Wizard allows you to import data to tables/collections from CSV, TXT, XML, DBF and more. The repository database can be an existing MySQL, MariaDB, PostgreSQL, SQL Server, or Amazon RDS instance. Navicat Cloud could not connect and access your databases. By which it means, it could only store your connection settings, queries, model files, and virtual group; your database passwords and data (e.g. tables, views, etc) will not be stored to Navicat Cloud. Navicat allows you to transfer data from one database and/or schema to another with detailed analytical process. The first step is as good as half over. It can also manage cloud databases such as Amazon Redshift, Amazon RDS, Alibaba Cloud. Features in Navicat are sophisticated enough to provide professional developers for all their specific needs, yet easy to learn for users who are new to database server. How we spend our days is, of course, how we spend our lives. The Navigation pane employs tree structure which allows you to take action upon the database and their objects through their pop-up menus quickly and easily. Anyone who has never made a mistake has never tried anything new. If the Show objects under schema in navigation pane option is checked at the Preferences window, all database objects are also displayed in the pane. Navicat provides powerful tools for working with queries: Query Editor for editing the query text directly, and Query Builder, Find Builder or Aggregate Builder for building queries visually. All journeys have secret destinations of which the traveler is unaware. You cannot save people, you can just love them. All the Navicat Cloud objects are located under different projects. You can share the project to other Navicat Cloud accounts for collaboration. Navicat is a multi-connections Database Administration tool allowing you to connect to MySQL, Oracle, PostgreSQL, SQLite, SQL Server, MariaDB and/or MongoDB databases, making database administration to multiple kinds of database so easy. Navicat Monitor requires a repository to store alerts and metrics for historical analysis. Navicat is a multi-connections Database Administration tool allowing you to connect to MySQL, Oracle, PostgreSQL, SQLite, SQL Server, MariaDB and/or MongoDB databases, making database administration to multiple kinds of database so easy. Instead of wondering when your next vacation is, maybe you should set up a life you don’t need to escape from. Navicat Cloud could not connect and access your databases. By which it means, it could only store your connection settings, queries, model files, and virtual group; your database passwords and data (e.g. tables, views, etc) will not be stored to Navicat Cloud. There is no way to happiness. Happiness is the way. I will greet this day with love in my heart. HTTP Tunneling is a method for connecting to a server that uses the same protocol (http://) and the same port (port 80) as a web server does. Always keep your eyes open. Keep watching. Because whatever you see can inspire you.'
WHERE
    id = 10;

/* 用事务实现实现借阅图书业务后，应在数据库留下借阅记录、更新图书馆藏信息、更新图书基本信息；更新读者信息表中的已借数量 */
START TRANSACTION;

INSERT INTO
    book_borrowing_records
VALUES
    (
        NULL,
        203,
        1,
        2,
        1,
        '2021-01-01',
        '2021-01-01',
        1,
        '2021-01-01',
        0,
        0
    );

UPDATE
    book_collection_information
SET
    STATUS = 'lent'
WHERE
    BCid = 203;

UPDATE
    basic_information_books
SET
    quantity = quantity - 1
WHERE
    ISBN = (
        SELECT
            ISBN
        FROM
            book_collection_information
        WHERE
            BCid = 203
    );

UPDATE
    reader_information
SET
    currently = currently + 1
WHERE
    Rid = 1;

COMMIT;