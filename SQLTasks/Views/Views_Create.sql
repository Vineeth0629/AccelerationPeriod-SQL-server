USE [CompanyDetails]
GO

/****** Object:  Table [dbo].[employee]    Script Date: 10/28/2022 9:51:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[employee](
	[empid] [int] IDENTITY(1,1) NOT NULL,
	[empname] [varchar](50) NULL,
	[empage] [int] NULL,
	[departmentid] [int] NULL,
	[salaryid] [int] NULL
) ON [PRIMARY]
GO

