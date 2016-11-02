using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
using LoginSite.Models;
using MongoDB.Bson;

namespace LoginSite
{
    public partial class Registration : System.Web.UI.Page
    {
        Mongo mongo = new Mongo();                                      //Objeto Mongo ubicado en el folder Models
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void resgisterEventMethod(object sender, EventArgs e) //aqui se controla el evento del boton.
        {
            registerUser();
        }

        private void registerUser()                                     //metodo para guardar el usuario.
        {            
            User user = new User
            {
                Id = ObjectId.GenerateNewId(),
                name = usernameTextBox.Text,
                pwd = passwordTextBox.Text
            };
            if(!mongo.saveUser(user))                                   //Encaso de que el username no exista, lo agrega al DB.
            {
                messageLabel.Text = "Usuario agregado correctamente.";
                Response.BufferOutput = true;
                Response.Redirect("Login.aspx", false);
            }
            else                                                        //Si el username ya existe, muestra un mensaje de error.
            {
                messageLabel.Text = "Nombre de usuario ya existe.";
            }
            
        }
    }
}