namespace Builder_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComputerBuilder builder = new ComputerBuilder();
            Computer myComputer = builder
                .SetCPU("Intel Core i7", 8)
                .SetMotherboard("ASUS ROG Strix", "LGA 1200")
                .SetRAM("Corsair Vengeance", 16)
                .SetStorage("SSD", 512)
                .SetGPU("NVIDIA GeForce RTX 3060", 12)
                .Build();

            System.Console.WriteLine(myComputer);
        }
    }
}