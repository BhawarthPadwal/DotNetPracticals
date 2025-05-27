using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExperimentNo3_4
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.BindTable();
            }

        }

        public void BindTable()
        {
            string sp_name = "selectSP";
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\DotNet Projects\\ExperimentNo3_4\\App_Data\\Database1.mdf\";Integrated Security=True");
            SqlCommand cmd = new SqlCommand(sp_name, con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            using (SqlDataAdapter sqa = new SqlDataAdapter(cmd))
            {
                using (DataTable dt = new DataTable())
                {
                    sqa.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }

            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sp_name = "insertSP";
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\DotNet Projects\\ExperimentNo3_4\\App_Data\\Database1.mdf\";Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand(sp_name, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@e_id", TextBox1.Text);
            cmd.Parameters.AddWithValue("@e_name", TextBox2.Text);
            cmd.Parameters.AddWithValue("@e_city", TextBox3.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            this.BindTable();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string sp_name = "updateSP";
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\DotNet Projects\\ExperimentNo3_4\\App_Data\\Database1.mdf\";Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(sp_name, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@e_id", TextBox1.Text);
            cmd.Parameters.AddWithValue("@e_name", TextBox2.Text);
            cmd.Parameters.AddWithValue("@e_city", TextBox3.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            this.BindTable();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string sp_name = "deleteSP";
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\DotNet Projects\\ExperimentNo3_4\\App_Data\\Database1.mdf\";Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(sp_name, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@e_id", TextBox1.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            this.BindTable();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";

        }

    }
}