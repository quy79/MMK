USE [OptMailMarketting]
GO
/****** Object:  ForeignKey [FK_AUTORESP_REFERENCE_LISTS]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[AUTORESPONDER] DROP CONSTRAINT [FK_AUTORESP_REFERENCE_LISTS]
GO
/****** Object:  ForeignKey [FK_AUTORESP_REFERENCE_USERS]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[AUTORESPONDER] DROP CONSTRAINT [FK_AUTORESP_REFERENCE_USERS]
GO
/****** Object:  ForeignKey [FK_AUTORESP_REFERENCE_AUTORESP]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[AUTORESPONDER_MESSAGES] DROP CONSTRAINT [FK_AUTORESP_REFERENCE_AUTORESP]
GO
/****** Object:  ForeignKey [FK_AUTORESP_REFERENCE_MESSAGES]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[AUTORESPONDER_MESSAGES] DROP CONSTRAINT [FK_AUTORESP_REFERENCE_MESSAGES]
GO
/****** Object:  ForeignKey [FK_CONTACT__REFERENCE_CONTACTS]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[CONTACT_LIST] DROP CONSTRAINT [FK_CONTACT__REFERENCE_CONTACTS]
GO
/****** Object:  ForeignKey [FK_CONTACT__REFERENCE_LISTS]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[CONTACT_LIST] DROP CONSTRAINT [FK_CONTACT__REFERENCE_LISTS]
GO
/****** Object:  ForeignKey [FK_LISTS_REFERENCE_MESSAGES]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[LISTS] DROP CONSTRAINT [FK_LISTS_REFERENCE_MESSAGES]
GO
/****** Object:  ForeignKey [FK_LISTS_REFERENCE_USERS]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[LISTS] DROP CONSTRAINT [FK_LISTS_REFERENCE_USERS]
GO
/****** Object:  ForeignKey [FK_MESSAGES_REFERENCE_USERS]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[MESSAGES] DROP CONSTRAINT [FK_MESSAGES_REFERENCE_USERS]
GO
/****** Object:  ForeignKey [FK_SEGMENT__REFERENCE_CONTACTS]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[SEGMENT_CONTACT] DROP CONSTRAINT [FK_SEGMENT__REFERENCE_CONTACTS]
GO
/****** Object:  ForeignKey [FK_SEGMENT__REFERENCE_SEGMENT]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[SEGMENT_CONTACT] DROP CONSTRAINT [FK_SEGMENT__REFERENCE_SEGMENT]
GO
/****** Object:  ForeignKey [FK_SENTEMAI_REFERENCE_AUTORESP]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[SENTEMAILS] DROP CONSTRAINT [FK_SENTEMAI_REFERENCE_AUTORESP]
GO
/****** Object:  ForeignKey [FK_SENTEMAI_REFERENCE_CONTACTS]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[SENTEMAILS] DROP CONSTRAINT [FK_SENTEMAI_REFERENCE_CONTACTS]
GO
/****** Object:  ForeignKey [FK_SENTEMAI_REFERENCE_MESSAGES]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[SENTEMAILS] DROP CONSTRAINT [FK_SENTEMAI_REFERENCE_MESSAGES]
GO
/****** Object:  StoredProcedure [dbo].[SP_AUTORESPONDER_MESSAGES_Delete]    Script Date: 05/25/2012 01:35:28 ******/
DROP PROCEDURE [dbo].[SP_AUTORESPONDER_MESSAGES_Delete]
GO
/****** Object:  StoredProcedure [dbo].[SP_AUTORESPONDER_MESSAGES_Insert]    Script Date: 05/25/2012 01:35:28 ******/
DROP PROCEDURE [dbo].[SP_AUTORESPONDER_MESSAGES_Insert]
GO
/****** Object:  StoredProcedure [dbo].[SP_AUTORESPONDER_MESSAGES_Select]    Script Date: 05/25/2012 01:35:28 ******/
DROP PROCEDURE [dbo].[SP_AUTORESPONDER_MESSAGES_Select]
GO
/****** Object:  StoredProcedure [dbo].[SP_AUTORESPONDER_MESSAGES_Update]    Script Date: 05/25/2012 01:35:28 ******/
DROP PROCEDURE [dbo].[SP_AUTORESPONDER_MESSAGES_Update]
GO
/****** Object:  StoredProcedure [dbo].[SP_SENTEMAILS_Delete]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_SENTEMAILS_Delete]
GO
/****** Object:  StoredProcedure [dbo].[SP_SENTEMAILS_Insert]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_SENTEMAILS_Insert]
GO
/****** Object:  StoredProcedure [dbo].[SP_SENTEMAILS_Select]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_SENTEMAILS_Select]
GO
/****** Object:  StoredProcedure [dbo].[SP_SENTEMAILS_Update]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_SENTEMAILS_Update]
GO
/****** Object:  StoredProcedure [dbo].[SP_AUTORESPONDER_Select]    Script Date: 05/25/2012 01:35:28 ******/
DROP PROCEDURE [dbo].[SP_AUTORESPONDER_Select]
GO
/****** Object:  StoredProcedure [dbo].[SP_AUTORESPONDER_Update]    Script Date: 05/25/2012 01:35:28 ******/
DROP PROCEDURE [dbo].[SP_AUTORESPONDER_Update]
GO
/****** Object:  Table [dbo].[SENTEMAILS]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[SENTEMAILS] DROP CONSTRAINT [FK_SENTEMAI_REFERENCE_AUTORESP]
GO
ALTER TABLE [dbo].[SENTEMAILS] DROP CONSTRAINT [FK_SENTEMAI_REFERENCE_CONTACTS]
GO
ALTER TABLE [dbo].[SENTEMAILS] DROP CONSTRAINT [FK_SENTEMAI_REFERENCE_MESSAGES]
GO
DROP TABLE [dbo].[SENTEMAILS]
GO
/****** Object:  StoredProcedure [dbo].[SP_AUTORESPONDER_Delete]    Script Date: 05/25/2012 01:35:28 ******/
DROP PROCEDURE [dbo].[SP_AUTORESPONDER_Delete]
GO
/****** Object:  StoredProcedure [dbo].[SP_AUTORESPONDER_Insert]    Script Date: 05/25/2012 01:35:28 ******/
DROP PROCEDURE [dbo].[SP_AUTORESPONDER_Insert]
GO
/****** Object:  StoredProcedure [dbo].[SP_CONTACT_LIST_Delete]    Script Date: 05/25/2012 01:35:28 ******/
DROP PROCEDURE [dbo].[SP_CONTACT_LIST_Delete]
GO
/****** Object:  StoredProcedure [dbo].[SP_CONTACT_LIST_Insert]    Script Date: 05/25/2012 01:35:28 ******/
DROP PROCEDURE [dbo].[SP_CONTACT_LIST_Insert]
GO
/****** Object:  StoredProcedure [dbo].[SP_CONTACT_LIST_Select]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_CONTACT_LIST_Select]
GO
/****** Object:  Table [dbo].[AUTORESPONDER_MESSAGES]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[AUTORESPONDER_MESSAGES] DROP CONSTRAINT [FK_AUTORESP_REFERENCE_AUTORESP]
GO
ALTER TABLE [dbo].[AUTORESPONDER_MESSAGES] DROP CONSTRAINT [FK_AUTORESP_REFERENCE_MESSAGES]
GO
DROP TABLE [dbo].[AUTORESPONDER_MESSAGES]
GO
/****** Object:  Table [dbo].[CONTACT_LIST]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[CONTACT_LIST] DROP CONSTRAINT [FK_CONTACT__REFERENCE_CONTACTS]
GO
ALTER TABLE [dbo].[CONTACT_LIST] DROP CONSTRAINT [FK_CONTACT__REFERENCE_LISTS]
GO
DROP TABLE [dbo].[CONTACT_LIST]
GO
/****** Object:  StoredProcedure [dbo].[SP_LISTS_Delete]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_LISTS_Delete]
GO
/****** Object:  StoredProcedure [dbo].[SP_LISTS_Insert]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_LISTS_Insert]
GO
/****** Object:  StoredProcedure [dbo].[SP_LISTS_Select]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_LISTS_Select]
GO
/****** Object:  StoredProcedure [dbo].[SP_LISTS_Update]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_LISTS_Update]
GO
/****** Object:  Table [dbo].[AUTORESPONDER]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[AUTORESPONDER] DROP CONSTRAINT [FK_AUTORESP_REFERENCE_LISTS]
GO
ALTER TABLE [dbo].[AUTORESPONDER] DROP CONSTRAINT [FK_AUTORESP_REFERENCE_USERS]
GO
DROP TABLE [dbo].[AUTORESPONDER]
GO
/****** Object:  StoredProcedure [dbo].[SP_MESSAGES_Delete]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_MESSAGES_Delete]
GO
/****** Object:  StoredProcedure [dbo].[SP_MESSAGES_Insert]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_MESSAGES_Insert]
GO
/****** Object:  StoredProcedure [dbo].[SP_MESSAGES_Select]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_MESSAGES_Select]
GO
/****** Object:  StoredProcedure [dbo].[SP_MESSAGES_Update]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_MESSAGES_Update]
GO
/****** Object:  StoredProcedure [dbo].[SP_SEGMENT_CONTACT_Delete]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_SEGMENT_CONTACT_Delete]
GO
/****** Object:  StoredProcedure [dbo].[SP_SEGMENT_CONTACT_Insert]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_SEGMENT_CONTACT_Insert]
GO
/****** Object:  StoredProcedure [dbo].[SP_SEGMENT_CONTACT_Select]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_SEGMENT_CONTACT_Select]
GO
/****** Object:  Table [dbo].[LISTS]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[LISTS] DROP CONSTRAINT [FK_LISTS_REFERENCE_MESSAGES]
GO
ALTER TABLE [dbo].[LISTS] DROP CONSTRAINT [FK_LISTS_REFERENCE_USERS]
GO
DROP TABLE [dbo].[LISTS]
GO
/****** Object:  Table [dbo].[MESSAGES]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[MESSAGES] DROP CONSTRAINT [FK_MESSAGES_REFERENCE_USERS]
GO
DROP TABLE [dbo].[MESSAGES]
GO
/****** Object:  StoredProcedure [dbo].[SP_SEGMENT_Delete]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_SEGMENT_Delete]
GO
/****** Object:  StoredProcedure [dbo].[SP_SEGMENT_Insert]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_SEGMENT_Insert]
GO
/****** Object:  StoredProcedure [dbo].[SP_SEGMENT_Select]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_SEGMENT_Select]
GO
/****** Object:  StoredProcedure [dbo].[SP_SEGMENT_Update]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_SEGMENT_Update]
GO
/****** Object:  StoredProcedure [dbo].[SP_CONTACTS_Delete]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_CONTACTS_Delete]
GO
/****** Object:  StoredProcedure [dbo].[SP_CONTACTS_Insert]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_CONTACTS_Insert]
GO
/****** Object:  StoredProcedure [dbo].[SP_CONTACTS_Select]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_CONTACTS_Select]
GO
/****** Object:  StoredProcedure [dbo].[SP_CONTACTS_Update]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_CONTACTS_Update]
GO
/****** Object:  Table [dbo].[SEGMENT_CONTACT]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[SEGMENT_CONTACT] DROP CONSTRAINT [FK_SEGMENT__REFERENCE_CONTACTS]
GO
ALTER TABLE [dbo].[SEGMENT_CONTACT] DROP CONSTRAINT [FK_SEGMENT__REFERENCE_SEGMENT]
GO
DROP TABLE [dbo].[SEGMENT_CONTACT]
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECK_EXISTEMAIL]    Script Date: 05/25/2012 01:35:28 ******/
DROP PROCEDURE [dbo].[SP_CHECK_EXISTEMAIL]
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECK_EXISTUSERNAME]    Script Date: 05/25/2012 01:35:28 ******/
DROP PROCEDURE [dbo].[SP_CHECK_EXISTUSERNAME]
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECK_USERPASS]    Script Date: 05/25/2012 01:35:28 ******/
DROP PROCEDURE [dbo].[SP_CHECK_USERPASS]
GO
/****** Object:  StoredProcedure [dbo].[SP_USERS_Delete]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_USERS_Delete]
GO
/****** Object:  StoredProcedure [dbo].[SP_USERS_Insert]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_USERS_Insert]
GO
/****** Object:  StoredProcedure [dbo].[SP_USERS_Select]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_USERS_Select]
GO
/****** Object:  StoredProcedure [dbo].[SP_USERS_Update]    Script Date: 05/25/2012 01:35:29 ******/
DROP PROCEDURE [dbo].[SP_USERS_Update]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 05/25/2012 01:35:30 ******/
ALTER TABLE [dbo].[USERS] DROP CONSTRAINT [DF_USERS_MODIFIEDDATE]
GO
DROP TABLE [dbo].[USERS]
GO
/****** Object:  Table [dbo].[SEGMENT]    Script Date: 05/25/2012 01:35:29 ******/
DROP TABLE [dbo].[SEGMENT]
GO
/****** Object:  Table [dbo].[CONTACTS]    Script Date: 05/25/2012 01:35:29 ******/
DROP TABLE [dbo].[CONTACTS]
GO
/****** Object:  Table [dbo].[CONTACTS]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONTACTS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FIRSTNAME] [nvarchar](50) NOT NULL,
	[LASTNAME] [nvarchar](50) NOT NULL,
	[PREFIX] [nvarchar](20) NULL,
	[SUFFIX] [nvarchar](20) NULL,
	[EMAIL] [nvarchar](100) NOT NULL,
	[ADDRESS1] [nvarchar](255) NOT NULL,
	[ADDRESS2] [nvarchar](255) NULL,
	[CITY] [nvarchar](100) NOT NULL,
	[PROVINCE] [nvarchar](100) NOT NULL,
	[ZIP] [nvarchar](20) NOT NULL,
	[PHONE] [nvarchar](20) NOT NULL,
	[FAX] [nvarchar](20) NULL,
	[REQUIRECONFIRM] [bit] NOT NULL,
	[MODIFIEDDATE] [datetime] NOT NULL,
 CONSTRAINT [PK_CONTACTS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SEGMENT]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SEGMENT](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[USERID] [int] NULL,
	[LISTID] [int] NULL,
	[NAME] [nvarchar](100) NOT NULL,
	[DESCRIPTION] [nvarchar](1000) NULL,
	[TOTALSUBSCRIBES] [int] NOT NULL,
	[MODIFIEDDATE] [datetime] NOT NULL,
 CONSTRAINT [PK_SEGMENT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 05/25/2012 01:35:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FIRSTNAME] [nvarchar](50) NOT NULL,
	[LASTNAME] [nvarchar](50) NOT NULL,
	[USERNAME] [nvarchar](50) NOT NULL,
	[PASSWORD] [nvarchar](50) NOT NULL,
	[EMAIL] [nvarchar](100) NOT NULL,
	[PHONE] [nvarchar](20) NOT NULL,
	[COMPANYNAME] [nvarchar](100) NULL,
	[MODIFIEDDATE] [datetime] NOT NULL CONSTRAINT [DF_USERS_MODIFIEDDATE]  DEFAULT (getdate()),
 CONSTRAINT [PK_USERS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[USERS] ON
INSERT [dbo].[USERS] ([ID], [FIRSTNAME], [LASTNAME], [USERNAME], [PASSWORD], [EMAIL], [PHONE], [COMPANYNAME], [MODIFIEDDATE]) VALUES (1, N'admin', N'admin', N'admin', N'admin', N'admin@testing', N'admin', N'pn', CAST(0x0000A05B016AECBC AS DateTime))
SET IDENTITY_INSERT [dbo].[USERS] OFF
/****** Object:  StoredProcedure [dbo].[SP_USERS_Update]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_USERS_Update]


@ID    int,
@FIRSTNAME    nvarchar(50),
@LASTNAME    nvarchar(50),
@USERNAME    nvarchar(50),
@EMAIL    nvarchar(50),
@PHONE    nvarchar(50),
@COMPANYNAME    nvarchar(50)

AS

Update USERS

Set
	
	FIRSTNAME = @FIRSTNAME,
	LASTNAME = @LASTNAME,
	USERNAME = @USERNAME,
	EMAIL = @EMAIL,
	PHONE = @PHONE,
	COMPANYNAME = @COMPANYNAME
Where

ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[SP_USERS_Select]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_USERS_Select]


@ID int,
@FIRSTNAME nvarchar(50),
@LASTNAME nvarchar(50),
@USERNAME nvarchar(50),
@PASSWORD nvarchar(50),
@EMAIL nvarchar(50),
@PHONE nvarchar(50),
@COMPANYNAME nvarchar(50)

AS
BEGIN 

Select 

ID,
FIRSTNAME,
LASTNAME,
USERNAME,
EMAIL,
PHONE,
COMPANYNAME

from USERS

where 
( @ID is null or @ID = ID ) and
( @FIRSTNAME is null or @FIRSTNAME = FIRSTNAME ) and
( @LASTNAME is null or @LASTNAME = LASTNAME ) and
( @USERNAME is null or @USERNAME = USERNAME ) and
( @EMAIL is null or @EMAIL = EMAIL ) and
( @PHONE is null or @PHONE = PHONE ) and
( @COMPANYNAME is null or @COMPANYNAME = COMPANYNAME )

END
GO
/****** Object:  StoredProcedure [dbo].[SP_USERS_Insert]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_USERS_Insert]


@FIRSTNAME nvarchar(50),
@LASTNAME nvarchar(50),
@USERNAME nvarchar(50),
@PASSWORD nvarchar(50),
@EMAIL nvarchar(50),
@PHONE nvarchar(50),
@COMPANYNAME nvarchar(100)

AS

BEGIN

Insert into USERS
(
	FIRSTNAME,
	LASTNAME,
	USERNAME,
	[PASSWORD],
	EMAIL,
	PHONE,
	COMPANYNAME
)
values
(
	@FIRSTNAME,
	@LASTNAME,
	@USERNAME,
	@PASSWORD,
	@EMAIL,
	@PHONE,
	@COMPANYNAME
)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_USERS_Delete]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_USERS_Delete]

@ID int

AS

DELETE USERS where ID=@ID
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECK_USERPASS]    Script Date: 05/25/2012 01:35:28 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_CHECK_USERPASS]
@USERNAME  nvarchar(50)
AS
BEGIN
select PASSWORD from USERS where USERNAME = @USERNAME
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECK_EXISTUSERNAME]    Script Date: 05/25/2012 01:35:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_CHECK_EXISTUSERNAME] 
	@USERNAME nvarchar(50)
AS
BEGIN
	SELECT * FROM USERS WHERE USERNAME = @USERNAME;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECK_EXISTEMAIL]    Script Date: 05/25/2012 01:35:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_CHECK_EXISTEMAIL] 
	@EMAIL nvarchar(50)
AS
BEGIN
	SELECT * FROM USERS WHERE EMAIL = @EMAIL;
END
GO
/****** Object:  Table [dbo].[SEGMENT_CONTACT]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SEGMENT_CONTACT](
	[SEGMENTID] [int] NULL,
	[CONTACTID] [int] NULL,
	[SUBSCRIBES] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SP_CONTACTS_Update]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_CONTACTS_Update]


@ID    int,
@FIRSTNAME    nvarchar(50),
@LASTNAME    nvarchar(50),
@PREFIX    nvarchar(50),
@SUFFIX    nvarchar(50),
@EMAIL    nvarchar(50),
@ADDRESS1    nvarchar(50),
@ADDRESS2    nvarchar(50),
@CITY    nvarchar(50),
@PROVINCE    nvarchar(50),
@ZIP    nvarchar(50),
@PHONE    nvarchar(50),
@FAX    nvarchar(50),
@REQUIRECONFIRM    bit

AS

Update CONTACTS

Set
	
	FIRSTNAME = @FIRSTNAME,
	LASTNAME = @LASTNAME,
	PREFIX = @PREFIX,
	SUFFIX = @SUFFIX,
	EMAIL = @EMAIL,
	ADDRESS1 = @ADDRESS1,
	ADDRESS2 = @ADDRESS2,
	CITY = @CITY,
	PROVINCE = @PROVINCE,
	ZIP = @ZIP,
	PHONE = @PHONE,
	FAX = @FAX,
	REQUIRECONFIRM = @REQUIRECONFIRM
Where

ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[SP_CONTACTS_Select]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_CONTACTS_Select]


@ID int,
@FIRSTNAME nvarchar(50),
@LASTNAME nvarchar(50),
@PREFIX nvarchar(50),
@SUFFIX nvarchar(50),
@EMAIL nvarchar(50),
@ADDRESS1 nvarchar(50),
@ADDRESS2 nvarchar(50),
@CITY nvarchar(50),
@PROVINCE nvarchar(50),
@ZIP nvarchar(50),
@PHONE nvarchar(50),
@FAX nvarchar(50),
@REQUIRECONFIRM bit,
@MODIFIEDDATE datetime

AS

Select 

ID,
FIRSTNAME,
LASTNAME,
PREFIX,
SUFFIX,
EMAIL,
ADDRESS1,
ADDRESS2,
CITY,
PROVINCE,
ZIP,
PHONE,
FAX,
REQUIRECONFIRM,
MODIFIEDDATE

from CONTACTS

where 
( @ID is null or @ID = ID ) and
( @FIRSTNAME is null or @FIRSTNAME = FIRSTNAME ) and
( @LASTNAME is null or @LASTNAME = LASTNAME ) and
( @PREFIX is null or @PREFIX = PREFIX ) and
( @SUFFIX is null or @SUFFIX = SUFFIX ) and
( @EMAIL is null or @EMAIL = EMAIL ) and
( @ADDRESS1 is null or @ADDRESS1 = ADDRESS1 ) and
( @ADDRESS2 is null or @ADDRESS2 = ADDRESS2 ) and
( @CITY is null or @CITY = CITY ) and
( @PROVINCE is null or @PROVINCE = PROVINCE ) and
( @ZIP is null or @ZIP = ZIP ) and
( @PHONE is null or @PHONE = PHONE ) and
( @FAX is null or @FAX = FAX ) and
( @REQUIRECONFIRM is null or @REQUIRECONFIRM = REQUIRECONFIRM )
GO
/****** Object:  StoredProcedure [dbo].[SP_CONTACTS_Insert]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_CONTACTS_Insert]


@FIRSTNAME nvarchar(50),
@LASTNAME nvarchar(50),
@PREFIX nvarchar(50),
@SUFFIX nvarchar(50),
@EMAIL nvarchar(50),
@ADDRESS1 nvarchar(50),
@ADDRESS2 nvarchar(50),
@CITY nvarchar(50),
@PROVINCE nvarchar(50),
@ZIP nvarchar(50),
@PHONE nvarchar(50),
@FAX nvarchar(50),
@REQUIRECONFIRM bit

AS

Insert into CONTACTS
(
FIRSTNAME,
LASTNAME,
PREFIX,
SUFFIX,
EMAIL,
ADDRESS1,
ADDRESS2,
CITY,
PROVINCE,
ZIP,
PHONE,
FAX,
REQUIRECONFIRM
)
values
(
@FIRSTNAME,
@LASTNAME,
@PREFIX,
@SUFFIX,
@EMAIL,
@ADDRESS1,
@ADDRESS2,
@CITY,
@PROVINCE,
@ZIP,
@PHONE,
@FAX,
@REQUIRECONFIRM
)
GO
/****** Object:  StoredProcedure [dbo].[SP_CONTACTS_Delete]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_CONTACTS_Delete]

@ID int

AS

DELETE 
CONTACTS


where ID=@ID
GO
/****** Object:  StoredProcedure [dbo].[SP_SEGMENT_Update]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_SEGMENT_Update]


@ID    int,
@USERID    int,
@LISTID    int,
@NAME    nvarchar(50),
@DESCRIPTION    nvarchar(50),
@TOTALSUBSCRIBES    int

AS

Update SEGMENT

Set
	
	USERID = @USERID,
	LISTID = @LISTID,
	NAME = @NAME,
	DESCRIPTION = @DESCRIPTION,
	TOTALSUBSCRIBES = @TOTALSUBSCRIBES
Where

ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[SP_SEGMENT_Select]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_SEGMENT_Select]


@ID int,
@USERID int,
@LISTID int,
@NAME nvarchar(50),
@DESCRIPTION nvarchar(50),
@TOTALSUBSCRIBES int,
@MODIFIEDDATE datetime

AS

Select 

ID,
USERID,
LISTID,
NAME,
DESCRIPTION,
TOTALSUBSCRIBES,
MODIFIEDDATE

from SEGMENT

where 
( @ID is null or @ID = ID ) and
( @USERID is null or @USERID = USERID ) and
( @LISTID is null or @LISTID = LISTID ) and
( @NAME is null or @NAME = NAME ) and
( @DESCRIPTION is null or @DESCRIPTION = DESCRIPTION ) and
( @TOTALSUBSCRIBES is null or @TOTALSUBSCRIBES = TOTALSUBSCRIBES )
GO
/****** Object:  StoredProcedure [dbo].[SP_SEGMENT_Insert]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_SEGMENT_Insert]


@USERID int,
@LISTID int,
@NAME nvarchar(50),
@DESCRIPTION nvarchar(50),
@TOTALSUBSCRIBES int

AS

Insert into SEGMENT
(
USERID,
LISTID,
NAME,
DESCRIPTION,
TOTALSUBSCRIBES
)
values
(
@USERID,
@LISTID,
@NAME,
@DESCRIPTION,
@TOTALSUBSCRIBES
)
GO
/****** Object:  StoredProcedure [dbo].[SP_SEGMENT_Delete]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_SEGMENT_Delete]

@ID int

AS

DELETE 
SEGMENT


where ID=@ID
GO
/****** Object:  Table [dbo].[MESSAGES]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MESSAGES](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[USERID] [int] NULL,
	[MESSAGENAME] [nvarchar](100) NOT NULL,
	[FROM] [nvarchar](255) NOT NULL,
	[SUBJECT] [nvarchar](255) NOT NULL,
	[BODY] [text] NOT NULL,
	[WEBPAGE] [nvarchar](255) NULL,
	[TYPE] [bit] NULL,
	[STATUS] [int] NOT NULL,
	[MODIFIEDDATE] [datetime] NOT NULL,
 CONSTRAINT [PK_MESSAGES] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LISTS]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LISTS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[USERID] [int] NULL,
	[LISTNAME] [nvarchar](100) NOT NULL,
	[DESCRIPTION] [nvarchar](1000) NULL,
	[NOTIFICATION] [bit] NULL,
	[PUBLICLABEL] [nvarchar](100) NULL,
	[WELLCOMEMSGID] [int] NULL,
	[TOTALSUBSCRIBES] [int] NOT NULL,
	[MODIFIEDDATE] [datetime] NOT NULL,
 CONSTRAINT [PK_LISTS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SP_SEGMENT_CONTACT_Select]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_SEGMENT_CONTACT_Select]


@SEGMENTID int,
@CONTACTID int,
@SUBSCRIBES bit

AS

Select 

SEGMENTID,
CONTACTID,
SUBSCRIBES

from SEGMENT_CONTACT

where 
( @SEGMENTID is null or @SEGMENTID = SEGMENTID ) and
( @CONTACTID is null or @CONTACTID = CONTACTID ) and
( @SUBSCRIBES is null or @SUBSCRIBES = SUBSCRIBES )
GO
/****** Object:  StoredProcedure [dbo].[SP_SEGMENT_CONTACT_Insert]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_SEGMENT_CONTACT_Insert]

@SEGMENTID int,
@CONTACTID int,
@SUBSCRIBES bit



AS

Insert into SEGMENT_CONTACT
(
SEGMENTID,
CONTACTID,
SUBSCRIBES
)
values
(
@SEGMENTID,
@CONTACTID,
@SUBSCRIBES
)
GO
/****** Object:  StoredProcedure [dbo].[SP_SEGMENT_CONTACT_Delete]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_SEGMENT_CONTACT_Delete]

@SEGMENTID int

AS

DELETE 
SEGMENT_CONTACT


where SEGMENTID=@SEGMENTID
GO
/****** Object:  StoredProcedure [dbo].[SP_MESSAGES_Update]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_MESSAGES_Update]


@ID    int,
@USERID    int,
@MESSAGENAME    nvarchar(50),
@FROM    nvarchar(50),
@SUBJECT    nvarchar(50),
@BODY    text,
@WEBPAGE    nvarchar(50),
@TYPE    bit,
@STATUS    int

AS

Update MESSAGES

Set
	
	USERID = @USERID,
	MESSAGENAME = @MESSAGENAME,
	[FROM] = @FROM,
	[SUBJECT] = @SUBJECT,
	BODY = @BODY,
	WEBPAGE = @WEBPAGE,
	[TYPE] = @TYPE,
	[STATUS] = @STATUS
Where

ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[SP_MESSAGES_Select]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_MESSAGES_Select]


@ID int,
@USERID int,
@MESSAGENAME nvarchar(50),
@FROM nvarchar(50),
@SUBJECT nvarchar(50),
@BODY text,
@WEBPAGE nvarchar(50),
@TYPE bit,
@STATUS int,
@MODIFIEDDATE datetime

AS

Select 

ID,
USERID,
MESSAGENAME,
[FROM],
[SUBJECT],
BODY,
WEBPAGE,
[TYPE],
[STATUS],
MODIFIEDDATE

from MESSAGES

where 
( @ID is null or @ID = ID ) and
( @USERID is null or @USERID = USERID ) and
( @MESSAGENAME is null or @MESSAGENAME = MESSAGENAME ) and
( @FROM is null or @FROM = [FROM] ) and
( @SUBJECT is null or @SUBJECT = [SUBJECT] ) and
( @WEBPAGE is null or @WEBPAGE = WEBPAGE ) and
( @TYPE is null or @TYPE = [TYPE] ) and
( @STATUS is null or @STATUS = [STATUS] )
GO
/****** Object:  StoredProcedure [dbo].[SP_MESSAGES_Insert]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_MESSAGES_Insert]


@USERID int,
@MESSAGENAME nvarchar(50),
@FROM nvarchar(50),
@SUBJECT nvarchar(50),
@BODY text,
@WEBPAGE nvarchar(50),
@TYPE bit,
@STATUS int

AS

Insert into MESSAGES
(
USERID,
MESSAGENAME,
[FROM],
[SUBJECT],
BODY,
WEBPAGE,
[TYPE],
[STATUS]
)
values
(
@USERID,
@MESSAGENAME,
@FROM,
@SUBJECT,
@BODY,
@WEBPAGE,
@TYPE,
@STATUS
)
GO
/****** Object:  StoredProcedure [dbo].[SP_MESSAGES_Delete]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_MESSAGES_Delete]

@ID int

AS

DELETE 
MESSAGES


where ID=@ID
GO
/****** Object:  Table [dbo].[AUTORESPONDER]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AUTORESPONDER](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[USERID] [int] NULL,
	[NAME] [nvarchar](255) NOT NULL,
	[DESCRIPTION] [nvarchar](255) NULL,
	[LISTID] [int] NULL,
	[FROMNAME] [nvarchar](255) NOT NULL,
	[FROMEMAIL] [nvarchar](255) NOT NULL,
	[STATUS] [int] NOT NULL,
	[MODIFIEDDATE] [datetime] NOT NULL,
 CONSTRAINT [PK_AUTORESPONDER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SP_LISTS_Update]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_LISTS_Update]


@ID    int,
@USERID    int,
@LISTNAME    nvarchar(50),
@DESCRIPTION    nvarchar(50),
@NOTIFICATION    bit,
@PUBLICLABEL    nvarchar(50),
@WELLCOMEMSGID    int,
@TOTALSUBSCRIBES    int

AS

Update LISTS

Set
	
	USERID = @USERID,
	LISTNAME = @LISTNAME,
	DESCRIPTION = @DESCRIPTION,
	NOTIFICATION = @NOTIFICATION,
	PUBLICLABEL = @PUBLICLABEL,
	WELLCOMEMSGID = @WELLCOMEMSGID,
	TOTALSUBSCRIBES = @TOTALSUBSCRIBES
Where

ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[SP_LISTS_Select]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_LISTS_Select]


@ID int,
@USERID int,
@LISTNAME nvarchar(50),
@DESCRIPTION nvarchar(50),
@NOTIFICATION bit,
@PUBLICLABEL nvarchar(50),
@WELLCOMEMSGID int,
@TOTALSUBSCRIBES int,
@MODIFIEDDATE datetime

AS

Select 

ID,
USERID,
LISTNAME,
DESCRIPTION,
NOTIFICATION,
PUBLICLABEL,
WELLCOMEMSGID,
TOTALSUBSCRIBES,
MODIFIEDDATE

from LISTS

where 
( @ID is null or @ID = ID ) and
( @USERID is null or @USERID = USERID ) and
( @LISTNAME is null or @LISTNAME = LISTNAME ) and
( @DESCRIPTION is null or @DESCRIPTION = DESCRIPTION ) and
( @NOTIFICATION is null or @NOTIFICATION = NOTIFICATION ) and
( @PUBLICLABEL is null or @PUBLICLABEL = PUBLICLABEL ) and
( @WELLCOMEMSGID is null or @WELLCOMEMSGID = WELLCOMEMSGID ) and
( @TOTALSUBSCRIBES is null or @TOTALSUBSCRIBES = TOTALSUBSCRIBES )
GO
/****** Object:  StoredProcedure [dbo].[SP_LISTS_Insert]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_LISTS_Insert]


@USERID int,
@LISTNAME nvarchar(50),
@DESCRIPTION nvarchar(50),
@NOTIFICATION bit,
@PUBLICLABEL nvarchar(50),
@WELLCOMEMSGID int,
@TOTALSUBSCRIBES int

AS

Insert into LISTS
(
USERID,
LISTNAME,
DESCRIPTION,
NOTIFICATION,
PUBLICLABEL,
WELLCOMEMSGID,
TOTALSUBSCRIBES
)
values
(
@USERID,
@LISTNAME,
@DESCRIPTION,
@NOTIFICATION,
@PUBLICLABEL,
@WELLCOMEMSGID,
@TOTALSUBSCRIBES
)
GO
/****** Object:  StoredProcedure [dbo].[SP_LISTS_Delete]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_LISTS_Delete]

@ID int

AS

DELETE 
LISTS


where ID=@ID
GO
/****** Object:  Table [dbo].[CONTACT_LIST]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONTACT_LIST](
	[CONTACTID] [int] NULL,
	[LISTID] [int] NULL,
	[SUBSCRIBES] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AUTORESPONDER_MESSAGES]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AUTORESPONDER_MESSAGES](
	[ID] [int] NOT NULL,
	[AUTORESPONDERID] [int] NULL,
	[MESSAGEID] [int] NULL,
 CONSTRAINT [PK_AUTORESPONDER_MESSAGES] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SP_CONTACT_LIST_Select]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_CONTACT_LIST_Select]


@CONTACTID int,
@LISTID int,
@SUBSCRIBES bit

AS

Select 

CONTACTID,
LISTID,
SUBSCRIBES

from CONTACT_LIST

where 
( @CONTACTID is null or @CONTACTID = CONTACTID ) and
( @LISTID is null or @LISTID = LISTID ) and
( @SUBSCRIBES is null or @SUBSCRIBES = SUBSCRIBES )
GO
/****** Object:  StoredProcedure [dbo].[SP_CONTACT_LIST_Insert]    Script Date: 05/25/2012 01:35:28 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_CONTACT_LIST_Insert]


@CONTACTID int,
@LISTID int,
@SUBSCRIBES bit

AS

Insert into CONTACT_LIST
(
CONTACTID,
LISTID,
SUBSCRIBES
)
values
(
@CONTACTID,
@LISTID,
@SUBSCRIBES
)
GO
/****** Object:  StoredProcedure [dbo].[SP_CONTACT_LIST_Delete]    Script Date: 05/25/2012 01:35:28 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_CONTACT_LIST_Delete]

@CONTACTID int,
@LISTID int
AS

DELETE 
CONTACT_LIST


where CONTACTID=@CONTACTID AND LISTID=@LISTID
GO
/****** Object:  StoredProcedure [dbo].[SP_AUTORESPONDER_Insert]    Script Date: 05/25/2012 01:35:28 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_AUTORESPONDER_Insert]


@USERID int,
@NAME nvarchar(50),
@DESCRIPTION nvarchar(50),
@LISTID int,
@FROMNAME nvarchar(50),
@FROMEMAIL nvarchar(50),
@STATUS int

AS

Insert into AUTORESPONDER
(
USERID,
NAME,
DESCRIPTION,
LISTID,
FROMNAME,
FROMEMAIL,
STATUS
)
values
(
@USERID,
@NAME,
@DESCRIPTION,
@LISTID,
@FROMNAME,
@FROMEMAIL,
@STATUS
)
GO
/****** Object:  StoredProcedure [dbo].[SP_AUTORESPONDER_Delete]    Script Date: 05/25/2012 01:35:28 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_AUTORESPONDER_Delete]

@ID int

AS

DELETE 
AUTORESPONDER


where ID=@ID
GO
/****** Object:  Table [dbo].[SENTEMAILS]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SENTEMAILS](
	[ID] [int] NOT NULL,
	[AUTORESPONSEID] [int] NULL,
	[MESSAGEID] [int] NULL,
	[CONTACTID] [int] NULL,
	[OPEN] [bit] NULL,
	[CLICK] [bit] NULL,
	[BOUNCES] [bit] NULL,
	[NOINFO] [bit] NULL,
	[UNSUBSCRIBES] [bit] NULL,
	[COMPLAINS_] [bit] NULL,
	[FORWARDS_] [bit] NULL,
	[STATUS] [bit] NULL,
	[DESC] [nvarchar](1000) NULL,
	[DATESENT] [datetime] NOT NULL,
 CONSTRAINT [PK_SENTEMAILS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SP_AUTORESPONDER_Update]    Script Date: 05/25/2012 01:35:28 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_AUTORESPONDER_Update]


@ID    int,
@USERID    int,
@NAME    nvarchar(50),
@DESCRIPTION    nvarchar(50),
@LISTID    int,
@FROMNAME    nvarchar(50),
@FROMEMAIL    nvarchar(50),
@STATUS    int

AS

Update AUTORESPONDER

Set
	
	USERID = @USERID,
	NAME = @NAME,
	DESCRIPTION = @DESCRIPTION,
	LISTID = @LISTID,
	FROMNAME = @FROMNAME,
	FROMEMAIL = @FROMEMAIL,
	STATUS = @STATUS
Where

ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[SP_AUTORESPONDER_Select]    Script Date: 05/25/2012 01:35:28 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_AUTORESPONDER_Select]


@ID int,
@USERID int,
@NAME nvarchar(50),
@DESCRIPTION nvarchar(50),
@LISTID int,
@FROMNAME nvarchar(50),
@FROMEMAIL nvarchar(50),
@STATUS int

AS

Select 

ID,
USERID,
NAME,
DESCRIPTION,
LISTID,
FROMNAME,
FROMEMAIL,
STATUS,
MODIFIEDDATE

from AUTORESPONDER

where 
( @ID is null or @ID = ID ) and
( @USERID is null or @USERID = USERID ) and
( @NAME is null or @NAME = NAME ) and
( @DESCRIPTION is null or @DESCRIPTION = DESCRIPTION ) and
( @LISTID is null or @LISTID = LISTID ) and
( @FROMNAME is null or @FROMNAME = FROMNAME ) and
( @FROMEMAIL is null or @FROMEMAIL = FROMEMAIL ) and
( @STATUS is null or @STATUS = STATUS )
GO
/****** Object:  StoredProcedure [dbo].[SP_SENTEMAILS_Update]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_SENTEMAILS_Update]


@ID    int,
@AUTORESPONSEID    int,
@MESSAGEID    int,
@CONTACTID    int,
@OPEN    bit,
@CLICK    bit,
@BOUNCES    bit,
@NOINFO    bit,
@UNSUBSCRIBES    bit,
@COMPLAINS_    bit,
@FORWARDS_    bit,
@STATUS    bit,
@DESC    nvarchar(50)

AS

Update SENTEMAILS

Set
	
	AUTORESPONSEID = @AUTORESPONSEID,
	MESSAGEID = @MESSAGEID,
	CONTACTID = @CONTACTID,
	[OPEN] = @OPEN,
	CLICK = @CLICK,
	BOUNCES = @BOUNCES,
	NOINFO = @NOINFO,
	UNSUBSCRIBES = @UNSUBSCRIBES,
	COMPLAINS_ = @COMPLAINS_,
	FORWARDS_ = @FORWARDS_,
	STATUS = @STATUS,
	[DESC] = @DESC
Where

ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[SP_SENTEMAILS_Select]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_SENTEMAILS_Select]


@ID int,
@AUTORESPONSEID int,
@MESSAGEID int,
@CONTACTID int,
@OPEN bit,
@CLICK bit,
@BOUNCES bit,
@NOINFO bit,
@UNSUBSCRIBES bit,
@COMPLAINS_ bit,
@FORWARDS_ bit,
@STATUS bit,
@DESC nvarchar(50),
@DATESENT datetime

AS

Select 

ID,
AUTORESPONSEID,
MESSAGEID,
CONTACTID,
[OPEN],
CLICK,
BOUNCES,
NOINFO,
UNSUBSCRIBES,
COMPLAINS_,
FORWARDS_,
STATUS,
[DESC],
DATESENT

from SENTEMAILS

where 
( @ID is null or @ID = ID ) and
( @AUTORESPONSEID is null or @AUTORESPONSEID = AUTORESPONSEID ) and
( @MESSAGEID is null or @MESSAGEID = MESSAGEID ) and
( @CONTACTID is null or @CONTACTID = CONTACTID ) and
( @OPEN is null or @OPEN = [OPEN] ) and
( @CLICK is null or @CLICK = CLICK ) and
( @BOUNCES is null or @BOUNCES = BOUNCES ) and
( @NOINFO is null or @NOINFO = NOINFO ) and
( @UNSUBSCRIBES is null or @UNSUBSCRIBES = UNSUBSCRIBES ) and
( @COMPLAINS_ is null or @COMPLAINS_ = COMPLAINS_ ) and
( @FORWARDS_ is null or @FORWARDS_ = FORWARDS_ ) and
( @STATUS is null or @STATUS = [STATUS] ) and
( @DESC is null or @DESC = [DESC] )
GO
/****** Object:  StoredProcedure [dbo].[SP_SENTEMAILS_Insert]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_SENTEMAILS_Insert]


@AUTORESPONSEID int,
@MESSAGEID int,
@CONTACTID int,
@OPEN bit,
@CLICK bit,
@BOUNCES bit,
@NOINFO bit,
@UNSUBSCRIBES bit,
@COMPLAINS_ bit,
@FORWARDS_ bit,
@STATUS bit,
@DESC nvarchar(50)

AS

Insert into SENTEMAILS
(
AUTORESPONSEID,
MESSAGEID,
CONTACTID,
[OPEN],
CLICK,
BOUNCES,
NOINFO,
UNSUBSCRIBES,
COMPLAINS_,
FORWARDS_,
STATUS,
[DESC]
)
values
(
@AUTORESPONSEID,
@MESSAGEID,
@CONTACTID,
@OPEN,
@CLICK,
@BOUNCES,
@NOINFO,
@UNSUBSCRIBES,
@COMPLAINS_,
@FORWARDS_,
@STATUS,
@DESC
)
GO
/****** Object:  StoredProcedure [dbo].[SP_SENTEMAILS_Delete]    Script Date: 05/25/2012 01:35:29 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_SENTEMAILS_Delete]

@ID int

AS

DELETE 
SENTEMAILS


where ID=@ID
GO
/****** Object:  StoredProcedure [dbo].[SP_AUTORESPONDER_MESSAGES_Update]    Script Date: 05/25/2012 01:35:28 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_AUTORESPONDER_MESSAGES_Update]


@ID    int,
@AUTORESPONDERID    int,
@MESSAGEID int
AS

Update AUTORESPONDER_MESSAGES

Set
	
	AUTORESPONDERID = @AUTORESPONDERID, MESSAGEID = @MESSAGEID
Where

ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[SP_AUTORESPONDER_MESSAGES_Select]    Script Date: 05/25/2012 01:35:28 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_AUTORESPONDER_MESSAGES_Select]


@ID int,
@AUTORESPONDERID int,
@MESSAGEID int

AS

Select 

ID,
AUTORESPONDERID,
MESSAGEID

from AUTORESPONDER_MESSAGES

where 
( @ID is null or @ID = ID ) and
( @AUTORESPONDERID is null or @AUTORESPONDERID = AUTORESPONDERID ) and
( @MESSAGEID is null or @MESSAGEID = MESSAGEID )
GO
/****** Object:  StoredProcedure [dbo].[SP_AUTORESPONDER_MESSAGES_Insert]    Script Date: 05/25/2012 01:35:28 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_AUTORESPONDER_MESSAGES_Insert]


@AUTORESPONDERID int,
@MESSAGEID int
AS

Insert into AUTORESPONDER_MESSAGES
(
AUTORESPONDERID,
MESSAGEID
)
values
(
@AUTORESPONDERID,
@MESSAGEID
)
GO
/****** Object:  StoredProcedure [dbo].[SP_AUTORESPONDER_MESSAGES_Delete]    Script Date: 05/25/2012 01:35:28 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_AUTORESPONDER_MESSAGES_Delete]

@ID int

AS

DELETE 
AUTORESPONDER_MESSAGES


where ID=@ID
GO
/****** Object:  ForeignKey [FK_AUTORESP_REFERENCE_LISTS]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[AUTORESPONDER]  WITH CHECK ADD  CONSTRAINT [FK_AUTORESP_REFERENCE_LISTS] FOREIGN KEY([LISTID])
REFERENCES [dbo].[LISTS] ([ID])
GO
ALTER TABLE [dbo].[AUTORESPONDER] CHECK CONSTRAINT [FK_AUTORESP_REFERENCE_LISTS]
GO
/****** Object:  ForeignKey [FK_AUTORESP_REFERENCE_USERS]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[AUTORESPONDER]  WITH CHECK ADD  CONSTRAINT [FK_AUTORESP_REFERENCE_USERS] FOREIGN KEY([USERID])
REFERENCES [dbo].[USERS] ([ID])
GO
ALTER TABLE [dbo].[AUTORESPONDER] CHECK CONSTRAINT [FK_AUTORESP_REFERENCE_USERS]
GO
/****** Object:  ForeignKey [FK_AUTORESP_REFERENCE_AUTORESP]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[AUTORESPONDER_MESSAGES]  WITH CHECK ADD  CONSTRAINT [FK_AUTORESP_REFERENCE_AUTORESP] FOREIGN KEY([AUTORESPONDERID])
REFERENCES [dbo].[AUTORESPONDER] ([ID])
GO
ALTER TABLE [dbo].[AUTORESPONDER_MESSAGES] CHECK CONSTRAINT [FK_AUTORESP_REFERENCE_AUTORESP]
GO
/****** Object:  ForeignKey [FK_AUTORESP_REFERENCE_MESSAGES]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[AUTORESPONDER_MESSAGES]  WITH CHECK ADD  CONSTRAINT [FK_AUTORESP_REFERENCE_MESSAGES] FOREIGN KEY([MESSAGEID])
REFERENCES [dbo].[MESSAGES] ([ID])
GO
ALTER TABLE [dbo].[AUTORESPONDER_MESSAGES] CHECK CONSTRAINT [FK_AUTORESP_REFERENCE_MESSAGES]
GO
/****** Object:  ForeignKey [FK_CONTACT__REFERENCE_CONTACTS]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[CONTACT_LIST]  WITH CHECK ADD  CONSTRAINT [FK_CONTACT__REFERENCE_CONTACTS] FOREIGN KEY([CONTACTID])
REFERENCES [dbo].[CONTACTS] ([ID])
GO
ALTER TABLE [dbo].[CONTACT_LIST] CHECK CONSTRAINT [FK_CONTACT__REFERENCE_CONTACTS]
GO
/****** Object:  ForeignKey [FK_CONTACT__REFERENCE_LISTS]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[CONTACT_LIST]  WITH CHECK ADD  CONSTRAINT [FK_CONTACT__REFERENCE_LISTS] FOREIGN KEY([LISTID])
REFERENCES [dbo].[LISTS] ([ID])
GO
ALTER TABLE [dbo].[CONTACT_LIST] CHECK CONSTRAINT [FK_CONTACT__REFERENCE_LISTS]
GO
/****** Object:  ForeignKey [FK_LISTS_REFERENCE_MESSAGES]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[LISTS]  WITH CHECK ADD  CONSTRAINT [FK_LISTS_REFERENCE_MESSAGES] FOREIGN KEY([WELLCOMEMSGID])
REFERENCES [dbo].[MESSAGES] ([ID])
GO
ALTER TABLE [dbo].[LISTS] CHECK CONSTRAINT [FK_LISTS_REFERENCE_MESSAGES]
GO
/****** Object:  ForeignKey [FK_LISTS_REFERENCE_USERS]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[LISTS]  WITH CHECK ADD  CONSTRAINT [FK_LISTS_REFERENCE_USERS] FOREIGN KEY([USERID])
REFERENCES [dbo].[USERS] ([ID])
GO
ALTER TABLE [dbo].[LISTS] CHECK CONSTRAINT [FK_LISTS_REFERENCE_USERS]
GO
/****** Object:  ForeignKey [FK_MESSAGES_REFERENCE_USERS]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[MESSAGES]  WITH CHECK ADD  CONSTRAINT [FK_MESSAGES_REFERENCE_USERS] FOREIGN KEY([USERID])
REFERENCES [dbo].[USERS] ([ID])
GO
ALTER TABLE [dbo].[MESSAGES] CHECK CONSTRAINT [FK_MESSAGES_REFERENCE_USERS]
GO
/****** Object:  ForeignKey [FK_SEGMENT__REFERENCE_CONTACTS]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[SEGMENT_CONTACT]  WITH CHECK ADD  CONSTRAINT [FK_SEGMENT__REFERENCE_CONTACTS] FOREIGN KEY([CONTACTID])
REFERENCES [dbo].[CONTACTS] ([ID])
GO
ALTER TABLE [dbo].[SEGMENT_CONTACT] CHECK CONSTRAINT [FK_SEGMENT__REFERENCE_CONTACTS]
GO
/****** Object:  ForeignKey [FK_SEGMENT__REFERENCE_SEGMENT]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[SEGMENT_CONTACT]  WITH CHECK ADD  CONSTRAINT [FK_SEGMENT__REFERENCE_SEGMENT] FOREIGN KEY([SEGMENTID])
REFERENCES [dbo].[SEGMENT] ([ID])
GO
ALTER TABLE [dbo].[SEGMENT_CONTACT] CHECK CONSTRAINT [FK_SEGMENT__REFERENCE_SEGMENT]
GO
/****** Object:  ForeignKey [FK_SENTEMAI_REFERENCE_AUTORESP]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[SENTEMAILS]  WITH CHECK ADD  CONSTRAINT [FK_SENTEMAI_REFERENCE_AUTORESP] FOREIGN KEY([AUTORESPONSEID])
REFERENCES [dbo].[AUTORESPONDER] ([ID])
GO
ALTER TABLE [dbo].[SENTEMAILS] CHECK CONSTRAINT [FK_SENTEMAI_REFERENCE_AUTORESP]
GO
/****** Object:  ForeignKey [FK_SENTEMAI_REFERENCE_CONTACTS]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[SENTEMAILS]  WITH CHECK ADD  CONSTRAINT [FK_SENTEMAI_REFERENCE_CONTACTS] FOREIGN KEY([CONTACTID])
REFERENCES [dbo].[CONTACTS] ([ID])
GO
ALTER TABLE [dbo].[SENTEMAILS] CHECK CONSTRAINT [FK_SENTEMAI_REFERENCE_CONTACTS]
GO
/****** Object:  ForeignKey [FK_SENTEMAI_REFERENCE_MESSAGES]    Script Date: 05/25/2012 01:35:29 ******/
ALTER TABLE [dbo].[SENTEMAILS]  WITH CHECK ADD  CONSTRAINT [FK_SENTEMAI_REFERENCE_MESSAGES] FOREIGN KEY([MESSAGEID])
REFERENCES [dbo].[MESSAGES] ([ID])
GO
ALTER TABLE [dbo].[SENTEMAILS] CHECK CONSTRAINT [FK_SENTEMAI_REFERENCE_MESSAGES]
GO
