namespace BAL.Common.Constants
{
    public enum UserErrorCode
    {
        /// <summary>
        /// Suggest user to login again or contact with administrator.
        /// </summary>
        Unauthorized = 1,

        /// <summary>
        /// Suggest user to contact with administrator.
        /// </summary>
        Banned,

        /// <summary>
        /// Suggest user to validate his account via email or sms.
        /// </summary>
        NotValidated,

        /// <summary>
        /// User not allowed to perform an action
        /// </summary>
        AccessRestricted,


        TwoFactorAuth,
        DeviceNotValidated,
        TwoFactorAuthCodeGenerationFailed,
        TwoFactorActiveForInValidUser,
        DeviceError

    }
    public static class Helper
    {
        public static string GetText(this UserErrorCode error)
        {
            switch (error)
            {
                case UserErrorCode.Unauthorized:
                    return "Unauthorized";
                case UserErrorCode.Banned:
                    return "Banned";
                case UserErrorCode.NotValidated:
                    return "Not Validated";
                case UserErrorCode.AccessRestricted:
                    return "Access Restricted";
                default:
                    return error.ToString();
            }
        }
    }
}
