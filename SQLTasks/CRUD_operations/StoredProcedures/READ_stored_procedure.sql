USE [CompanyDetails]
GO

/****** Object:  StoredProcedure [dbo].[get_employee_details]    Script Date: 10/27/2022 1:35:18 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[get_employee_details]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	select empname, empage, departmentname, salaryAmount 
	from employee 
	join department on employee.departmentid= department.departmentid 
	join salary on employee.salaryid=Salary.Salaryid 
END
GO

