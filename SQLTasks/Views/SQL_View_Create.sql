USE [CompanyDetails]
GO

/****** Object:  View [dbo].[emp_dep]    Script Date: 10/28/2022 10:21:12 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[emp_dep] as
select empname,empid,empage, salaryid, DepartmentName from employee 
											join Department on employee.departmentid=Department.Departmentid
GO


