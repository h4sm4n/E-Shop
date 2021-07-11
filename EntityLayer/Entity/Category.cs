using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entity
{
    public class Category
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "Alan Boş Geçilemez")]
        [Display(Name="Ad")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter olabilir.")]
        public string Name { get; set; }

        [Required (ErrorMessage = "Alan Boş Geçilemez")]
        [Display(Name="Açıklama")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter olabilir.")]
        public string Description { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
