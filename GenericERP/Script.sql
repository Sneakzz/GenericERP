USE [ERP]
GO
/****** Object:  Table [dbo].[klanten]    Script Date: 6/03/2020 23:02:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[klanten]') AND type in (N'U'))
DROP TABLE [dbo].[klanten]
GO
/****** Object:  Table [dbo].[klanten]    Script Date: 6/03/2020 23:02:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[klanten](
	[voornaam] [nvarchar](50) NULL,
	[familienaam] [nvarchar](50) NULL,
	[gsm] [nchar](10) NULL,
	[email] [varchar](320) NULL,
	[adres] [varchar](255) NULL,
	[stad] [varchar](255) NULL,
	[postcode] [int] NULL,
	[country] [varchar](255) NULL
) ON [PRIMARY]
GO
