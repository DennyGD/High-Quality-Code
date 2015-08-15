namespace Log4NetExample
{
    using System;

    using log4net;
    using log4net.Config;

    public class Start
    {
        public static void Main()
        {
            //// Please check bin/Debug/log.txt

            XmlConfigurator.Configure();

            var firstStudent = new Student("Jane", "Doe", "JavaScript");
            var secondStudent = new Student("John", "Doe", "CSharp");
            var studentWithInvalidFirstName = new Student("    ", "LastName", "No specialty");
        }
    }
}
