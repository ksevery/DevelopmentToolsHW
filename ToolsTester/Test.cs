namespace ToolsTester
{
    using System;
    using log4net;
    using log4net.Appender;
    using log4net.Config;

    class Test
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Test));
        static void Main ()
        {
            var fileAppender = new FileAppender();
            fileAppender.File = "log.txt";
            fileAppender.AppendToFile = true;

            BasicConfigurator.Configure();

            log.Info("Infoed.");
            log.Error("You have erred.");

        }
    }
}
