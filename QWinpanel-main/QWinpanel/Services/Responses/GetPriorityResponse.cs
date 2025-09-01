using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QWinpanel.services.Responses;

namespace QWinpanel.Services.Responses
{
    public class GetPriorityResponse : BaseResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool selected { get; set; }
    }
}
