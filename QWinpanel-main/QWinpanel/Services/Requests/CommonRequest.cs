using System.ComponentModel.DataAnnotations;

namespace QWinpanel.services.Requests
{
    public class CommonRequest
    {
        [Required]       
        public string? cashierNr { get; set; }

        [Required]
        public string? host { get; set; }

        [Required]
        public bool? nbgTicketDisplayed { get; set; } = null;

        [Required]
        public bool? nbgTicketAccepted { get; set; } = null;

    }
}
