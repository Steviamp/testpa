using System.ComponentModel.DataAnnotations;

namespace QWinpanel.Services.Requests
{
    public class LoginRequest
    {
        [Required]
        public string windowsUser { get; set; }
        [Required]
        public string dnsServer { get; set; }
        [Required]
        public string computerName { get; set; }
    }
}
