using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace StudentsService
{
    /// <summary>
    /// Summary description for StudService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class StudService : System.Web.Services.WebService
    {

        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Students;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
      
        [WebMethod]
        public List<Student> GetStudents()
        {
            

                SqlConnection con = new SqlConnection(connectionString);

                List<Student> studentsList = new List<Student>();

            try { 

                using (con)
                {
                    con.Open();

                    string query = "SELECT * FROM Students";

                    SqlCommand cmd = new SqlCommand(query, con);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Student s = new Student(reader[1].ToString(), reader[2].ToString(), int.Parse(reader[3].ToString()));

                            studentsList.Add(s);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }

            return studentsList;
        }

        [WebMethod]
        public void InsertStudents(string lastName, string firstName, int year)
        {
            try
            {

                SqlConnection con = new SqlConnection(connectionString);

                using (con)
                {
                    con.Open();

                    string query = "INSERT INTO Students(LastName, FirstName, Year) " +
                                    " VALUES(@prezime, @ime, @godina);";

                    SqlParameter p1 = new SqlParameter();
                    SqlParameter p2 = new SqlParameter();
                    SqlParameter p3 = new SqlParameter();

                    p1.Value = lastName;
                    p1.ParameterName = "@prezime";
                    p2.Value = firstName;
                    p2.ParameterName = "@ime";
                    p3.Value = year;
                    p3.ParameterName = "@godina";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);

                    cmd.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }

        }
    }
}
