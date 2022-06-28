
namespace Сalories
{
    internal class Thursday : FoodList, IDayOfTheWeek
    {
        public void DayOfTheWeek()
        {
            Console.WriteLine("\nЧетверг:\n");
        }

        public void MorningThursday()
        {
            Console.WriteLine($"Утро: Овсянка - {oatmeal} Ккал на 100 грам\n{GetSpaces()}Чорнослив - {prunes} Ккал  на 100 грам");
        }

        public void DinnerThurday()
        {
            Console.WriteLine($"Обед: Грибной суп - {mushroomSoup} Ккал на 100 грамм");
        }

        public void EveningThursday()
        {
            Console.WriteLine($"Ужен: Рис - {rice} Ккал на 100 грам\n{GetSpaces()}Отворная курица - {boiledBird} Ккал на 100 грам");
        }
    }
}
