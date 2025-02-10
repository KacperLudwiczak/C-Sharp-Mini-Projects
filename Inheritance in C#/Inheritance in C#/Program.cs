namespace Inheritance_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Animal: ");
            Animal animal = new Animal();
            animal.Eat();
            animal.MakeSound();
            Console.WriteLine("\nDog: ");
            Dog myDog = new Dog();           
            myDog.Eat();
            myDog.MakeSound();
            Console.WriteLine("\nCat: ");
            Cat myCat = new Cat();
            myCat.Eat();
            myCat.MakeSound();
            Console.WriteLine("\nMops: ");
            Mops myMops = new Mops();
            myMops.Eat();
            myMops.MakeSound();

            // Part 2 of Polymorphism
            // We can do this:
            // Animal dog = new Dog();
            // But not this: 
            // Dog dog = new Animal();

            BaseClass baseClass = new BaseClass();
            baseClass.ShowFields();
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.AccessFields();
            derivedClass.ShowFields();

            Console.WriteLine("\nEmployee: ");
            Employee joe = new Employee("Joe", 36, "Sales Rep", 12345);
            joe.DisplayEmployeeInfo();
            Console.WriteLine("\nManager: ");
            Manager carl = new Manager("Carl", 45, "Manager", 123123, 7);
            carl.DisplayManagerInfo();
            Console.WriteLine("Manager after become older method: ");
            carl.BecomeOlder(5);
            carl.DisplayManagerInfo();

            Console.ReadKey();
        }
    }

    // Base Class (Parent Class or Superclass): the class whose members are inherited.
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
        // Part 1 of Polymorphism
        public virtual void MakeSound() // virtual makes the method override (possible to change) in different (derived) classes, this is a type of Polymorphism
        {
            Console.WriteLine("Animal sound");
        }
    }

    // Derived Class(Child Class or Subclass): the class that inherits the members of the base class.
    // Single Inheritance: class (Dog) inherits from one base class (Animal).
    class Dog : Animal
    {
        public override void MakeSound() // override makes this method of derived classes possible to change
        {
            base.MakeSound(); // base makes the functinality from the base method ("Animal sound")
            Console.WriteLine("Barking...");
        }
    }

    // Hierarchical Inheritance: multiple classes (Cat, Dog) inherit one base class (Animal).
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meowing...");
        }
    }

    // Multilevel Inheritance: class (Mops) derived from another derived class (Dog).
    class Mops : Dog // A breed of dog (rasa psa)
    {
        public void GoingNuts()
        {
            Console.WriteLine("Collie going Nuts");
        }
    }

    class BaseClass
    {
        // access modifiers
        public int publicField; // accessible from anywhere in the program
        protected int protectedField; // accessible in the class it is declared in and in subclasses
        private int privateField; // accessible only within the same class
        public void ShowFields()
        {
            Console.WriteLine($"\nPublic: {publicField}. Protected: {protectedField}. Private: {privateField}");
        }
    }

    class DerivedClass: BaseClass
    {
        public void AccessFields()
        {
            publicField = 1;
            protectedField = 2;
            // privateField = 3; // this is not possible due to its protection level (different class)
        }
    }

}
