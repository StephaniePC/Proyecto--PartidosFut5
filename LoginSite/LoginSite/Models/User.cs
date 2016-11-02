using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;

namespace LoginSite.Models
{
    public class User       //Cualquier usuario que se registre tiene 3 valores ID: unico, name y pwd
    {
        public ObjectId Id { get; set; }
        public string name { get; set; }
        public string pwd { get; set; }
    }
}