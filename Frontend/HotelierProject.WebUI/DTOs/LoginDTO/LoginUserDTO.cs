﻿using System.ComponentModel.DataAnnotations;

namespace HotelierProject.WebUI.DTOs.LoginDTO
{
    public class LoginUserDTO
    {
        [Required(ErrorMessage = "Kullanıcı Adını Giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifreyi Giriniz")]
        public string Password { get; set; }
    }
}
