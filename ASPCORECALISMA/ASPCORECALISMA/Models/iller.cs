using System.ComponentModel.DataAnnotations;

namespace ASPCORECALISMA.Models
{
    public class iller
    {
        [Key]
        public int illerID { get; set; }
        public string illerAD { get; set; }
    
        
       
        public ICollection<Firmalar> firmalars { get; set; }
      

    }
}
