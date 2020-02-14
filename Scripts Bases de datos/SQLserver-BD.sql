/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     08/02/2020 19:44:21                          */
/*==============================================================*/


if exists (select 1
            from  sysobjects
           where  id = object_id('REGISTRO_102A')
            and   type = 'U')
   drop table REGISTRO_102A
go

if exists (select 1
            from  sysobjects
           where  id = object_id('REGISTRO_106')
            and   type = 'U')
   drop table REGISTRO_106
go

/*==============================================================*/
/* Table: REGISTRO_102A                                         */
/*==============================================================*/
create table REGISTRO_102A (
   ID_102A              int           Identity    null,
   CED102A              varchar(13)             null,
   A102                  varchar(4)     default ' '      null,
   A104                  varchar(50)      default ' '    null,
   A105                  int               default 0   null,
   A201                  varchar(13)     default ' '     null,
   A202                  varchar(100)    default ' '     null,
   A481                  numeric(9,2)     default 0    null,
   A491                  numeric(9,2)         default 0    null,
   A710                  numeric(9,2)         default 0    null,
   A711                  numeric(9,2)         default 0    null,
   A721                  numeric(9,2)         default 0    null,
   A712                  numeric(9,2)         default 0    null,
   A722                  numeric(9,2)         default 0    null,
   A703                  numeric(9,2)         default 0    null,
   A713                  numeric(9,2)         default 0    null,
   A723                  numeric(9,2)         default 0    null,
   A704                  numeric(9,2)         default 0    null,
   A714                  numeric(9,2)         default 0    null,
   A724                  numeric(9,2)         default 0    null,
   A705                  numeric(9,2)         default 0    null,
   A715                  numeric(9,2)         default 0    null,
   A725                  numeric(9,2)         default 0    null,
   A716                  numeric(9,2)         default 0    null,
   A717                  numeric(9,2)         default 0    null,
   A718                  numeric(9,2)         default 0    null,
   A719                  numeric(9,2)         default 0    null,
   A720                  numeric(9,2)         default 0    null,
   A730                  numeric(9,2)         default 0    null,
   A731                  numeric(9,2)         default 0    null,
   A729                  numeric(9,2)         default 0    null,
   A741                  numeric(9,2)         default 0    null,
   A739                  numeric(9,2)         default 0    null,
   A751                  numeric(9,2)         default 0    null,
   A749                  numeric(9,2)         default 0    null,
   A759                  numeric(9,2)         default 0    null,
   A769                  numeric(9,2)         default 0    null,
   A768                  numeric(9,2)         default 0    null,
   A771                  numeric(9,2)         default 0    null,
   A772                  numeric(9,2)         default 0    null,
   A773                  numeric(9,2)         default 0    null,
   A774                  numeric(9,2)         default 0    null,
   A775                  numeric(9,2)         default 0    null,
   A776                  numeric(9,2)         default 0    null,
   A780                  numeric(9,2)         default 0    null,
   A777                  numeric(9,2)         default 0    null,
   A778                  numeric(9,2)         default 0    null,
   A779                  numeric(9,2)         default 0    null,
   A740                  varchar(50)          default ' '  null,
   A750                  varchar(13)          default ' '  null,
   A760                  numeric(3,0)         default 0    null,
   A770                  numeric(9,2)         default 0    null,
   A781                  numeric(9,2)         default 0    null,
   A782                  numeric(9,2)         default 0    null,
   A783                  numeric(9,2)         default 0    null,
   A784                  numeric(9,2)         default 0    null,
   A786                  numeric(9,2)         default 0    null,
   A787                  numeric(9,2)         default 0    null,
   A789                  numeric(9,2)         default 0    null,
   A832                  numeric(9,2)         default 0    null,
   A839                  numeric(9,2)         default 0    null,
   A840                  numeric(9,2)         default 0    null,
   A842                  numeric(9,2)         default 0    null,
   A843                  numeric(9,2)         default 0    null,
   A845                  numeric(9,2)         default 0    null,
   A846                  numeric(9,2)         default 0    null,
   A847                  numeric(9,2)         default 0    null,
   A848                  numeric(9,2)         default 0    null,
   A849                  numeric(9,2)         default 0    null,
   A850                  numeric(9,2)         default 0    null,
   A851                  numeric(9,2)         default 0    null,
   A852                  numeric(9,2)         default 0    null,
   A855                  numeric(9,2)         default 0    null,
   A856                  numeric(9,2)         default 0    null,
   A857                  numeric(9,2)         default 0    null,
   A858                  numeric(9,2)         default 0    null,
   A859                  numeric(9,2)         default 0    null,
   A869                  numeric(9,2)         default 0    null,
   A880                  numeric(9,2)         default 0    null,
   A881                  numeric(9,2)         default 0    null,
   A882                  numeric(9,2)         default 0    null,
   A879                  numeric(9,2)         default 0    null,
   A871                  numeric(9,2)         default 0    null,
   A872                  numeric(9,2)         default 0    null,
   A890                  numeric(9,2)         default 0    null,
   A897                  numeric(9,2)         default 0    null,
   A898                  numeric(9,2)         default 0    null,
   A899                  numeric(9,2)         default 0    null,
   A902                  numeric(9,2)         default 0    null,
   A903                  numeric(9,2)         default 0    null,
   A904                  numeric(9,2)         default 0    null,
   A999                  numeric(9,2)         default 0    null,
   A905                  numeric(9,2)         default 0    null,
   A906                  numeric(9,2)         default 0    null,
   A907                  numeric(9,2)         default 0    null,
   A908                  varchar(20)          default ' '    null,
   A909                  numeric(9,2)         default 0    null,
   A910                  varchar(20)          default ' '    null,
   A911                  numeric(9,2)         default 0    null,
   A912                  varchar(20)          default ' '    null,
   A913                  numeric(9,2)         default 0    null,
   A915                  numeric(9,2)         default 0    null,
   A916                  varchar(20)          default ' '    null,
   A917                  numeric(9,2)         default 0    null,
   A918                  varchar(20)          default ' '    null,
   A919                  numeric(9,2)         default 0    null,
   A920                  varchar(20)          default ' '    null,
   A198                  varchar(13)          default ' '    null,
   NOMB102A             varchar(100)         default ' '   null,
   constraint PK_REGISTRO_102A primary key nonclustered (ID_102A)
)
go

