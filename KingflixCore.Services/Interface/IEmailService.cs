using System.Threading.Tasks;

namespace KingflixCore.Services.Interface
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}