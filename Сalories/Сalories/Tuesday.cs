
namespace Сalories
{
    internal class Tuesday : FoodList , IDayOfTheWeek
    {
        public void DayOfTheWeek()
        {
            Console.WriteLine("\nВторник:\n");
        }

        public void MorningTuesday()
        {
            Console.WriteLine($"Утро: Хлеб с отрубями - {breadWithBran} Ккал на 100 грам\n{GetSpaces()}Сыр твёрдый - {cheese} Ккал на 100 грам");
        }

        public void DinnerTuesday()
        {
            Console.WriteLine($"Обед: Постный борщ - {leanBorscht} Ккал на 100 грам");
        }

        public void EveningTusday()
        {
            Console.WriteLine($"Ужен: Фаршированный перец - {stuffedPepper} Ккал\n{GetSpaces()}Чай - {tea} Ккал");
        }

    }
}
