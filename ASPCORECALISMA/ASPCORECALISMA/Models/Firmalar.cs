using System.ComponentModel.DataAnnotations;

namespace ASPCORECALISMA.Models
{
    public class Firmalar
    {
        [Key]
        public int FirmaID { get; set; }
        public string FirmaVergiNo { get; set; }
        public string FirmaAdi { get; set; }
        public string FirmaAdresi { get; set; }
        public string FirmaAciklama { get; set; }
        public string FirmaLogoUrl { get; set; }
        public string FirmaSifre { get; set; }

        public int illerID { get; set; }
        public iller iller { get; set; }

        public ICollection<Urunler> urunlers { get; set; }
    }
}
