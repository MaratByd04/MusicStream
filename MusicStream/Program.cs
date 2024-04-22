using NLog;

namespace MusicStream
{
    internal static class Program
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        [STAThread]
        static void Main()
        {
            var config = new NLog.Config.LoggingConfiguration();

            // ���� ����������� � ����
            var fileTarget = new NLog.Targets.FileTarget("fileTarget") { FileName = "log.txt" };
            config.AddRule(LogLevel.Info, LogLevel.Fatal, fileTarget);

            // ���� ����������� � �������
            var consoleTarget = new NLog.Targets.ConsoleTarget("consoleTarget");
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, consoleTarget);

            LogManager.Configuration = config;

            logger.Info("��������� ��������");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());

        }
    }
}