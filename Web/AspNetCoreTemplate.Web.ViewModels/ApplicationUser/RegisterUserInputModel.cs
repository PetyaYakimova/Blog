namespace Blog.Web.ViewModels.ApplicationUser
{
    using System.ComponentModel.DataAnnotations;
    using AutoMapper;
    using Blog.Common.Validation;
    using Blog.Services.Mapping;

    public class RegisterUserInputModel
    {
        [Required]
        [MinLength(ApplicationUserValidationConstants.UsernameMinLenght)]
        [MaxLength(ApplicationUserValidationConstants.UsernameMaxLength)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [MinLength(ApplicationUserValidationConstants.EmailMinLength)]
        [MaxLength(ApplicationUserValidationConstants.EmailMaxLength)]
        public string Email { get; set; }

        [Required]
        [MinLength(ApplicationUserValidationConstants.PasswordMinLength)]
        [MaxLength(ApplicationUserValidationConstants.PasswordMaxLength)]
        public string Password { get; set; }

        [Required]
        [MinLength(ApplicationUserValidationConstants.PasswordMinLength)]
        [MaxLength(ApplicationUserValidationConstants.PasswordMaxLength)]
        public string PasswordConfirmation { get; set; }

        //public void CreateMappings(IProfileExpression configuration)
        //{
        //    configuration.CreateMap<RegisterUserInputModel, Blog.Data.Models.ApplicationUser>()
        //        .ForMember(d => d.Password, opt => opt.Ignore())
        //        .ForSourceMember(s => s.PasswordConfirmation, opt => opt.DoNotValidate())
        //        .ForMember(d => d.Articles, opt => opt.Ignore())
        //        .ForMember(d => d.PasswordSalt, opt => opt.Ignore());
        //}
    }
}
