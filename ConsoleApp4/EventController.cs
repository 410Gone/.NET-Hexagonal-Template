using Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class EventController
    {
        private readonly IAddNDPSUseCase _addNDPSUseCase;

        public EventController(IAddNDPSUseCase addNDPSUseCase)
        {
            _addNDPSUseCase = addNDPSUseCase;
        }

        public async Task<EventModel> AddEvent(EventModel eventModel)
        {
            if(eventModel.Type == "NDPS")
            {
                var @event = await _addNDPSUseCase.Execute(eventModel.Date, eventModel.ShouldSendMail);
                return EventApiMapper.Map(@event);
            }
        }
    }
}
