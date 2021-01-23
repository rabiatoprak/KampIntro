using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //coorporate = tüzel
    // TuzelMusteri : Musteri : bu olay miras  inheritance müşteri de olan herşey tüzel müşteride de kabul edilir
    class TuzelMusteri : Musteri
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
