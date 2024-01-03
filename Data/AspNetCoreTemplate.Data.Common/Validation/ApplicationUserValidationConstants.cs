namespace Blog.Data.Common.Validation
{
    public static class ApplicationUserValidationConstants
    {
        public const int UseernameMaxLength = 20;
        public const int EmailMaxLength = 50;
        public const int PasswordMaxLength = 256; //DB encrypted password length
        public const int PasswordSaltMaxLength = 256;
    }
}
