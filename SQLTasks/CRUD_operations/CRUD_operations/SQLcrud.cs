using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;

namespace CRUD_operations
{
    internal class SQLcrud
    {
        private SqlConnection sqlConnection = new SqlConnection("Server=MOBACK\\MSSQLSERVER01;Integrated Security=SSPI;Initial Catalog=CompanyDetails");

        //To get data from database using DataSet //Read
        public DataTable GetEmployee()
        {
            DataSet ds = new DataSet();
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "select * from employee";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(ds, "Employee");
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }
            return ds.Tables["Employee"];

        }

        //Get by using Data reader //Read
        public void  GetEmployeeUsingreader()
        {
            
            SqlDataReader sqlDataReader;
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "select * from employee";
                sqlDataReader = sqlCommand.ExecuteReader();
                
                while (sqlDataReader.Read())
                {
                   

                        Console.WriteLine( "Employee ID: "+ sqlDataReader.GetValue(0) + "\nEmployee name: " + sqlDataReader.GetValue(1));                    

                }
              
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
          

        }
        public void CreateEmployee()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = CommandType.Text;
                Console.WriteLine("\nenter employee name\n");
                string employeeName = Console.ReadLine();
                Console.WriteLine("\nenter employee age\n");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nenter departmentid\n");
                int departmentId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nenter employee salaryid\n");
                int salaryid = Convert.ToInt32(Console.ReadLine());

                sqlCommand.CommandText = "insert into employee values ('" + employeeName + "'," + age +  "," +departmentId +","  +salaryid + ")";
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        //update
        public void UpdateEmployee()
        {

            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = CommandType.Text;
                Console.WriteLine("\nenter employee id to update\n");
                 int employeeId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nenter employee age \n");
                int empAge =  Convert.ToInt32( Console.ReadLine());

                sqlCommand.CommandText = "update employee set empage =" + empAge+" where empid=" + employeeId ;

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        //Delete
            public void DeleteEmployee()
            {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = CommandType.Text;
                Console.WriteLine("\nenter employee id to delete\n");
                int employeeId = Convert.ToInt32(Console.ReadLine());
                sqlCommand.CommandText = "delete from employee where empid=" + employeeId;
         
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

        }

        }

    }
 

