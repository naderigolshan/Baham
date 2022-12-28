using System.ComponentModel.DataAnnotations;
using Baham.Common.Constants;
using Microsoft.AspNetCore.Http;

namespace Baham.ViewModels.Auth;

public class RegisterViewModel
{
    [Display(Name = "نام کاربری")]
    [Required(ErrorMessage = AttributesErrorMessages.RequiredMessage)]
    [MinLength(3, ErrorMessage = AttributesErrorMessages.MinLengthMessage)]
    [MaxLength(30, ErrorMessage = AttributesErrorMessages.MaxLengthMessage)]
    [RegularExpression(@"^\w+$", ErrorMessage = "نام کاربری باید از حروف انگلیسی تشکیل شده باشد")]
    public string UserName { get; set; }

    [Display(Name = "ایمیل")]
    [Required(ErrorMessage = AttributesErrorMessages.RequiredMessage)]
    [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$", ErrorMessage = AttributesErrorMessages.RegularExpressionMessage)]
    [MaxLength(100, ErrorMessage = AttributesErrorMessages.MaxLengthMessage)]
    public string Email { get; set; }

    [Display(Name = "رمز عبور")]
    [Required(ErrorMessage = AttributesErrorMessages.RequiredMessage)]
    [MinLength(6, ErrorMessage = AttributesErrorMessages.MinLengthMessage)]
    [MaxLength(50, ErrorMessage = AttributesErrorMessages.MaxLengthMessage)]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Display(Name = "تکرار رمز عبور")]
    [Required(ErrorMessage = AttributesErrorMessages.RequiredMessage)]
    [DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = AttributesErrorMessages.CompareMessage)]
    public string ConfirmPassword { get; set; }

    [Display(Name = "کدملی")]
    [Required(ErrorMessage = AttributesErrorMessages.RequiredMessage)]
    [MaxLength(10, ErrorMessage = AttributesErrorMessages.MaxLengthMessage)]
    public string NationalCode { get; set; }

    // [Required(ErrorMessage = AttributesErrorMessages.RequiredMessage)]
    // public IFormFile UserAvatar { get; set; }

    // public string Avatar { get; set; }
}
