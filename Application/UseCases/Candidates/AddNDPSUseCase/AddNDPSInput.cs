using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Candidates.AddNDPSUseCase
{
    class AddNDPSInput
    {
        public DateTimeOffset Date { get; internal set; }
        public bool ShouldSendMail { get; internal set; }
    }
}
