namespace FA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string MyName;
            MyName = "Ivan";
            Console.WriteLine(MyName);

            Console.WriteLine("\t Привет мир");
            Console.WriteLine("\t Мне 23 года");
            Console.WriteLine("\t My name is \n  Ivan");
            Console.WriteLine('\u0040');
            Console.WriteLine('\x23'); */

            string MyName = "Ivan";
            byte MyAge = 23;
            bool HaveIApet = true;
            double MyShoeSize = 41.5;

            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("MyAge " + MyAge);
            Console.WriteLine("Do I have a pet? " + HaveIApet);
            Console.WriteLine("My shoe size is " + MyShoeSize);


        }
    }
}