using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.BL.DTOs.IdentityDTOs
{
    public class IdentityRegisterDTO
    {
        [Display(Prompt ="Username")]
        public string Username {  get; set; }
        [Display(Prompt = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Prompt = "Email adress")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Prompt ="Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword {  get; set; }
    }
    public class IdentityRegisterValidation : AbstractValidator<IdentityRegisterDTO>
    {
        public IdentityRegisterValidation()
        {
            
        }
    }
}
