using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWinpanel.Services.Requests
{
    public class CallTicketRequest
    {
        [Required]
        public string cashierNr { get; set; }

        [Required]
        public string host { get; set; }

        [Required]
        public int ticketTrack { get; set; }
    }
}
