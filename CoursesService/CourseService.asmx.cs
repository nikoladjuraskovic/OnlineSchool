using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CoursesService
{
    /// <summary>
    /// Summary description for CourseService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CourseService : System.Web.Services.WebService
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Courses;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        [WebMethod]
        public List<Course> GetCourses()
        {
            SqlConnection con = new SqlConnection(connectionString);

            List<Course> coursesList = new List<Course>();

            try
            {

                using (con)
                {
                    con.Open();

                    string query = "SELECT * FROM Courses";

                    SqlCommand cmd = new SqlCommand(query, con);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Course s = new Course(reader[1].ToString(), int.Parse(reader[2].ToString()));

                            coursesList.Add(s);
                        }
                    }
                }

            } catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);

            }

            return coursesList;
        }
    }
}
