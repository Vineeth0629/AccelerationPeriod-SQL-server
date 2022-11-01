using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.Net_CRUDOperations
{

    public partial class CRUDOperationsForm : System.Web.UI.Page
    {
        DBCRUDOperations obj = new DBCRUDOperations();
        protected void Page_Load(object sender, EventArgs e)
        {
        
            DdlSalary.DataSource = obj.GetSalaryDetails();
            DdlSalary.DataTextField = "SalaryAmount";
            DdlSalary.DataValueField = "salaryid";
            DdlSalary.DataBind();
            DdlDepartment.DataSource = obj.GetDepartmentDetails();
            DdlDepartment.DataTextField = "DepartmentName";
            DdlDepartment.DataValueField = "departmentid";
            DdlDepartment.DataBind();
            GVEmployee.DataSource = obj.GetEmployee();
            GVEmployee.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            string empName = txtEmployee.Text;

            string empName1 = txtEmployee.Text;

            int age =Convert.ToInt32(txtage.Text == "" ? "0" : txtage.Text);
            int departmentId = Convert.ToInt32(DdlDepartment.SelectedItem.Value);
            int salaryId = Convert.ToInt32(DdlSalary.SelectedItem.Value);
            obj.CreateEmployee(empName,age,departmentId,salaryId);
        }

        protected void btnSave_Click1(object sender, EventArgs e)
        {

        }

        protected void txtage_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GVEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //UPDATE
        protected void Button1_Click(object sender, EventArgs e)
        {

            int empid = Convert.ToInt32(Txtid1.Text);
            string empName = txtEmployee.Text;
            int age = Convert.ToInt32(txtage.Text == "" ? "0" : txtage.Text);
            int departmentId = Convert.ToInt32(DdlDepartment.SelectedItem.Value);
            int salaryId = Convert.ToInt32(DdlSalary.SelectedItem.Value);
            obj.UpdateEmployee( empName,  age,  departmentId,  salaryId,  empid);

        }
        //DELETE
        protected void Button2_Click(object sender, EventArgs e)
        {
            int empid = Convert.ToInt32(Txtid1.Text);
            obj.DeleteEmployee(empid);

        }

      
    }
}