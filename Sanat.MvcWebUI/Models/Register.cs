using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sanat.MvcWebUI.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Adınız")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Soyadınız")]
        public string SurName { get; set; }
        [Required]
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }
        [Required]
        [DisplayName("Eposta")]
        [EmailAddress(ErrorMessage ="Eposta adresinizi düzgün giriniz!")]//email adresi olup olmadığını kontrol ediyor
        public string Email { get; set; }
        [Required]
        [DisplayName("Şifre")]
        public string Password { get; set; }
        [Required]
        [DisplayName("Şifre Tekrar")]
        [Compare("Password",ErrorMessage ="Şifreleriniz uyuşmuyor..")]//şifre kontrolu sağlar
        public string RePassword { get; set; }
    }
}