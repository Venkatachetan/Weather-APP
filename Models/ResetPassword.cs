﻿using System.ComponentModel.DataAnnotations;

namespace WeatherFrontend.Models
{
    public class ResetPassword
    {
        [EmailAddress]
        public string? Email { get; set; }
        public string? Token { get; set; }
        public string? NewPassword { get; set; }
        [Compare ("NewPassword"), DataType  (DataType.Password),Display(Name = "Confirm New Password")]
        public string? ConfirmNewPassword { get; set; }
    }
}
