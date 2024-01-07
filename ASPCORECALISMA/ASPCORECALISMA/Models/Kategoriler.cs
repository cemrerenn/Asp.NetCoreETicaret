using System.ComponentModel.DataAnnotations;

namespace ASPCORECALISMA.Models
{
    public class Kategoriler
    {
        [Key]
        public int KategoriID { get; set; }
        public string KategoriAd { get; set; }

        public ICollection<Urunler> urunlers { get; set; }
    }
}
