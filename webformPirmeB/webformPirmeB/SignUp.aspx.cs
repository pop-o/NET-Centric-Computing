using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace webformPirmeB
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_click(object sender, EventArgs e)
        {
            //extracting all the form fields
            string username=uname.Text;
            string password=pass.Text;
            string repassword = repass.Text;
            string gender = "";
            if(r1.Checked)
            {
                gender = r1.Text;
            }
            else
            {
                gender = r2.Text;
            }
            string course = "";
            if(c1.Checked)
            {
                course += c1.Text + " ";
            }
            if (c2.Checked)
            {
                course += c2.Text + " ";
            }
            if (c3.Checked)
            {
                course += c3.Text + " ";
            }
            string coun = "";
            if (country.SelectedValue == "")
            {
                coun = "no country selected";
            }
            else
            {
                coun=country.SelectedValue;
            }
            /*l7.Text = "Username is " + username + " password is " + password 
                + " repassword is " + repassword + " gender is " + gender + 
                " course is " + course + " country is " + coun;*/
            //database connectivity
            string cs = "Data Source=POEM;Initial Catalog=db_prime;Integrated Security=true";
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                conn.Open();
                string insQuery = "insert into tbl_reg values(@username,@password,@repassword,@gender,@course,@country)";
                SqlCommand sc = new SqlCommand(insQuery, conn);
                sc.Parameters.AddWithValue("@username", username);
                sc.Parameters.AddWithValue("@password", password);
                sc.Parameters.AddWithValue("@repassword", repassword);
                sc.Parameters.AddWithValue("@gender", gender);
                sc.Parameters.AddWithValue("@course", course);
                sc.Parameters.AddWithValue("@country", coun);
                int res=sc.ExecuteNonQuery();
                if(res>0)
                {
                    l7.Text = "data inserted";
                }


            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}