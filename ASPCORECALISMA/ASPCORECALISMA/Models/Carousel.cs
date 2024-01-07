using System.ComponentModel.DataAnnotations;

namespace ASPCORECALISMA.Models
{
    public class Carousel
    {
        [Key]
        public int CaroueselID { get; set; }

        public string CarouselBaslik { get; set; }
        public string CarouselAltBaslik { get; set; }

        public string CarouselAciklama { get; set; }

        public string CarouselFotoUrl { get; set; }
    }
}
