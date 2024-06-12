namespace _2._7_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            string fullName = "SNA";
            int age = 22;
            string email = "sai@crs.kz";
            byte scoreProgram = 50;
            byte scoreMath = 10;
            byte scorePhysic = 20;

            Console.WriteLine("ФИО: {0} " +
                            "\nВозрасть: {1} " +
                            "\nЭл.почта: {2} " +
                            "\nБалы по программированию: {3} " +
                            "\nБалы по математике: {4} " +
                            "\nБалы по физике: {5}",
                            fullName, age, email, scoreProgram, scoreMath, scorePhysic);
            #endregion

            #region Task 2
            double averageScore = ((double)scoreProgram + (double)scoreMath + (double)scorePhysic) / 3;
            Console.WriteLine("\nНажмите на любую клавищу для вывода средненго бала . . .");
            Console.ReadKey();
            Console.WriteLine($"Средний бал: {averageScore.ToString("#.#")}"); //Здесь averageScore.ToString("#.#") сокращает запись, оставляя 1 цифру после целого числа
            #endregion
        }
    }
}
