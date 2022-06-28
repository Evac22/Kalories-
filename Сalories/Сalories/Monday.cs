

namespace Сalories
{
    internal class Monday : FoodList , IDayOfTheWeek 
    {
              

      public void DayOfTheWeek()
        {
            Console.WriteLine("Понедельник:\n");
        } 

        public void MorningMonday()
        {
            Console.WriteLine($"Утро: Овсянка {oatmeal} Ккал на 100 грамм\n{GetSpaces()}Oдин апельсин - {orange} Ккал");
        }

        public void DinnerMonday()
        {
            Console.WriteLine($"Обед: Овощной суп - {vegetableSoup} Ккал на 100 грамм\n{GetSpaces()}Зефир - {marshmallow} Ккал\n      Чай - {tea} Ккал");
        }

        public void EveningMonday()
        {
            Console.WriteLine($"Ужен: Винигред - {vinaigrette} Ккал на 100 грамм\n{GetSpaces()}Куриная грудка - {breast} Ккал на 100 грамм");
        }
    }
}