/*==============================================================*/
/* Table: REGISTRO_106                                          */
/*==============================================================*/
create table REGISTRO_106 (
   ID_106               int          Identity         null,
   CED106               varchar(13)             default ' '    null,
   B101                 varchar(2)           default ' '    null,
   B102                 varchar(4)           default ' '    null,
   B201                 varchar(13)          default ' '    null,
   B202                 varchar(100)         default ' '    null,
   B203                 varchar(20)          default ' '    null,
   B204                 varchar(20)          default ' '    null,
   B205                 varchar(10)          default ' '    null,
   B301                 varchar(10)          default ' '    null,
   B302                 varchar(50)          default ' '    null,
   B303                 varchar(5)           default ' '    null,
   B304                 varchar(20)          default ' '    null,
   B305                 varchar(5)           default ' '    null,
   B306                 varchar(20)          default ' '    null,
   B198                 varchar(13)          default ' '    null,
   B199                 varchar(13)          default ' '    null,
   B902                 numeric(9,2)         default 0    null,
   B903                 numeric(9,2)         default 0    null,
   B904                 numeric(9,2)         default 0    null,
   B999                 numeric(9,2)         default 0    null,
   B905                 numeric(9,2)         default 0    null,
   B906                 numeric(9,2)         default 0    null,
   B907                 numeric(9,2)         default 0    null,
   B925                 numeric(9,2)         default 0    null,
   B908                 varchar(10)          default ' '    null,
   B909                 numeric(9,2)         default 0    null,
   B910                 varchar(10)          default ' '    null,
   B911                 numeric(9,2)         default 0    null,
   B912                 varchar(10)          default ' '    null,
   B913                 numeric(9,2)         default 0    null,
   B914                 varchar(10)          default ' '    null,
   B915                 numeric(9,2)         default 0    null,
   B916                 varchar(10)          default ' '    null,
   B917                 numeric(9,2)         default 0    null,
   B918                 varchar(10)          default ' '    null,
   B919                 numeric(9,2)         default 0    null,
   B920                 numeric(9,2)         default 0    null,
   constraint PK_REGISTRO_106 primary key nonclustered (ID_106)
)
go

