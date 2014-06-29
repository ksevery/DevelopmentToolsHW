namespace ToolsTester
{
    using System;
    using log4net;
    using log4net.Appender;
    using log4net.Config;
    using log4net.Core;
    using log4net.Layout;

    public class Test
    {
        /// <summary>
        /// The logger - used for any kind of logging. Requires configuration.
        /// </summary>
        private static readonly ILog log = LogManager.GetLogger(typeof(Test));

        /// <summary>
        /// Main method. Calls executables. Not to be used for logic implementation.
        /// </summary>
        public static void Main ()
        {
            
            var fileAppender = new FileAppender();
            fileAppender.File = "../../log.txt";
            fileAppender.AppendToFile = true;
            fileAppender.Layout = new SimpleLayout();
            fileAppender.Threshold = Level.Warn;
            fileAppender.ActivateOptions();

            BasicConfigurator.Configure(fileAppender);

            log.Info("Infoed.");
            log.Error("You have erred.");

        }
    }
}
