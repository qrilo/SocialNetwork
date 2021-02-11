using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Contracts
{
    public interface IEmailService
    {
        public Task<bool> TryConfirmEmail(int userId, string token);
        public Task<string> GenerateToken(string email);
        public Task<bool> IsEmailConfirmed(string email);
        public Task SendEmail(string email, string subject, string message);


    }
}
