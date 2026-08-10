using Exiled.API.Interfaces;
using System.ComponentModel;

namespace InfiniteRadio
{
    public class Config : IConfig
    {
        [Description("Включен ли плагин на сервере?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Включить ли режим отладки?")]
        public bool Debug { get; set; } = false;
    }
}