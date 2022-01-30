using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>();

            string comandInput = Console.ReadLine();

            while (comandInput!="END")
            {
                string[] comandData = comandInput.Split(new[] {',',' ' },StringSplitOptions.RemoveEmptyEntries);
                if (comandData[0]=="Push")
                {
                    for (int i = 1; i < comandData.Length; i++)
                    {
                        int item = int.Parse(comandData[i]);
                        myStack.Push(item);
                    }
                }
                else if (comandData[0]=="Pop")
                {
                    try
                    {
                        myStack.Pop();
                    }
                    catch (InvalidOperationException ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                    
                }


                comandInput = Console.ReadLine();
            }
            foreach (int item in myStack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(string.Join(
                Environment.NewLine,
                myStack));

        }
    }
}
