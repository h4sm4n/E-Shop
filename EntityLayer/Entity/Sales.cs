﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EntityLayer.Entity
{
    public class Sales
    {
        public int Id  { get; set; }

        [Display(Name="Ürün")]
        public int ProductId  { get; set; }

        public virtual Product Product { get; set; }

        [Display(Name="Adet")]
        public int Quantity  { get; set; }

        [Display(Name="Fiyat")]
        public decimal Price  { get; set; }

        [Display(Name="Tarih")]
        public DateTime Date  { get; set; }

        [Display(Name="Resim")]
        public string Image  { get; set; }

        [Display(Name="Kullanıcı")]
        public int UserId  { get; set; }

        public virtual User User { get; set; }

        [Display(Name="Kargo Fiyatı")]
        public decimal ShipmentPrice  { get; set; }

        [Display(Name="Toplam Fiyat")]
        public int TotalPrice  { get; set; }

        [Display(Name="Kargo Takip")]
        public string TrackNumber  { get; set; }
    }
}
