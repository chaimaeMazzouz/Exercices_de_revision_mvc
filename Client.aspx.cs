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
    public partial class Client : System.Web.UI.Page
    {
        SqlConnection cn_ComVoyage = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                if ((Session["Nom"] != null) && (Session["Prenom"] != null) )
                {
                    LblNamePr.Text = $"{Session["nom"]} {Session["Prenom"]}";

                }
                else
                    Server.Transfer("Login.aspx");

        }
    }
}