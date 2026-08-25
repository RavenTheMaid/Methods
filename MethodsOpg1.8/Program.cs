namespace MethodsOpg1._8
{
    internal class Program
    {
        static bool HasEqualLength(int[] intArray, string[] stringArray)
        {
            int intArraycounter = 0;
            int stringArrayCounter = 0;
            foreach (int intArrayItem in intArray)
            {
                intArraycounter++;
            }
            foreach (string stringArrayItem in stringArray)
            {
                stringArrayCounter++;
            }
            if (intArraycounter == stringArrayCounter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            int[] intArray = { 1, 5, 3, 6, 78, 123, 321 };
            string[] stringArray = { "bob", "bingus", "bingus", "bingus", "bingus", "bingus", "bingus" };
            Console.WriteLine(HasEqualLength(intArray, stringArray));
        }
    }
}
