create table employee(empid int identity(1,1),
empname varchar(50),
empage int,
departmentid int,
salaryid int)

insert into employee values('giri','24',100,6),('hanvi','24',101,5), ('Vignesh','24',102,3)
insert into Department values ('Admin'), ('HR'), ('Software')
insert into salary values (9000),(3000),(5000)
select * from employee
--select * from Department
select * from salary

select empname ,DepartmentName , SalaryAmount from employee 
													join Department on employee.departmentid = Department.Departmentid
													join Salary on employee.salaryid=salary.salaryid
											  where salaryamount>10000

--drop table employee
--drop table Department


create table Department(Departmentid int identity(100,1),
DepartmentName varchar(30))

create table Salary(Salaryid int identity(1,1),
SalaryAmount int)

select * from employee
select * from Department
select * from Salary