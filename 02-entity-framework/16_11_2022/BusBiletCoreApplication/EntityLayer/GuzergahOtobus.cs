﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer
{
    public class GuzergahOtobus
    {
        [Key]
        public int seferId { get; set; }
        public int sure { get; set; }
        [StringLength(5)]
        public string kalkisSaat { get; set; }
        public DateTime tarih { get; set; }
        public double biletFiyat { get; set; }

        //Guzergah ile ilişkilendirilecek.
        public int guzergahId { get; set; }
        public Guzergah guzergah { get; set; }

        //Otobus ile ilişkilendirilecek.
        public int otobusId { get; set; }
        public Otobus otobus { get; set; }

        //GuzergahOtobusKullanici ile ilişkilendirilecek.
        public ICollection<GuzergahOtobusKullanici> biletler { get; set; }
    }
}
