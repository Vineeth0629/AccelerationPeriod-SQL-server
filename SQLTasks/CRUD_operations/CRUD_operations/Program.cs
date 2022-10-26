

using System.Data;

namespace CRUD_operations
{
    public class Program
    {
        static void Main()
        {
            SQLcrud crud = new SQLcrud();
           // crud.GetEmployeeUsingreader();


           //DataTable dt= crud.GetEmployee();
           // foreach(DataRow dr in dt.Rows)
           // {
           //     Console.WriteLine("Employee ID: " + dr[0].ToString()  + " Employee name: "+ dr[1].ToString());
           // }
            crud.CreateEmployee();
            //crud.UpdateEmployee();
            //crud.DeleteEmployee();
           
        }
    }
}

