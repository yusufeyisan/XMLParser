using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XMLOkuyucu.Models
{
    public class Kullanici
    {
        public int KullaniciId { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Adınız 3-50 karakter arasında olmalıdır.")]
        public string KullaniciAdi { get; set; }

        [Required(ErrorMessage = "Lütfen parolanızı giriniz.")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Parolanız en az 6, en fazla 50 karakter olmalıdır.")]
        public string KullaniciParola { get; set; }
        
    }
}