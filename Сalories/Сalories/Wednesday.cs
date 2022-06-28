
namespace Сalories
{
    internal class Wednesday : FoodList, IDayOfTheWeek
    {
        public void DayOfTheWeek()
        {
            Console.WriteLine("\nСреда:\n");
        }

        public void MorningWednesday()
        {
            Console.WriteLine($"Утро: Гречка - {buckwheat} Ккал на 100 грам\n{GetSpaces()}Яйцо в крутую - {softBoiledEgg} Ккал в 1шт");
        }

        public void DinnerWednesday()
        {
            Console.WriteLine($"Обед: Куринная грудка - {breast} Ккал в 100 грам\n{GetSpaces()}Баклажан - {eggplantOfGrill} Ккал в 100 грам");
        }

        public void EveningWednesday()
        {
            Console.WriteLine($"Ужен: Митай отваренный {boiledPollock} Ккал в 100 грам\n{GetSpaces()}Cвежие овощи - {freshVegetables} Ккал на 100 грам");
        }
    }
}
