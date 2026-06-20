

using com.ntier.Aviation;

namespace Aviation
{

    class Program
    {
        private AirplanePart? _enginePart;
   
        static void Main(string[] args)
        {

            Program program = new Program();
            program._enginePart = new EnginePart

            {
                PartNumber = "EP-100",
                Description = "Turbofan Engine",
                Price = 15_000.00,
                EngineType = "GE-90"
            };

            Console.WriteLine("\n-----Engine Part-----");
            //NOTE the cast
            Console.WriteLine(((EnginePart)program._enginePart).GetPartInfo());
      

            Console.WriteLine("\n-----Airplane Part----");
            AirplanePart airplanePart = program._enginePart;
            Console.WriteLine(airplanePart.GetPartInfo());
        }
    }
}