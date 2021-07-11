using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EntityLayer.Entity
{
    public class User
    {
        public int Id { get; set; }

        [Display(Name="Kullanıcı Adı")]
        [StringLength(20, ErrorMessage = "En fazla 20 karakter olabilir.")]
        public string Username { get; set; }

        [Required (ErrorMessage = "Alan Boş Geçilemez")]
        [Display(Name="Ad")]
        [StringLength(20, ErrorMessage = "En fazla 20 karakter olabilir.")]
        public string Name { get; set; }

        [Required (ErrorMessage = "Alan Boş Geçilemez")]
        [Display(Name="Soyad")]
        [StringLength(20, ErrorMessage = "En fazla 20 karakter olabilir.")]
        public string Surname { get; set; }

        //[Required (ErrorMessage = "Alan Boş Geçilemez")]
        //[Display(Name="Email")]
        //[StringLength(50, ErrorMessage = "En fazla 50 karakter olabilir.")]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //[Required (ErrorMessage = "Alan Boş Geçilemez")]
        //[Display(Name="Şifre")]
        //[StringLength(20, ErrorMessage = "En fazla 20 karakter olabilir.")]
        //[DataType(DataType.Password)]
        public string Password { get; set; }

        //[Required (ErrorMessage = "Alan Boş Geçilemez")]
        //[Display(Name="Şifre(Tekrar)")]
        //[StringLength(20, ErrorMessage = "En fazla 20 karakter olabilir.")]
        //[DataType(DataType.Password)]
        //[Compare("Password",ErrorMessage = "Şifreler uyuşmuyor.")]
        public string RePassword { get; set; }

        
        [StringLength(10, ErrorMessage = "En fazla 10 karakter olabilir.")]
        public string Role { get; set; }

        [Display(Name="Aktif mi?")]
        public bool IsActive { get; set; }

        [Display(Name="TC Kimlik No")]
        [StringLength(11, ErrorMessage = "En fazla 11 karakter olabilir.")]
        public string UserTc { get; set; }

        [Display(Name="Telefon")]
        [StringLength(11, ErrorMessage = "En fazla 11 karakter olabilir.")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Display(Name="Cinsiyet")]
        [StringLength(5, ErrorMessage = "En fazla 5 karakter olabilir.")]
        public string Gender { get; set; }

        [Display(Name="Doğum Tarihi")]
        [StringLength(10, ErrorMessage = "En fazla 10 karakter olabilir.")]
        [DataType(DataType.Date)]
        public string Birthday { get; set; }

        [Display(Name="Şehir")]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter olabilir.")]
        public string City { get; set; }

        [Display(Name="İlçe")]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter olabilir.")]
        public string County { get; set; }

        [Display(Name="Posta Kodu")]
        public int? PostalCode { get; set; }

        [Display(Name="Adres")]
        [StringLength(100, ErrorMessage = "En fazla 100 karakter olabilir.")]
        public string Address { get; set; }

        public virtual List<Sales> Sales { get; set; }
    }
}
