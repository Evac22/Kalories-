
namespace Сalories
{
    internal class MyCountClass : FoodList
    {
        

        public void CountMonday()
        {          
           int countColories = oatmeal + orange + vegetableSoup + marshmallow + vinaigrette + breast;
           Console.WriteLine("\nВ понедельник общее количество Ккал - " + countColories);              
        }
    }
}
