using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IAddNDPSUseCase
    {
        Task<Event> Execute(DateTimeOffset date, bool shouldSendMail);
    }
}
