

namespace Сalories
{
    internal class Saturday : FoodList, IDayOfTheWeek
    {
        public void DayOfTheWeek()
        {
            Console.WriteLine("\nCуббота:\n");
        }

        public void MorningSaturday()
        {
            Console.WriteLine($"Утро: Пшеничная каша - {wheatPorridge} Ккал\n{GetSpaces()}Яблоко - {apple} Ккал в 1 шт");
        }

        public void DinnerSaturday()
        {
            Console.WriteLine($"Обед: Гречка с овощами - {bakedVegetables} Ккал на 100 грам");
        }

        public void EveningSatuday()
        {
            Console.WriteLine($"Ужен: Творожная запеканка - {cottageCheeseCasserole} Ккал на 100 грамм");
        }
    }
}
