using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Exercices_de_révision
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn_ComVoyage = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString))
            {
                cn_ComVoyage.Open();
                string Qr = "select count(1) from Client where Email=@Email and Mdp=@pass";
                SqlCommand cmd = new SqlCommand(Qr, cn_ComVoyage);
                cmd.Parameters.AddWithValue("@Email", TxtB_Email.Text);
                cmd.Parameters.AddWithValue("@pass", TxtB_Password.Text);

                int count = (int)cmd.ExecuteScalar();
                if (count == 1)
                {

                    string Qr_sel = "select * from Client where Email=@Email and Mdp=@pass";
                    SqlCommand cmd_sel = new SqlCommand(Qr_sel, cn_ComVoyage);
                    cmd_sel.Parameters.AddWithValue("@Email", TxtB_Email.Text);
                    cmd_sel.Parameters.AddWithValue("@pass", TxtB_Password.Text);
                    SqlDataReader dr = cmd_sel.ExecuteReader();
                    while (dr.Read())
                    {
                        Session["Compte"] = dr[0].ToString();
                        Session["Nom"] = dr[1].ToString();
                        Session["Prenom"] = dr[2].ToString();
                        Session["Adresse"] = dr[3].ToString();
                        Session["Email"] = dr[4].ToString();
                        Session["Mdp"] = dr[5].ToString();
                    }
                     Response.Redirect("Client.aspx");

                }
                else
                {
                    Response.Write("<script>alert('Ce membre n'exsist pas')</script>");
                }
            }
        }
    }
}