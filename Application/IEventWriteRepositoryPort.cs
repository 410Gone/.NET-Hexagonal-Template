namespace Application
{
    public interface IEventWriteRepositoryPort
    {
        void AddEvent(Event @event);
    }
}