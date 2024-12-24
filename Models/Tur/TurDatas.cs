using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Deneme1.Models.Tur
{
    public class TurDatas
    {
        public static List<Tur> Items { get; set; }

        static TurDatas()
        {
            Items = new List<Tur> {
                new Tur { Id = 1, Ad = "Bilim Kurgu" },
                new Tur { Id = 2, Ad = "Aksiyon" },
                new Tur { Id = 3, Ad = "Dram" },
                new Tur { Id = 4, Ad = "Macera" },
                new Tur { Id = 5, Ad = "Suç" }
            };
        }
    }
}