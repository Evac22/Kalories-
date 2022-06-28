using System;

namespace Сalories

{
    class Program
    {
        public delegate void GetCountMonday();// Делегат для вывода общего количества ккал в понедельник

       static void Main(string[] agrs)
        {
            
            MyCountClass myCountClass = new MyCountClass();
            GetCountMonday getCountMonday = new GetCountMonday(myCountClass.CountMonday);     
            Monday monday = new Monday();
            monday.DayOfTheWeek();
            monday.MorningMonday();
            monday.DinnerMonday();
            monday.EveningMonday();
            myCountClass.CountMonday();

            Tuesday tuesday = new Tuesday();
            tuesday.DayOfTheWeek();
            tuesday.MorningTuesday();
            tuesday.DinnerTuesday();
            tuesday.EveningTusday();

            Wednesday wednesday = new Wednesday();
            wednesday.DayOfTheWeek();
            wednesday.MorningWednesday();
            wednesday.DinnerWednesday();
            wednesday.EveningWednesday();

            Thursday thursday = new Thursday();
            thursday.DayOfTheWeek();
            thursday.MorningThursday();
            thursday.DinnerThurday();
            thursday.EveningThursday();

            Friday friday = new Friday();
            friday.DayOfTheWeek();
            friday.MorningFriday();
            friday.DinnerFriday();
            friday.EveningFriday();

            Saturday saturday = new Saturday();
            saturday.DayOfTheWeek();
            saturday.MorningSaturday();
            saturday.DinnerSaturday();
            saturday.EveningSatuday();

            Sunday sunday = new Sunday();
            sunday.DayOfTheWeek();
            sunday.MorningSunday();
            sunday.DinnerSunday();
            sunday.EveningSunday();
            


        }
    }
}
