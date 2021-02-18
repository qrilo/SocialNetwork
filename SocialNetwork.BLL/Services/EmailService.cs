using AutoMapper;
using MailKit.Net.Smtp;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using SocialNetwork.BLL.Contracts;
using SocialNetwork.DAL.EFCoreContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Services
{
    public class EmailService : IEmailService
    {
        private readonly IMapper _mapper;
        private readonly DatabaseContext _context; 
        public EmailService(DatabaseContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<string> GenerateToken(string email)
        {
            string token = Guid.NewGuid().ToString();
            var user = await _context.Users
                .SingleOrDefaultAsync(u => u.Email == email);

            user.EmailConfirmationToken = token;
            await _context.SaveChangesAsync();

            return token;
        }

        public async Task<bool> IsEmailConfirmed(string email)
        {
            var user = await _context.Users
                .AsNoTracking()
                .SingleOrDefaultAsync(u => u.Email == email);

            return user.IsEmailConfirmed;
        }

        public async Task SendEmail(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("SocialNetwork Administration", "SocialNetwork@mail.com"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 465, true);
                await client.AuthenticateAsync("***", "***"); // Need email and password

                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }

        public async Task<bool> TryConfirmEmail(int userId, string token)
        {
            if (userId <= 0 || token == null)
            {
                return false;
            }

            var user = await _context.Users
                .SingleOrDefaultAsync(u => u.Id == userId);

            if (user.EmailConfirmationToken == token)
            {
                user.IsEmailConfirmed = true;

                _context.Users.Update(user);
                await _context.SaveChangesAsync();

                return true;
            }
            return false;
        }
    }
}
