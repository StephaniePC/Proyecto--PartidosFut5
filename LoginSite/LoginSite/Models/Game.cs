using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;

namespace LoginSite.Models
{
    public class Game                       //cualqueir partido tiene 4 valores, ID:valor unico, detalles, fecha y hora
    {
        public ObjectId Id { get; set; }
        public string detail { get; set; }
        public string date { get; set; }
        public string time { get; set; }
    }
}