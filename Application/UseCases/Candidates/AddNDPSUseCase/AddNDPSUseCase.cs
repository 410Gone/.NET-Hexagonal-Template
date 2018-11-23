using Application.UseCases;
using Application.UseCases.Candidates.AddNDPSUseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class AddNDPSUseCase : UseCaseBase<AddNDPSInput, Event>, IAddNDPSUseCase
    {
        IMailPort _mailPort;
        IEventWriteRepositoryPort _eventRepositoryPort;
        
        protected override bool CheckRights(AddNDPSInput input)
        {
            return currentUser.IsBM;
        }

        protected override Event ExecuteCore(AddNDPSInput input)
        {
            var @event = new Event
            {
                Date = input.Date
            };

            if (input.ShouldSendMail)
            {
                _mailPort.SendMail(@event);
            }

            _eventRepositoryPort.AddEvent(@event);
        }
    }
}
