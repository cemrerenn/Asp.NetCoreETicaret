using System.ComponentModel.DataAnnotations;

namespace ASPCORECALISMA.Models
{
    public class Urunler
    {
        [Key]
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public int UrunKategoriID { get; set; }
        public int UrunFirmaID { get; set; }
        public int UrunFiyat { get; set; }
        public string UrunAciklama { get; set; }
        public string UrunUrl1 { get; set; }
        public string UrunUrl2 { get; set; }
        public string UrunUrl3 { get; set; }


        public Kategoriler Kategoriler { get; set; }
        public Firmalar firmalar { get; set; }
        
    }
}
