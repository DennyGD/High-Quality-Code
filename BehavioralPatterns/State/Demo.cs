namespace State
{
    using System;

    public class Demo
    {
        public static void Main()
        {
            var someHuman = new Human("Jane");
            someHuman.Live();
            someHuman.Live();
            someHuman.Live(); 
            someHuman.Live();
            someHuman.Live();
        }
    }
}
