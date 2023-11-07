/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     11/7/2023 10:31:25 AM                        */
/*==============================================================*/


drop table if exists Administrator_Information;

drop table if exists Basic_Information_Books;

drop table if exists Book_Borrowing_Records;

drop table if exists Book_Collection_Information;

drop table if exists Books_Lost;

drop table if exists Overdue_Fine;

drop table if exists Publisher_Information;

drop table if exists Reader_Category;

drop table if exists Reader_Information;

/*==============================================================*/
/* Table: Administrator_Information                             */
/*==============================================================*/
create table Administrator_Information
(
   Aid                  int not null auto_increment,
   name                 varchar(30),
   gender               varchar(10),
   number               varchar(30),
   post                 varchar(10),
   primary key (Aid)
);

/*==============================================================*/
/* Table: Basic_Information_Books                               */
/*==============================================================*/
create table Basic_Information_Books
(
   ISBN                 varchar(13) not null,
   id                   int,
   name                 varchar(30),
   type                 varchar(10),
   author               varchar(30),
   edition              varchar(10),
   publication_date     date,
   price                double,
   introduction         text,
   quantity             int,
   total                int,
   primary key (ISBN)
);

/*==============================================================*/
/* Table: Book_Borrowing_Records                                */
/*==============================================================*/
create table Book_Borrowing_Records
(
   BBid                 int not null auto_increment,
   BCid                 int,
   Rid                  int,
   BAid                 int,
   RAid                 int,
   borrowing_time       date,
   due_time             date,
   renewals             int,
   return_time          date,
   overdue              bool,
   loss                 bool,
   primary key (BBid)
);

/*==============================================================*/
/* Table: Book_Collection_Information                           */
/*==============================================================*/
create table Book_Collection_Information
(
   BCid                 int not null auto_increment,
   ISBN                 varchar(13),
   storage_time         date,
   status               varchar(10),
   primary key (BCid)
);

/*==============================================================*/
/* Table: Books_Lost                                            */
/*==============================================================*/
create table Books_Lost
(
   id                   int not null auto_increment,
   BBid                 int,
   Aid                  int,
   penalty              double,
   pay                  bool,
   operating_time       date,
   remark               text,
   primary key (id)
);

/*==============================================================*/
/* Table: Overdue_Fine                                          */
/*==============================================================*/
create table Overdue_Fine
(
   id                   int not null auto_increment,
   BBid                 int,
   Aid                  int,
   penalty              double,
   pay                  bool,
   fine_date            date,
   remark               text,
   primary key (id)
);

/*==============================================================*/
/* Table: Publisher_Information                                 */
/*==============================================================*/
create table Publisher_Information
(
   id                   int not null auto_increment,
   name                 varchar(30),
   person               varchar(30),
   number               varchar(30),
   fax                  varchar(30),
   address              varchar(50),
   primary key (id)
);

/*==============================================================*/
/* Table: Reader_Category                                       */
/*==============================================================*/
create table Reader_Category
(
   Cid                  int not null auto_increment,
   name                 varchar(30),
   books                int,
   days                 int,
   primary key (Cid)
);

/*==============================================================*/
/* Table: Reader_Information                                    */
/*==============================================================*/
create table Reader_Information
(
   Rid                  int not null,
   Cid                  int,
   name                 varchar(30),
   gender               varchar(10),
   number               varchar(30),
   registration         date,
   valid                date,
   currently            int,
   cumulative           int,
   loss                 bool,
   violations           int,
   remark               text,
   primary key (Rid)
);

alter table Basic_Information_Books add constraint FK_Reference_2 foreign key (id)
      references Publisher_Information (id) on delete restrict on update restrict;

alter table Book_Borrowing_Records add constraint FK_Reference_4 foreign key (BCid)
      references Book_Collection_Information (BCid) on delete restrict on update restrict;

alter table Book_Borrowing_Records add constraint FK_Reference_5 foreign key (Rid)
      references Reader_Information (Rid) on delete restrict on update restrict;

alter table Book_Borrowing_Records add constraint FK_Reference_6 foreign key (BAid)
      references Administrator_Information (Aid) on delete restrict on update restrict;

alter table Book_Borrowing_Records add constraint FK_Reference_7 foreign key (RAid)
      references Administrator_Information (Aid) on delete restrict on update restrict;

alter table Book_Collection_Information add constraint FK_Reference_3 foreign key (ISBN)
      references Basic_Information_Books (ISBN) on delete restrict on update restrict;

alter table Books_Lost add constraint FK_Reference_10 foreign key (BBid)
      references Book_Borrowing_Records (BBid) on delete restrict on update restrict;

alter table Books_Lost add constraint FK_Reference_11 foreign key (Aid)
      references Administrator_Information (Aid) on delete restrict on update restrict;

alter table Overdue_Fine add constraint FK_Reference_8 foreign key (BBid)
      references Book_Borrowing_Records (BBid) on delete restrict on update restrict;

alter table Overdue_Fine add constraint FK_Reference_9 foreign key (Aid)
      references Administrator_Information (Aid) on delete restrict on update restrict;

alter table Reader_Information add constraint FK_Reference_1 foreign key (Cid)
      references Reader_Category (Cid) on delete restrict on update restrict;

