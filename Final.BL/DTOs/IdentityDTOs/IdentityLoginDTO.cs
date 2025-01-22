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
    public class IdentityLoginDTO
    {
        [Display(Prompt ="User Name")]
        public string UserName {  get; set; }
        [Display(Prompt ="Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name ="Remember Me")]
        public bool RememberMe {get; set; }
    }
    public class IddentityLoginValidation : AbstractValidator<IdentityLoginDTO>
    {

    }
}
