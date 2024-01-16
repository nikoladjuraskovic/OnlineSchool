using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace School
{
    public partial class Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                StudentsReference1.StudServiceSoapClient studentsService = new StudentsReference1.StudServiceSoapClient();

                GridView1.DataSource = studentsService.GetStudents();

                GridView1.DataBind();

            } catch (Exception ex)
            {
                ErrorLabel.Text = "SERVER ERROR";
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                TextBoxFirstName.CssClass = "form-control";
                TextBoxLastName.CssClass = "form-control";
                TextBoxYear.CssClass = "form-control";

                if (Page.IsValid) 
                {
                                                        
                    string lastName = TextBoxFirstName.Text.Trim();
                    string firstName = TextBoxLastName.Text.Trim();
                    int year = int.Parse(TextBoxYear.Text);


                    StudentsReference1.StudServiceSoapClient studentsService = new StudentsReference1.StudServiceSoapClient();

                    studentsService.InsertStudents(lastName, firstName, year);

                    Response.Redirect("~/Students", false);
                }
                else 
                {
                    
                    if (RequiredFieldValidator1.IsValid == false || RegularExpressionValidator1.IsValid == false)
                        TextBoxFirstName.CssClass += " is-invalid";
                    if (RequiredFieldValidator2.IsValid == false || RegularExpressionValidator2.IsValid == false)
                        TextBoxLastName.CssClass += " is-invalid";
                    if (RequiredFieldValidator3.IsValid == false || RangeValidator1.IsValid == false)
                        TextBoxYear.CssClass += " is-invalid";                   

                }

            }
            

            catch (Exception ex)
            {
                ErrorLabel.Text = "SERVER ERROR";
                System.Diagnostics.Debug.WriteLine("Exception Message: " + ex.Message);
                System.Diagnostics.Debug.WriteLine("Stack Trace: " + ex.StackTrace);
            }
        }
    }
}