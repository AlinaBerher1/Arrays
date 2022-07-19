class Task1
{
    /* Задание 1
Проинициализируй переменные intArray и doubleArray массивами соответствующих типов,
размер которых равен 10. Выведи их на экран. Выведи их на экран в обратном порядке  */

    static void Main()
    {
        int[] intArray = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.WriteLine(intArray[i]);
        }
        for (int i = 9; i >=0; i--)
        {
            Console.WriteLine(intArray[i]);
        }
        double[] doubleArray = new double[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        for (int i = 0; i < doubleArray.Length; i++)
        {
            Console.WriteLine(doubleArray[i]);
        }
        for (int i = 9; i >=0; i--)
        {
            Console.WriteLine(doubleArray[i]);
        }          
    }
}