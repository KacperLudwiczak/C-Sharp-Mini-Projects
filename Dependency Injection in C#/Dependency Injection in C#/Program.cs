namespace Dependency_Injection_in_C_
{
    public class Hammer
    {
        public void Use()
        {
            Console.WriteLine("Hammering Nails!");
        }
    }
    public class Saw
    {
        public void Use()
        {
            Console.WriteLine("Sawing wood!");
        }
    }

    // Constructor Dependency Injection (DI):
    public class Builder
    {
        private Hammer _hammer;
        private Saw _saw;
        public Builder(Hammer hammer, Saw saw)
        {
            _hammer = new Hammer(); // Builder is responsible for creating its dependencies
            _saw = new Saw();
        }
        public void BuildHouse()
        {
            _hammer.Use();
            _saw.Use();
            Console.WriteLine("House built");
        }
    }

    // Setter Dependency Injection, we don't need constructor Builder(Hammer hammer, Saw saw):   
    /*
    public class Builder
    {      
        public Hammer Hammer { get; set; }
        public Saw Saw { get; set; }

        public void BuildHouse()
        {
            Hammer.Use();
            Saw.Use();
            Console.WriteLine("House built");
        }
    }
    */

   // Interface Dependency Injection:
   /*
   public interface IToolUser
   {
       void SetHammer(Hammer hammer);
       void SetSaw(Saw saw);
   }
   public class Builder : IToolUser
   {
       private Hammer _hammer;
       private Saw _saw;

       public void BuildHouse()
       {
           _hammer.Use();
           _saw.Use();
           Console.WriteLine("House built");
       }
       public void SetHammer(Hammer hammer)
       {
           _hammer = hammer;
       }
       public void SetSaw(Saw saw)
       {
           _saw = saw;
       }
   }
   */

    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer();
            Saw saw = new Saw();

            // Constructor Dependency Injection (DI):                       
            Builder builder = new Builder(hammer, saw);

            // Setter Dependency Injection:
            // Builder builder = new Builder();
            // builder.Hammer = hammer; // Inject dependencies via Stters
            // builder.Saw = saw; // Inject dependencies via Stters

            // Interface Dependency Injection:                       
            // Builder builder = new Builder();
            // builder.SetHammer(hammer);
            // builder.SetSaw(saw);

            builder.BuildHouse();

            MultiFunctionPrinter printer = new MultiFunctionPrinter();
            printer.Print();
            printer.Scan();

            Console.ReadKey();
        }
    }
}
