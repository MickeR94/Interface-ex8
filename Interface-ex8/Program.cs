namespace Interface_ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapar objekten. Skriver på de två olika skrivsätten
            Program1 pr1 = new Program1();
            Program2 pr2 = new();

            // Anropar metoderna
            //pr1.Run();
            //pr2.Go();

            pr1.Greeting();
            pr1.Start();            
            pr2.Start();


        }
    }
}
