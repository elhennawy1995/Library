/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     05/01/2015 5:43:28 PM                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOKS') and o.name = 'FK_BOOKS_BELONG_TO_CATEGORY')
alter table BOOKS
   drop constraint FK_BOOKS_BELONG_TO_CATEGORY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BORROWED_BY') and o.name = 'FK_BORROWED_BORROWED__BOOKS')
alter table BORROWED_BY
   drop constraint FK_BORROWED_BORROWED__BOOKS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BORROWED_BY') and o.name = 'FK_BORROWED_BORROWED__CLIENTS')
alter table BORROWED_BY
   drop constraint FK_BORROWED_BORROWED__CLIENTS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('WRITTEN_BY') and o.name = 'FK_WRITTEN__WRITTEN_B_BOOKS')
alter table WRITTEN_BY
   drop constraint FK_WRITTEN__WRITTEN_B_BOOKS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('WRITTEN_BY') and o.name = 'FK_WRITTEN__WRITTEN_B_AUTHOR')
alter table WRITTEN_BY
   drop constraint FK_WRITTEN__WRITTEN_B_AUTHOR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AUTHOR')
            and   type = 'U')
   drop table AUTHOR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOOKS')
            and   type = 'U')
   drop table BOOKS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BORROWED_BY')
            and   type = 'U')
   drop table BORROWED_BY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CATEGORY')
            and   type = 'U')
   drop table CATEGORY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CLIENTS')
            and   type = 'U')
   drop table CLIENTS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('WRITTEN_BY')
            and   type = 'U')
   drop table WRITTEN_BY
go

/*==============================================================*/
/* Table: AUTHOR                                                */
/*==============================================================*/
create table AUTHOR (
   A_ID                 varchar(10)          not null,
   A_FNAME              varchar(30)          not null,
   A_LNAME              varchar(30)          not null,
   constraint PK_AUTHOR primary key nonclustered (A_ID)
)
go

/*==============================================================*/
/* Table: BOOKS                                                 */
/*==============================================================*/
create table BOOKS (
   B_ID                 varchar(10)          not null,
   CAT_ID               varchar(10)          not null,
   B_NAME               varchar(50)          not null,
   PUBLICATION_DATE     datetime             not null,
   constraint PK_BOOKS primary key nonclustered (B_ID)
)
go

/*==============================================================*/
/* Table: BORROWED_BY                                           */
/*==============================================================*/
create table BORROWED_BY (
   B_ID                 varchar(10)          not null,
   C_ID                 varchar(10)          not null,
   BORROW_DATE          datetime             not null,
   DUE_DATE             datetime             not null,
   FINE                 money                null,
   constraint PK_BORROWED_BY primary key (B_ID, C_ID)
)
go

/*==============================================================*/
/* Table: CATEGORY                                              */
/*==============================================================*/
create table CATEGORY (
   CAT_ID               varchar(10)          not null,
   CAT_NAME             varchar(30)          not null,
   constraint PK_CATEGORY primary key nonclustered (CAT_ID)
)
go

/*==============================================================*/
/* Table: CLIENTS                                               */
/*==============================================================*/
create table CLIENTS (
   C_ID                 varchar(10)          not null,
   C_NAME               varchar(30)          not null,
   PHONE_NUMBER         varchar(20)          not null,
   constraint PK_CLIENTS primary key nonclustered (C_ID)
)
go

/*==============================================================*/
/* Table: WRITTEN_BY                                            */
/*==============================================================*/
create table WRITTEN_BY (
   B_ID                 varchar(10)          not null,
   A_ID                 varchar(10)          not null,
   constraint PK_WRITTEN_BY primary key (B_ID, A_ID)
)
go

alter table BOOKS
   add constraint FK_BOOKS_BELONG_TO_CATEGORY foreign key (CAT_ID)
      references CATEGORY (CAT_ID)
go

alter table BORROWED_BY
   add constraint FK_BORROWED_BORROWED__BOOKS foreign key (B_ID)
      references BOOKS (B_ID)
go

alter table BORROWED_BY
   add constraint FK_BORROWED_BORROWED__CLIENTS foreign key (C_ID)
      references CLIENTS (C_ID)
go

alter table WRITTEN_BY
   add constraint FK_WRITTEN__WRITTEN_B_BOOKS foreign key (B_ID)
      references BOOKS (B_ID)
go

alter table WRITTEN_BY
   add constraint FK_WRITTEN__WRITTEN_B_AUTHOR foreign key (A_ID)
      references AUTHOR (A_ID)
go

