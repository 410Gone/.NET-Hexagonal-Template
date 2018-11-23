using Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class EFEventWriteRepositoryPort : IEventWriteRepositoryPort
    {
        public void AddEvent(Event @event)
        {
            var efEvent = new Entities.Event()
            {
                Date = @event.Date
            };

            Context.Add(efEvent);
            Context.SaveChanges();
        }



    }
}
