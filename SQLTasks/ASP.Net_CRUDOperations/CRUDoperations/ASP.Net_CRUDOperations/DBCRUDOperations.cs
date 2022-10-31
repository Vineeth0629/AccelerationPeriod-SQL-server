using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ASP.Net_CRUDOperations
{
    public class DBCRUDOperations
    {
        private SqlConnection sqlConnection = new SqlConnection("Server=MOBACK\\MSSQLSERVER01;Integrated Security=SSPI;Initial Catalog=CompanyDetails");

        //To get data from database using DataSet //Read
        public DataTable GetEmployee()
        {
            DataSet ds = new DataSet();
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();  // declare command
                sqlCommand.CommandType = CommandType.Text;               //command type
                sqlCommand.CommandText = "select * from employeeInfo";       //using inline query or stored procedure
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);     //creating a object for sql data adapter and add sql command
                sqlDataAdapter.Fill(ds, "Employee");                                // fill data into dataset by using data adaptor fill method
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }
            return ds.Tables["Employee"];

        }

        public DataTable GetSalaryDetails()
        {
            DataSet ds = new DataSet();
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();  // declare command
                sqlCommand.CommandType = CommandType.Text;               //command type
                sqlCommand.CommandText = "select * from EmpSalary";       //using inline query or stored procedure
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);     //creating a object for sql data adapter and add sql command
                sqlDataAdapter.Fill(ds, "salary");                                // fill data into dataset by using data adaptor fill method
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }
            return ds.Tables["salary"];

        }
        public DataTable GetDepartmentDetails()
        {
            DataSet ds = new DataSet();
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();  // declare command
                sqlCommand.CommandType = CommandType.Text;               //command type
                sqlCommand.CommandText = "select * from EmpDepartment";       //using inline query or stored procedure
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);     //creating a object for sql data adapter and add sql command
                sqlDataAdapter.Fill(ds, "department");                                // fill data into dataset by using data adaptor fill method
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }
            return ds.Tables["department"];

        }

        //Get by using Data reader //Read
        public void GetEmployeeUsingreader()
        {

            SqlDataReader sqlDataReader;
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = CommandType.Text;
                //sqlCommand.CommandType = CommandType.StoredProcedure;
                //sqlCommand.CommandText = "get_employee_details";
                sqlCommand.CommandText = "select * from VWemployee";  //view
                // sqlCommand.Parameters.AddWithValue("@id", 1);
                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {


                    Console.WriteLine("Employee name: " + sqlDataReader.GetValue(0) + "\nEmployee age: " + sqlDataReader.GetValue(1) +
                        "\nDepartment id: " + sqlDataReader.GetValue(2) + "\nEmployee id: " + sqlDataReader.GetValue(3));

                }

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
        //create
        public void CreateEmployee(string employeeName, int  age, int departmentId, int salaryid)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
               

                sqlCommand.CommandText = "Insert_employee";
                sqlCommand.Parameters.AddWithValue("@name", employeeName);
                sqlCommand.Parameters.AddWithValue("@age", age);
                sqlCommand.Parameters.AddWithValue("@depid", departmentId);
                sqlCommand.Parameters.AddWithValue("@salid", salaryid);
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

        //update
        public void UpdateEmployee()
        {

            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                Console.WriteLine("\nenter employee id to update\n");
                int employeeId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nenter employee age \n");
                int empAge = Convert.ToInt32(Console.ReadLine());

                sqlCommand.CommandText = "update_employee";
                sqlCommand.Parameters.AddWithValue("@age", empAge);
                sqlCommand.Parameters.AddWithValue("@id", employeeId);



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
                sqlCommand.CommandType = CommandType.StoredProcedure;
                Console.WriteLine("\nenter employee id to delete\n");
                int employeeId = Convert.ToInt32(Console.ReadLine());
                sqlCommand.CommandText = "delete_employee";
                sqlCommand.Parameters.AddWithValue("@id", employeeId);


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