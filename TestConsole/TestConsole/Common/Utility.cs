using System.Configuration;
namespace TestConsole.Common
{
    public static class Utility
    {
        public static Log4NetWrapper InitLog()
        {
            return new Log4NetWrapper("TestConsole.Logger");
        }
        public static void SetLogPath(string logPath)
        {
            log4net.GlobalContext.Properties["LogFileNameLocation"] = string.IsNullOrEmpty(logPath) ?
                ConfigurationSettings.AppSettings["LogPath"] : logPath;
            log4net.Config.XmlConfigurator.Configure();
        }
    }
}
