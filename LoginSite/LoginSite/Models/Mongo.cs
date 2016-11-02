using System;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Security.Cryptography;
using System.Text;

namespace LoginSite.Models
{
	public class Mongo
	{
        public bool saveUser(User user)
        {
            bool existe = false;
            var client = new MongoClient();                                     //crea nuevo mongodb cliente
            var db = client.GetDatabase("misPartidos");                         //se conecta a la db misPartidos si no existe la crea
            var collection = db.GetCollection<User>("usuariosRegistrados");     //se conecta a la colleccion(tabla) de usuariosRegistrados registrados

            var already = collection.Find(u => u.name == user.name).Limit(1);   //Primer metodo de busqueda Lambda

            if(already.Count() > 0)
            {
                existe = true;
            }
            else
            {
                User t = new User                                               //Crea un usario temporal.
                {
                    Id = ObjectId.GenerateNewId(),                              //Se genera un ID unico
                    name = user.name,
                    pwd = Hash(user.pwd).ToString()
                };
                collection.InsertOne(t);
            }
            return existe;
        }

        public bool readUser(User user)
        {
            bool find = false;
            var client = new MongoClient();                                 //crea nuevo mongodb cliente
            var db = client.GetDatabase("misPartidos");                     //se conecta a la db Users si no existe la crea
            var collection = db.GetCollection<User>("usuariosRegistrados"); //se conecta a la colleccion de usuarios registrados
            try
            {
                var t = collection.Find(new BsonDocument()).ToEnumerable(); //obtiene todos los documentos de la base de datos. Segundo metodo de busqueda
                
                foreach (var item in t)
                {
                    //verifica si los datos ingresados en el formulario "Loging"
                    //coinciden con la base de datos
                    if (!find && item.name == user.name && item.pwd == Hash(user.pwd).ToString())
                    {
                        find = true; break;
                    }
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
            return find;
        }

        private StringBuilder Hash(string pwd)
        {
            byte[] tmpSource;
            byte[] hash_pass;
            StringBuilder newPassword = new StringBuilder();

            tmpSource = ASCIIEncoding.ASCII.GetBytes(pwd);                      //El password del user lo pasamos a ASCII
            hash_pass = new MD5CryptoServiceProvider().ComputeHash(tmpSource);  //aplicamos el hash del ASCII

            for (int i = 0; i < hash_pass.Length; i++)
            {
                newPassword.Append(hash_pass[i].ToString("X2"));                //lo convertimos a hexadecimal
            }
            return newPassword;                                                 //retornamos el nuevo hashpassword
        }
    }
}