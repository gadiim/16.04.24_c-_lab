using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Тема: Інтерфейси
//Модуль 7


namespace _16._04._24_c__lab
{

    //Task_1

    public interface IOutput
    {
        void Show();
        void Show(string info);
    }
    public class Array_1 : IOutput
    {
        private int[] array;

        public Array_1(int size)
        {
            array = new int[size];
        }

        public void Show()
        {
            Console.Write("array:\t\t");
            foreach (int v in array)
            {
                Console.Write($"{v} ");
            }
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"{array[i]} ");
            //}
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine($"{info} ");
            Show();
        }

    }

    //Task_2

    public interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);
    }
    public class Array_2 : IOutput, IMath
    {
        private int[] array;

        public Array_2(int size)
        {
            array = new int[size];
        }
        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public void Show()
        {
            Console.Write("array:\t\t");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine($"{info} ");
            Show();
        }

        public int Max()
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        public int Min()
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        public float Avg()
        {
            float sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }
        public bool Search(int valueToSearch)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == valueToSearch)
                {
                    return true;
                }
            }
            return false;
        }

    }

    //Task_3


    public interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }

    public class Array_3 : IOutput, IMath, ISort
    {
        private int[] array;

        public Array_3(int size)
        {
            array = new int[size];
        }
        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public void Show()
        {
            Console.Write("array:\t\t");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine($"{info} ");
            Show();
        }

        public int Max()
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        public int Min()
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        public float Avg()
        {
            float sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }
        public bool Search(int valueToSearch)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == valueToSearch)
                {
                    return true;
                }
            }
            return false;
        }
        public void SortAsc()
        {
            Array.Sort(array);
        }

        public void SortDesc()
        {
            Array.Sort(array);
            Array.Reverse(array);
        }
        public void SortByParam(bool isAsc)
        {
            if (isAsc) { SortAsc(); }
            else if (!isAsc) { SortDesc(); }
        }

    }


        internal class Program
    {
        static void Main(string[] args)
        {


            //Завдання 1
            //Створіть інтерфейс IOutput. У ньому мають бути два
            //методи:
            //■ void Show() — відображає інформацію;
            //■ void Show(string info) — відображає інформацію та
            //інформаційне повідомлення, зазначене у параметрі info.
            //Створіть клас Array(масив цілого типу) із необхідними методами.
            //Цей клас має імплементувати інтерфейс IOutput.
            //Метод Show() — відображає на екран елементи масиву.
            //Метод Show(string info) — відображає на екрані елементи масиву
            //та інформаційне повідомлення, зазначене у параметрі info.
            //Напишіть код для тестування отриманої функціональності.

            Console.WriteLine($"Task 1\n");

            Array_1 array1 = new Array_1(4);

            array1.Show();
            Console.WriteLine();
            array1.Show("info:");
            Console.WriteLine("\npress any key to continue");
            Console.ReadKey();
            Console.WriteLine();

            //Завдання 2
            //Створіть інтерфейс IMath.У ньому мають бути чотири методи:
            //■ int Max() — повертає максимум;
            //■ int Min() — повертає мінімум;
            //■ float Avg() — повертає середньоарифметичне;
            //■ bool Search(int valueToSearch) — шукає valueSearch всередині контейнера даних.
            //Повертає true, якщо значення знайдено.
            //Повертає false, якщо значення не знайдено.
            //Клас, створений у першому завданні Array, має імплементувати інтерфейс IMath.
            //Метод Max — повертає максимум серед елементів масиву.
            //Метод Min — повертає мінімум серед елементів масиву.
            //Метод Avg — повертає середньоарифметичне серед елементів масиву.
            //Метод Search — шукає значення всередині масиву.
            //Повертає true, якщо значення знайдено.Повертає false,
            //якщо значення не знайдено.
            //Напишіть код для тестування отриманої функціональності

            Console.WriteLine($"Task 2\n");

            Array_2 array2 = new Array_2(4);

            array2[0] = 10;
            array2[1] = 50;
            array2[2] = 2;
            array2[3] = 100;
            array2.Show();

            Console.WriteLine($"max:\t\t{array2.Max()}");
            Console.WriteLine($"min:\t\t{array2.Min()}");
            Console.WriteLine($"average:\t{array2.Avg()}");
            Console.WriteLine();

            int valueToSearch = 30;
            Console.WriteLine($"valueToSearch = {valueToSearch}");
            if (array2.Search(valueToSearch))
            {
                Console.WriteLine($"{valueToSearch} in array");
            }
            else
            {
                Console.WriteLine($"no {valueToSearch} in array");
            }
            Console.WriteLine();

            valueToSearch = 50;
            Console.WriteLine($"valueToSearch = {valueToSearch}");
            if (array2.Search(valueToSearch))
            {
                Console.WriteLine($"{valueToSearch} in array");
            }
            else
            {
                Console.WriteLine($"no {valueToSearch} in array.");
            }
            
            Console.WriteLine("\npress any key to continue");
            Console.ReadKey();
            Console.WriteLine();

            //Завдання 3
            //Створіть інтерфейс ISort.У ньому мають бути три
            //методи:
            //■ void SortAsc() — сортування за зростанням;
            //■ void SortDesc() — сортування за зменшенням;
            //■ void SortByParam(bool isAsc) — сортування залежно від переданого параметра.
            //Якщо isAsc дорівнює true, сортуємо за зростанням.
            //Якщо isAsc дорівнює false, сортуємо за зменшенням.
            //Клас, створений у першому завданні Array, має імплементувати інтерфейс ISort.
            //Метод SortAsc — сортує масив за зростанням.
            //Метод SortDesc — сортує масив за спаданням.
            //Спосіб SortByParam — сортує масив залежно від переданого параметра.
            //Якщо isAsc дорівнює true, сортуємо за зростанням.
            //Якщо isAsc дорівнює false,
            //сортуємо за зменшенням.
            //Напишіть код для тестування отриманої функціональності.

            Console.WriteLine($"Task 3\n");

            Array_3 array3 = new Array_3(4);

            array3[0] = 10;
            array3[1] = 50;
            array3[2] = 2;
            array3[3] = 100;
            array3.Show();

            Console.WriteLine("\nsort asc:");
            array3.SortAsc();
            array3.Show();

            Console.WriteLine("\nsort desc:");
            array3.SortDesc();
            array3.Show();

            // Сортування залежно від переданого параметра (зростання або спадання)
            Console.WriteLine("\nsort by param (asc):");
            array3.SortByParam(true);
            array3.Show();

            Console.WriteLine("\nsort by param (desc):");
            array3.SortByParam(false);
            array3.Show();

            Console.WriteLine();

        }
    }
}
