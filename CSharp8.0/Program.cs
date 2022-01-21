using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Forth
{
    public class Word
    {
        public string Name { get; }
        public Action<Vm> Definition { get; }
        public Word(string name, Action<Vm> definition)
        {
            Name = name;
            Definition = definition;
        }
    }
    public class Vm
    {
        public Stack<int> Stack { get; }
        public List<Word> Words { get; }

        public Vm(int depth = 64)
        {
            Stack = new Stack<int>(depth);
            Words = new List<Word>();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vm vm = new Vm();

            Action<Vm> plus = vm => vm.Stack.Push(vm.Stack.Pop() + vm.Stack.Pop());
            vm.Words.Add(new Word("+", plus));

            Action<Vm> bye = vm => Environment.Exit(1);
            vm.Words.Add(new Word("bye", bye));

            while (true)
            {
                var line = ReadLine();
                var words = line.Split(' ');

                foreach (var w in words)
                {
                    if (int.TryParse(w, out var v))
                    {
                        vm.Stack.Push(v);
                    }
                    else
                    {
                        var word = vm.Words.FindLast(word => word.Name == w);
                        if (word != null)
                            word.Definition(vm);
                        else
                            WriteLine("Fail!");
                    }
                }
                PrintStack();
            }
            void PrintStack()
            {
                Write($"<{vm.Stack.Count()}> ");
                foreach (var n in vm.Stack)
                    Write($"{n} ");
                WriteLine(" ok");
            }
        }
    }
}
