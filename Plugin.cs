using System;
using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;

namespace InfiniteRadio
{
    public class InfiniteRadioPlugin : Plugin<Config>
    {
        public override string Name => "InfiniteRadio";
        public override string Author => "Rude";
        public override string Prefix => "inf_radio";
        public override Version Version => new Version(1, 0, 0);

        private EventHandlers _handlers;

        public override void OnEnabled()
        {
            _handlers = new EventHandlers();

            Player.UsingRadioBattery += _handlers.OnUsingRadioBattery;

            base.OnEnabled();
            Log.Info("Плагин на бесконечную рацию успешно включен!");
        }

        public override void OnDisabled()
        {
            Player.UsingRadioBattery -= _handlers.OnUsingRadioBattery;

            _handlers = null;
            base.OnDisabled();
            Log.Info("Плагин на бесконечную рацию выключен.");
        }
    }
}