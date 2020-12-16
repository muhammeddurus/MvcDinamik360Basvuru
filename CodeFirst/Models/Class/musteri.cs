using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Models.Class
{
    public class musteri
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Müşteri Adı Giriniz!")]
        public string Ad { get; set; }
        [Required(ErrorMessage ="Müşteri Soyadı Giriniz!")]
        public string Soyad { get; set; }
        [Required(ErrorMessage ="Müşteri Şehri Giriniz!")]
        public string Sehir { get; set; }
    }
}