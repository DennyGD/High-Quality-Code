namespace Log4NetExample
{
    using log4net;

    internal class Logger
    {
        internal static readonly ILog Log = LogManager.GetLogger(typeof(Student));
    }
}
