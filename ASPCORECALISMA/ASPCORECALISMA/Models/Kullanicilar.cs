using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ASPCORECALISMA.Models
{
    public class Kullanicilar:IdentityUser
    {
       
        public string KullaniciAD { get; set; }
        public string KullaniciSoyad { get; set; }
      
 

    }
}
