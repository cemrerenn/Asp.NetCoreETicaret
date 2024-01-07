using System.ComponentModel.DataAnnotations;

namespace ASPCORECALISMA.Models
{
    public class UserSignInModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını giriniz")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi giriniz")]
        public string password { get; set; }
    }
}
