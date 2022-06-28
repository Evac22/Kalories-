
namespace Сalories
{
    internal class Sunday : FoodList, IDayOfTheWeek
    {
        public void DayOfTheWeek()
        {
            Console.WriteLine("\nВоскресения:\n");
        }

        public void MorningSunday()
        {
            Console.WriteLine($"Утро: Рисовая каша - {ricePorrige} Ккал на 100 грам\n{GetSpaces()}Персики - {peaches} Ккал в 1 шт");
        }

        public void DinnerSunday()
        {
            Console.WriteLine($"Обед: Макароны - {pasta} Ккал на 100 грам\n{GetSpaces()}Отварная индейка - {boiledTurkey} Ккал на 100 грам");
        }

        public void EveningSunday()
        {
            Console.WriteLine($"Ужен: Cырники - {cheesecakes} Ккал в 1 шт\n{GetSpaces()}Чай - {tea} Ккал");
        }

    }
}
