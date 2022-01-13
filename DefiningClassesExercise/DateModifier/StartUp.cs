using System;

namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();

            DateModifier dateModifier = new DateModifier();
           var result= dateModifier.GetDaysDiffrence(startDate, endDate);
            Console.WriteLine(result);
        }
    }
}
