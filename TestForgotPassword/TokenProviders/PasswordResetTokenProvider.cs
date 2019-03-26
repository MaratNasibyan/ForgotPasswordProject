using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestForgotPassword.TokenProviders
{
    public class PasswordResetTokenProvider<T> : DataProtectorTokenProvider<IdentityUser>
    {
        public PasswordResetTokenProvider(IDataProtectionProvider dataProtectionProvider, IOptions<PasswordResetTokenProviderOptions> options) : base(dataProtectionProvider, options)
        {
        }
    }

    public class PasswordResetTokenProviderOptions : DataProtectionTokenProviderOptions
    {

    }
}