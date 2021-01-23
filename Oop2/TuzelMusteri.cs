using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //Coorporate = Tüzel demek

    //Miras - inheratance
    class TuzelMusteri:Musteri //Tüzel müşteri de müşteriden türemiştir. Müşteride olan herşey tüzeldede olur..
    {

        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }

    }
}
