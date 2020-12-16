using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Models.Class
{
    public class AdminDinamik
    {
        [Key]
        public int ıd { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}