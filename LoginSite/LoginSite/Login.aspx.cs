using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using MongoDB.Bson;
//using MongoDB.Driver;
using LoginSite.Models;

namespace LoginSite
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitEventMethod(object sender, EventArgs e)    //control del boton
        {
            search();
        }

        private void search()                                           //Buscamos el username y password
        {
            Mongo mongo = new Mongo();                                  //Objecto Mongo ubicado en el folder Models
            User user = new User                                        //Objeto User ubicado en el folder User
            {
                name = usernameTextBox.Text,
                pwd = passwordTextBox.Text
            };
            if(mongo.readUser(user))
            {
                Response.BufferOutput = true;
                Response.Redirect("Home.aspx", false);
            }
            else
            {
                messageLabel.Text = "Nombre de usuario o contrasena incorrecta!";
            }
        }
    }
}