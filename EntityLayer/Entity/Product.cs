using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entity
{
    public class Product
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "Alan Boş Geçilemez")]
        [Display(Name="Ad")]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter olabilir.")]
        public string Name { get; set; }

        [Required (ErrorMessage = "Alan Boş Geçilemez")]
        [Display(Name="Ürün Bilgisi")]
        [StringLength(100, ErrorMessage = "En fazla 100 karakter olabilir.")]
        public string Description { get; set; }

        [Required (ErrorMessage = "Alan Boş Geçilemez")]
        [Display(Name="Marka")]
        [StringLength(20, ErrorMessage = "En fazla 20 karakter olabilir.")]
        public string Brand { get; set; }

        [Required (ErrorMessage = "Alan Boş Geçilemez")]
        [Display(Name="Fiyat")]
        public decimal Price { get; set; }  

        [Required (ErrorMessage = "Alan Boş Geçilemez")]
        [Display(Name="Stok Miktarı")]
        public int Stock { get; set; } 

        [Required (ErrorMessage = "Alan Boş Geçilemez")]
        [Display(Name="Aktif mi?")]
        public bool IsActive { get; set; } 

        [Required (ErrorMessage = "Alan Boş Geçilemez")]
        [Display(Name="S.K.T")]
        [StringLength(10, ErrorMessage = "En fazla 10 karakter olabilir.")]
        public string ExpireDate { get; set; } 

        [Display(Name="Resim")]
        public string Image { get; set; } 

        [Required (ErrorMessage = "Alan Boş Geçilemez")]
        [Display(Name="Popüler mi?")]
        public bool IsPopular { get; set; } 

        [Required (ErrorMessage = "Alan Boş Geçilemez")]
        [Display(Name="Miktar")]
        public int Quantity { get; set; } 

        [Required (ErrorMessage = "Alan Boş Geçilemez")]
        [Display(Name="Kategori")]
        public int CategoryId { get; set; } 

        public virtual Category Category { get; set; }

        public virtual List<Cart> Cart { get; set; }

        public virtual List<Sales> Sales { get; set; }
    }
}
