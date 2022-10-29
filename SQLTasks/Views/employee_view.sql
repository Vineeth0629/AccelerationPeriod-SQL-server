
select * from Department
select * from employee
select * from Salary

alter view VWemployee
as select empname,empage,departmentid,empid from employee

select * from VWemployee

select * from VWsalary


create view VWsalary
as select Salaryid,SalaryAmount from Salary