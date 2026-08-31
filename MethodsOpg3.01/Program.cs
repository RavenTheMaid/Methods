using System.Reflection.PortableExecutable;

namespace MethodsOpg3._01
{
    internal class Program
    {
        static string ToString(string randomName)
        {
            string stringName = "";
            char[] array;
            array = randomName.ToCharArray(0, randomName.Length);
            foreach (char character in array)
            {
                stringName += character + ", ";
            }
            return stringName;
        }

        //static string Generate()
        //{

        //}

        static void Main(string[] args)
        {

            
            string anotherStringName = ToString("blimbleblomble");
            

        }
    }
}
