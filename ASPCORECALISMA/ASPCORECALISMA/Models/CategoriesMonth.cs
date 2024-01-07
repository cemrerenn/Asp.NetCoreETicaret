using System.ComponentModel.DataAnnotations;

namespace ASPCORECALISMA.Models
{
    public class CategoriesMonth
    {
        [Key]
        public int UrunID { get; set; }
        public string UrunFoto { get; set; }
        public string UrunBaslik { get; set; }
    }
}
