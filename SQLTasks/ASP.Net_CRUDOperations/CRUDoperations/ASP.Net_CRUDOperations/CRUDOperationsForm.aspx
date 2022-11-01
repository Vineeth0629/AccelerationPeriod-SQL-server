<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUDOperationsForm.aspx.cs" Inherits="ASP.Net_CRUDOperations.CRUDOperationsForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div >
             <div>     Create Employee     </div>
            <table style="width:500px">
                 <tr>
                    <td> 
                        <asp:Label ID="Label1" runat="server" Text="Employyee Id:" BackColor="#FFCCFF"></asp:Label>
                    </td>
                      <td>  <asp:TextBox ID="Txtid1" runat="server" BackColor="#CFECEC" BorderStyle="Solid" Font-Bold="True" OnTextChanged="Txtid1_TextChanged"></asp:TextBox></td>

              
                <tr>
                    <td>  <asp:Label ID="lblEmpName" runat="server" Text="Employyee Name:" BackColor="#FFCCFF"></asp:Label>
                         

                    </td>

                    <td>  <asp:TextBox ID="txtEmployee" runat="server" BackColor="#CFECEC" BorderStyle="Solid" Font-Bold="True"></asp:TextBox></td>
                </tr>
               
                  <tr>
                    <td>  <asp:Label ID="lblEmpAge" runat="server" Text="Employyee Age:" BackColor="#FFCC99"></asp:Label></td>
                    <td>  <asp:TextBox ID="txtage" runat="server" BackColor="#CFECEC" BorderStyle="Solid" OnTextChanged="txtage_TextChanged"></asp:TextBox></td>
                </tr>
                  <tr>
                    <td>  <asp:Label ID="lblEmpSal" runat="server" Text="Employyee Salary:" BackColor="#999966"></asp:Label></td>
                    <td>  <asp:DropDownList ID="DdlSalary" runat="server" BackColor="#9999FF" OnSelectedIndexChanged="DdlSalary_SelectedIndexChanged"></asp:DropDownList></td>
                </tr>
                 <tr>
                    <td>  <asp:Label ID="lblEmpDep" runat="server" Text="Employyee department:" BackColor="#FF6666"></asp:Label></td>
                    <td>  <asp:DropDownList ID="DdlDepartment" runat="server" BackColor="#669999"></asp:DropDownList></td>
                </tr>
            </table>
            <div>
             <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" BackColor="#CCFF66" BorderColor="#CC6699" BorderStyle="Solid" ForeColor="Black" Height="40px" Width="70px" /></div>
            <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Delete" OnClick="Button2_Click" />
        </div>
      <div>
          <div>View Employee </div>
       </div>
       
       
        <asp:GridView ID="GVEmployee" runat="server" OnSelectedIndexChanged="GVEmployee_SelectedIndexChanged">
        </asp:GridView>
       
       
    </form>
</body>
</html>
