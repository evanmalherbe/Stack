using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        private ArrayList _array = new ArrayList();

        public ArrayList List
        {
            get { return _array; }
        }
        public object this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }
        public void Push(object obj)
        {
            if (obj != null)
            {
               
                List.Add(obj);
            }
            else
            {
                throw new InvalidCastException();
            }
        }

        public object Pop()
        {
            if (List.Count == 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                object obj = List[List.Count - 1];
                List.RemoveAt(List.Count - 1);

                return obj;
            }
        }
    }
  
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
        }
    }
}
