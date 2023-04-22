namespace Observer
{
    public interface IObservable
    {
        void AddObserver(IObserver<Alarm> alarmObserver);
        void DeleteObserver(IObserver<Alarm> alarmObserver);
        void Notify();
    }
}
