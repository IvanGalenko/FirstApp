using System;
using System.Drawing;
using System.Reflection.Metadata;

namespace FA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Модуль 3
            /* string MyName;
            MyName = "Ivan";
            Console.WriteLine(MyName);

            Console.WriteLine("\t Привет мир");
            Console.WriteLine("\t Мне 23 года");
            Console.WriteLine("\t My name is \n  Ivan");
            Console.WriteLine('\u0040');
            Console.WriteLine('\x23'); 

            string MyName = "Ivan";
            byte MyAge = 23;
            bool HaveIApet = true;
            double MyShoeSize = 41.5;

            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("MyAge " + MyAge);
            Console.WriteLine("Do I have a pet? " + HaveIApet);
            Console.WriteLine("My shoe size is " + MyShoeSize); 

            DaysOfWeek MyFavoriteDay;

            MyFavoriteDay = DaysOfWeek.Friday;

            Console.WriteLine(MyFavoriteDay); 

            double result = 10 % 3;
            Console.WriteLine(result); 

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = (byte)int.Parse(Console.ReadLine());
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);
            Console.Write("What is your favorite day of week?");
            DayOfWeek day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}", day); 

            Console.Write("Введите имя: ");
            var name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше имя {0} и вам {1} ", name, age);
            Console.Write("Введите вашу дату рождения: ");
            var birthdate = Console.ReadLine();
            Console.WriteLine("Вы родились {0}", birthdate); */
            #endregion
            #region Модуль 4
            /*
            string A = "a";
            string B = "b";
            bool C = A != B;
            Console.WriteLine(C); 
            var inv = true;
            var result = !inv;
            Console.WriteLine(result);
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
            }

            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
            } 

            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is cyan!");
                    break;
            } 

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Iteration {0}", i);
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }
            } 

            int t = 0;

            do
            {
                Console.WriteLine(t);

                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }

                t++;
            } while (t < 3); 

            int sum = 0;

            while (true)
            {
                Console.WriteLine("Введите число");
                var number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    continue;
                }
                else if (number == 0)
                {
                    break;
                }

                // number > 0
                sum += number;
            }

            Console.WriteLine("Итоговая сумма: {0}", sum); 

            Console.WriteLine("Введите своё имя");

            var name = Console.ReadLine();

            Console.WriteLine("Ваше имя по буквам: ");

            foreach (var ch in name)
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine("Последняя буква вашего имени: {0}", name[name.Length - 1]);

            Console.ReadKey(); 
            Console.WriteLine("Введите своё имя");
            var name = Console.ReadLine();
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i] + " ");
            } 
            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
            Console.WriteLine(array[0, 0]);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            } 
            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
                    Console.Write(array[k, i] + " ");

                Console.WriteLine();
            } 
            //4.3.12
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int temp;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.Write(item);
            } 
            //4.3.13
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
            //4.3.14
            int[][] array = new int[3][];

            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var num in array)
            {
                foreach (var item in num)
                {
                    Console.Write(item + " ");
                }
            }
            //4.3.15
            var arr = new int[] { -2, 1, -1, 2, 3 };
            int pol = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0) pol++;
            }
            Console.WriteLine(pol); 
            //4.3.16
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int pol = 0;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    if (arr[i,j] > 0) pol++;
                }
            }
            Console.WriteLine(pol);
            
            //4.3.17
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int temp;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    for (int k = j + 1; k <= arr.GetUpperBound(1); k++)
                    {
                        if (arr[i,j] > arr[i,k])
                        {
                            temp = arr[i,k];
                            arr[i,k] = arr[i,j];
                            arr[i,j] = temp;
                        }
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.Write(item);
            } 
            //4.4.2
            (string name, int age) anketa;

            Console.Write("Введите ваше имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);

            //4.4.3
            var (name, age) = ("Иван", 23);
            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);
            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age); 
            //4.4.5
            (string Name, string Type, double Age, int NameCount) Pet;
            Console.Write("Введите имя питомца: ");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;
            Console.Write("Введите тип питомца: ");
            Pet.Type = Console.ReadLine();
            Console.Write("Введите возраст питомца: ");
            Pet.Age = Convert.ToDouble(Console.ReadLine());
            (string Name, 
                string LastName, 
                string Login, 
                int LoginCount, 
                bool Pet, 
                double Age, 
                string[] favcolors) User;
            for (int i=0;i<=2;i++)
            {
                Console.Write("Введите имя: ");
                User.Name = Console.ReadLine();
                Console.Write("Введите фамилию: ");
                User.LastName = Console.ReadLine();
                Console.Write("Введите логин: ");
                User.Login = Console.ReadLine();
                User.LoginCount = User.Login.Length;
                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                string temp = Console.ReadLine();
                if (temp == "Да")
                {
                    User.Pet = true;
                }
                else
                {
                    User.Pet = false;
                }
                User.favcolors = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя");
                for (int k = 0; k <= 2; k++)
                {
                    User.favcolors[k] = Console.ReadLine();
                }
            }*/
            #endregion
            #region Модуль 4
            /*
            (string Name, string[] Dishes) User;
            Console.Write("Введите имя пользователя: ");
            User.Name = Console.ReadLine();
            User.Dishes = new string[5];
            for (int i = 0; i < User.Dishes.Length; i++)
            {
                Console.Write("Введите любимое блюдо {0} из {1}: ", i + 1, User.Dishes.Length);
                User.Dishes[i] = Console.ReadLine();
            }
            var favcolors = new string[3];
            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor();
            }
            foreach (var colors in favcolors)
            {
                Console.WriteLine(colors);
            }
            var array = GetArrayFromConsole();
            foreach (var r in array) { Console.Write(r + " "); }

            var array = GetArrayFromConsole(3);
            var sortedarray = SortArray(array);

            foreach (var i in sortedarray)
            {
                Console.Write(i + " ");
            }
            

            //5.3
            int age = 23;
            ChangeAge(age);
            Console.WriteLine(age);
            string name = "Ваня";
            GetName(ref name);
            Console.WriteLine(name);
            var arr = new int[] { 1, 2, 3 };
            BigDataOperation(in arr);

            Console.WriteLine(arr[0]);
           
            var array = GetArrayFromConsole(ref num);
            ShowArray(array, true); 
            int num = 5;
            var arr = new int[4];
            var arr2 = new int[4];
            SortArray2(GetArrayFromConsole(ref num), out arr, out arr2);
            foreach (int i in arr) Console.Write(i + " ");
            Console.WriteLine();
            foreach (int i in arr2) Console.Write(i + " ");*/

            //5.5
            
            Console.WriteLine("Напишите что-то");
            var str = Console.ReadLine();

            Console.WriteLine("Укажите глубину эха");
            var deep = int.Parse(Console.ReadLine());
            //Echo(str, deep);
            //Console.WriteLine(Factorial(20));
            Console.WriteLine(PowerUp(2, 3));
            #endregion
        }
        public static int PowerUp(int N, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else
            {
                if (pow == 1)
                {
                    return N;
                }
                else
                {
                    return N * PowerUp(N, --pow);
                }
            }
        }
        static decimal Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
        static void Echo(string saidworld, int deep)
        {
            var modif = saidworld;
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }
            Console.BackgroundColor = (ConsoleColor)deep;
            Console.WriteLine("..." + modif);
            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }
        static void BigDataOperation(in int[] arr)
        {
            arr[0] = 4;
        }
        static void ChangeAge(int age)
        {
            age = 24;
        }
        static void GetName(out string name, out string oldname)
        {
            oldname = "Евгения";
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();

        }
        static void ShowArray(int[] array, bool sort = false)
        {
            var arr = array;
            if (sort)
            {
                arr = SortArrayDesc(array);
            }
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
        static string ShowColor(string username)
        {
            Console.Write("Напишите свой любимый цвет: ");
            string color = Console.ReadLine();
            return color;
        }
        static void ShowColors(params string[] favcolors)
        {
            Console.WriteLine("Ваши любимые цвета:");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }
        static int[] GetArrayFromConsole(ref int num)
        {
            num = 4;
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("Введите элемент массива номер {0}: ", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }
        static int[] SortArray(int[] result)
        {
            int temp;
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
                
            }
            return result;
        }
        static void SortArray2(in int[] array, out int[] sorteddesc, out int[] sortedasc)
        {
            int[] arrdesc = new int[array.Length];
            Array.Copy(array, arrdesc, array.Length);
            int[] arrasc = new int[array.Length];
            Array.Copy(array, arrasc, array.Length);
            sorteddesc = SortArrayDesc(in arrdesc);
            sortedasc = SortArrayAsc(in arrasc);
            Console.WriteLine();
        }
        static int[] SortArrayDesc(in int[] result)
        {
            int temp;
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] < result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }

            }
            return result;
        }
        static int[] SortArrayAsc(in int[] result)
        {
            int temp;
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }

            }
            return result;
        }
        #region Модуль 3
        /*
        enum DaysOfWeek : byte
        {
            Tuesday,
            Monday,
            Wednesday,
            Friday
        }

        enum Semaphore
        {
            Red = 100, 
            Yellow = 200, 
            Green = 300
        } */
        #endregion
    }
}