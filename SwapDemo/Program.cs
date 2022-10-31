namespace SwapDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Swapping the Number ");
            Console.Write("\nEnter value of a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter Value of b : ");
            int b= Convert.ToInt32(Console.ReadLine()); 

            int c=a;
            a = b;
            b = c;

            Console.WriteLine("After Swapping a : "+a);
            Console.WriteLine("After Swapping b : " +b);

            Console.ReadLine();


        }
    }
}