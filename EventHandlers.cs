using Exiled.Events.EventArgs.Player;

namespace InfiniteRadio
{
    public class EventHandlers
    {
        public void OnUsingRadioBattery(UsingRadioBatteryEventArgs ev)
        {
            ev.Drain = 0f;
            ev.IsAllowed = false;
        }
    }
}