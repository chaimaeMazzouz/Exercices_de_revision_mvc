using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercices_de_révision
{
    public partial class Gestion_Clients : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RemplirGrid();

        }
        SqlConnection cn_Client = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString);

        protected void BynAjouter_Click(object sender, EventArgs e)
        {
            cn_Client.Open();
            SqlCommand cmd = new SqlCommand($"insert into Client values('{TextBox_Num.Text}','{TextBox_Nom.Text}','{TextBox_Prenom.Text}','{TextBox_Adressse.Text}','{TextBox_Email.Text}','{TextBox_Pass.Text}')", cn_Client);
            cmd.ExecuteNonQuery();
            cn_Client.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted');", true);
            TextBox_Num.Text = TextBox_Nom.Text = TextBox_Prenom.Text = TextBox_Email.Text = TextBox_Adressse.Text="";
            RemplirGrid();
        }
        void RemplirGrid()
        {
            cn_Client.Open();
            SqlCommand cmd_rp = new SqlCommand("select*from Client", cn_Client);
            GridView1.DataSource = cmd_rp.ExecuteReader();
            GridView1.DataBind();
            cn_Client.Close();
        }
    }
}