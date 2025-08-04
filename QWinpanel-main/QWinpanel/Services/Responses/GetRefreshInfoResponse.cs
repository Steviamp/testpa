using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWinpanel.services.Responses
{
    public class GetRefreshInfoResponse: BaseResponse
    {
        public string cashierNr { get; set; }
        public string waitingCustomersMQ { get; set; }
        public string waitingCustomersBQ { get; set; }
        public string serviceTypeName { get; set; }
        public string ticketNr { get; set; }
        public string customersInQueue { get; set; }
        public int queue { get; set; }
        public string host { get; set; }
        public string customerText { get; set; }        
    }
}
