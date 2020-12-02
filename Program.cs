using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Task1
    {
        public object x;
        public object y;
        public object this[int index]{
            get{
                if (index == 0) return x;
                else if (index == 1) return y;
                else throw new Exception();
            }
            set{
                if (index == 0) x = value;
                else if (index == 1) y = value;
                else throw new Exception();
            }
        }
    }

    class Task2
    {
        public DateTime date = DateTime.Today;
        public DateTime this[int index] { get => date.AddDays(index); }
    }

    class Task3BaseClass
    {
        protected int[] array = new int[100];
        public int this[int index]{
            get{
                if (index < 0 || index >= array.Length) throw new Exception();
                return array[index];
            }
            set{
                if (index < 0 || index >= array.Length) throw new Exception();
                array[index] = value;
            }
        }
        public int GetLength()
        {
            return array.Length;
        }
    }

    class Task3ChildClass : Task3BaseClass
    {
        private char[] char_array = new char[100];
        public new char this[int index]{
            get{
                if (index < 0 || index >= char_array.Length) throw new Exception();
                return char_array[index];
            }
            set{
                if (index < 0 || index >= char_array.Length) throw new Exception();
                char_array[index] = value;
            }
        }
        public new int[] GetLength()
        {
            return new int[]{array.Length, char_array.Length};
        }
    }



    class Program
    {   
        static void Main(string[] args)
        {
            
        }
    }
}
