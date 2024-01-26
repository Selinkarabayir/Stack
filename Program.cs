namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            stack stack1 = new stack(4);
            /*stack1.push(1);
            stack1.push(2);
            stack1.push(4);
            stack1.push(7);
            stack1.push(8);
            stack1.print();
            Console.WriteLine(" -------");
            stack1.pop();
            stack1.print();
            int cikan=stack1.pop();
            Console.WriteLine("silinen eleman "+ cikan);
            Console.WriteLine("satck in güncel hali =");
            stack1.print();*/
            stack1.push(45);
            stack1.push(35);
            stack1.push(25);
            stack1.push(15);
            stack1.print();
            Console.WriteLine("---------");
            stack1.ezicipush(16);
            stack1.print();




        }
    }
}