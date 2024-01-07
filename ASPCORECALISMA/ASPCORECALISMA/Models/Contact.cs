using System.ComponentModel.DataAnnotations;

namespace ASPCORECALISMA.Models
{
    public class Contact
    {
        [Key]
        public int BildirimID { get; set; }
        public string BildirimAd { get; set; }
        public string BildirimEposta { get; set; }
        public string BildirimKonu { get; set; }
        public string BildirimAciklama { get; set; }

    }
}
