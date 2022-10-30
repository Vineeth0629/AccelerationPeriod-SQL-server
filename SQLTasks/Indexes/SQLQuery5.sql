insert into empDepartment select DepartmentName from department
insert into empSalary select SalaryAmount from salary
insert into employeeinfo select empname,empage,departmentid,salaryid from employee

select * from employeeinfo

delete  from employeeinfo where empid=8

execute sp_helpindex employeeinfo

create clustered index IX_tblemployeeinfo_empage_empname
on employeeinfo (empage ASC, empname DESC)

create nonclustered index IX_tblemployeeinfo_empname
on employeeinfo(empname)


