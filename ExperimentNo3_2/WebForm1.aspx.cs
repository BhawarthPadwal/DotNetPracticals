using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExperimentNo3_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\DotNet Projects\\ExperimentNo3_2\\App_Data\\Database1.mdf\";Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void insert_btn_Click(object sender, EventArgs e)
        //{
        //    string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\DotNet Projects\\ExperimentNo3_2\\App_Data\\Database1.mdf\";Integrated Security=True";
        //    SqlConnection con = new SqlConnection(connectionString);
        //    con.Open();
        //    string empId = eid_txt.Text;
        //    string empName = ename_txt.Text;
        //    string empDesign = edesign_txt.Text;
        //    string empContact = econtact_txt.Text;
        //    string empAddress = eaddress_txt.Text;
        //    string query = "Insert into EmployeeTable(eid,ename,edesign,econtact,eaddress) values(" + empId + "," + empName + "," + empDesign + "," + empContact + "," + empAddress + ")";
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Record Inserted');", true);
        //}
        protected void insert_btn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\DotNet Projects\\ExperimentNo3_2\\App_Data\\Database1.mdf\";Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Safe SQL query using parameters
                string query = "INSERT INTO EmployeeTable (eid, ename, edesign, econtact, eaddress) VALUES (@eid, @ename, @edesign, @econtact, @eaddress)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Convert eid to integer (if required)
                    cmd.Parameters.AddWithValue("@eid", Convert.ToInt32(eid_txt.Text));
                    cmd.Parameters.AddWithValue("@ename", ename_txt.Text);
                    cmd.Parameters.AddWithValue("@edesign", edesign_txt.Text);
                    cmd.Parameters.AddWithValue("@econtact", econtact_txt.Text);
                    cmd.Parameters.AddWithValue("@eaddress", eaddress_txt.Text);

                    cmd.ExecuteNonQuery();
                }
            }
            // Clear textboxes after successful insertion
            eid_txt.Text = "";
            ename_txt.Text = "";
            edesign_txt.Text = "";
            econtact_txt.Text = "";
            eaddress_txt.Text = "";

            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Record Inserted Successfully');", true);
        }

        protected void update_btn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\DotNet Projects\\ExperimentNo3_2\\App_Data\\Database1.mdf\";Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Correct SQL UPDATE statement
                string query = "UPDATE EmployeeTable SET ename = @ename, edesign = @edesign, econtact = @econtact, eaddress = @eaddress WHERE eid = @eid";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ename", ename_txt.Text);
                    cmd.Parameters.AddWithValue("@edesign", edesign_txt.Text);
                    cmd.Parameters.AddWithValue("@econtact", econtact_txt.Text);
                    cmd.Parameters.AddWithValue("@eaddress", eaddress_txt.Text);
                    cmd.Parameters.AddWithValue("@eid", Convert.ToInt32(eid_txt.Text)); // Ensure eid is an integer

                    int rowsAffected = cmd.ExecuteNonQuery(); // Execute query

                    if (rowsAffected > 0)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Record Updated Successfully');", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('No record found with this ID');", true);
                    }
                }
            }

            // Clear textboxes after updating
            eid_txt.Text = "";
            ename_txt.Text = "";
            edesign_txt.Text = "";
            econtact_txt.Text = "";
            eaddress_txt.Text = "";
        }

        protected void delete_btn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\DotNet Projects\\ExperimentNo3_2\\App_Data\\Database1.mdf\";Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Correct DELETE query
                string query = "DELETE FROM EmployeeTable WHERE eid = @eid";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@eid", Convert.ToInt32(eid_txt.Text)); // Ensure eid is an integer

                    int rowsAffected = cmd.ExecuteNonQuery(); // Execute the DELETE command

                    if (rowsAffected > 0)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Record Deleted Successfully');", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('No record found with this ID');", true);
                    }
                }
            }

            // Clear textboxes after deletion
            eid_txt.Text = "";
        }

        protected void show_btn_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\DotNet Projects\\ExperimentNo3_2\\App_Data\\Database1.mdf\";Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM EmployeeTable"; // Adjust table name if necessary
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt); // Fetch data into DataTable
                        GridView1.DataSource = dt; // Bind data to GridView
                        GridView1.DataBind(); // Refresh GridView
                    }
                }
            }
        }
    }
}