alter view emp_dep as
select empname,empid,empage, salaryid, DepartmentName from employee 
											join Department on employee.departmentid=Department.Departmentid

											select * from emp_dep

											select emp_dep.*, Salary.SalaryAmount from emp_dep join Salary on emp_dep.salaryid=Salary.Salaryid

											
										/*	customerOrderView join history
										orderhistory - history
											orderprice -price 
											customerorder -
											return select is, name ,salaryamount*bonus/100 as bonus from employee 

											select from calculatebunus

											1 3 rtryr
											2 4  rdfgdf
											3 3 fdgfch     */
											 