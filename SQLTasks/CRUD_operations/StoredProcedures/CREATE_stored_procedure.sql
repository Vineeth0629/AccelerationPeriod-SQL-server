USE [CompanyDetails]
GO

/****** Object:  StoredProcedure [dbo].[create_employee]    Script Date: 10/27/2022 1:34:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[create_employee](@name varchar(50),@age int,@depid int,@salid int)
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into employee (empname,empage,departmentid,salaryid) values( @name,@age,@depid,@salid)
	
END
GO

