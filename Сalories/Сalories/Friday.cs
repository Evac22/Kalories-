
namespace Сalories
{
    internal class Friday : FoodList, IDayOfTheWeek
    {
        public void DayOfTheWeek()
        {
            Console.WriteLine("\nПятница:\n");
        }

        public void MorningFriday()
        {
            
            Console.WriteLine($"Утро: Хлопя - {flakes} Ккал на 100 грам\n{GetSpaces()}Банан - {banana} Ккал в 1 шт");
        }
         
        public void DinnerFriday()
        {
            Console.WriteLine($"Обед: Рисовый суп - {riceSoup} Ккал на 100 грам\n{GetSpaces()}Овощи - {freshVegetables} Ккал на 100 грам");
        }

        public void EveningFriday()
        {
            Console.WriteLine($"Ужин: Семга - {salmon} Ккал на 100 грам\n{GetSpaces()}Овощи запеченые - {bakedVegetables} Ккал в 100 грам");
        }
    }
}
