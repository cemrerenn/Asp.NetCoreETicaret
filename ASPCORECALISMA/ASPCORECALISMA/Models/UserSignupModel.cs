using System.ComponentModel.DataAnnotations;

namespace ASPCORECALISMA.Models
{
    public class UserSignupModel
    {
        [Display(Name ="Ad ")]
        [Required(ErrorMessage ="Lütfen ad  giriniz.")]
        public string Name { get; set; }
        [Display(Name = "Soyad")]
        [Required(ErrorMessage = "Lütfen soyad giriniz.")]
        public string Surname { get; set; }

        [Display(Name = "şifre")]
        [Required(ErrorMessage = "Lütfen şifre giriniz.")]
        public string Password { get; set; }

        [Display(Name = "Şifre")]
        [Compare("Password",ErrorMessage = "Şifreler Uyuşmuyor")]
        public string ConfirmPassWord { get; set; }

        [Display(Name = "Mail")]
        [Required(ErrorMessage = "Lütfen mail adresi giriniz.")]
        public string Mail { get; set;}

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen Kullanıcı Adı giriniz.")]
        public string UserName { get; set; }
    }
}
