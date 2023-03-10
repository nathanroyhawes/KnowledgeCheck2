namespace KC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many games do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Info>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var info = new Info();

                Console.WriteLine("What is name of the game?");
                info.Name = Console.ReadLine();

                Console.WriteLine("What is the genre?");
                info.Genre = Console.ReadLine();

                recordList.Add(info);
            }

            Console.WriteLine();
            // Print out the list of records using Console.WriteLine()

        }
    }
}