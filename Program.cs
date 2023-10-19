using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Collections;
using System.Xml.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Collections collections = new Collections();
            for (int i = 0; i  <4; i++)
            {
                collections.arraylist.Add(i);
                collections.list.Add(i);
                collections.queue.Enqueue(i);
                collections.stack.Push(i);
            }
            collections.InputTypeColl();
        }
    }
    public class Collections
    {
        public ArrayList arraylist = new ArrayList();
        public List<int> list = new List<int>(10);
        public Stack<int> stack = new Stack<int>();
        public Queue<int> queue = new Queue<int>();
        public void InputTypeColl ()
        {
            Console.Write("Введите тип коллекции(arraylist,list,stack,queue): ");
            string typecoll = Console.ReadLine();
            Console.Write("Введите действие(del,add,exit): ");
            string action = Console.ReadLine();
            AddDelExit(typecoll,action);
        }
        public void AddDelExit (string typecoll, string action)
        {
            switch (typecoll)
            {
                case "arraylist":
                    ArrayListActions(action);
                    break;
                case "list":
                    List(action);
                    break;
                case "stack":
                    Stack(action);
                    break;
                case "queue":
                    Queue(action);
                    break;
            }
        }
        public void ArrayListActions (string action)
        {
            if (action == "add")
            {
                Console.Write("Введите количество значений которые хотите ввести:");
                int countnum = Convert.ToInt32(Console.ReadLine());
                int a = 1;

                for (int i = 0; i < countnum; i++)
                {
                    Console.Write("x" +a +": ");  
                    arraylist.Add(Convert.ToInt32(Console.ReadLine()));
                    a++;
                }
                Console.WriteLine("Результат:");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine("x" + i + ": " + arraylist[i]);
                }
            }
            else if (action == "del")
            {
                string status = "нет";
                while (status == "нет")
                {
                    Console.Write("Введите индекс элемент который хотите удалить: ");
                    int removableelement = Convert.ToInt32(Console.ReadLine());
                    arraylist.RemoveAt(removableelement);
                    Console.WriteLine("Элемент х" + removableelement + " удалён");
                    Console.Write("Закончить(да/нет): ");
                    status = Console.ReadLine();
                }
            }
            else if (action == "exit")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine("x" + i + ": " + arraylist[i]);
                }
            }
        }
        public void List(string action)
        {
            if (action == "add")
            {
                int a = 1;
                Console.Write("Введите количество значений которые хотите ввести:");
                int countnum = Convert.ToInt32 (Console.ReadLine());
                for (int i =0; i<countnum; i++)
                {
                    Console.Write("x" + a + ": ");
                    list.Add(Convert.ToInt32(Console.ReadLine()));
                    a++;
                }

            }
            else if (action == "del")
            {
                string status = "нет";
                while (status == "нет")
                {
                    Console.Write("Введите элемент который хотите удалить: ");
                    list.Remove(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Элемент удалён");
                    Console.Write("Закончить(да/нет): ");
                    status = Console.ReadLine();
                }
            }
            else if (action == "exit")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine("x" +i +": "+ list[i]);
                }
            }
        }
        public void Stack(string action)
        {
            if (action == "add")
            {
                int a = 1;
                Console.Write("Введите количество значений которые хотите ввести:");
                int countnum = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < countnum; i++)
                {
                    Console.Write("x" + a + ": ");
                    stack.Push(Convert.ToInt32(Console.ReadLine()));
                    a++;
                }
            }
            else if (action == "del")
            {
                string removedElement = Convert.ToString(stack.Pop());
                Console.Write("Удаленный элемент: " + removedElement +"\n");
            }
            else if (action == "exit")
            {
                foreach (int element in stack)
                {
                    Console.WriteLine("x: " +element);
                }
            }
        }
        public void Queue(string action)
        {
            if (action == "add")
            {
                Console.Write("Введите количество значений которые хотите ввести:");
                int countnum = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < countnum; i++)
                {
                    Console.Write("x: ");
                    queue.Enqueue(Convert.ToInt32(Console.ReadLine()));
                }
            }
            else if (action == "del")
            {
                int removedElement = queue.Dequeue();
                Console.WriteLine("Удаленный элемент: " + removedElement);
            }
            else if (action == "exit")
            {
                foreach (int item in queue)
                {
                    Console.WriteLine("x: "+item);
                }

            }
        }

    }
}
