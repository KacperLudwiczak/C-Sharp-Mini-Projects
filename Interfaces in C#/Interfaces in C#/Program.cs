namespace Interfaces_in_C_
{
    public interface IAnimal
    {
        void MakeSound();
        void Eat(string food);
    }

    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeSound();
            dog.Eat("Meat");

            Cat cat = new Cat();
            cat.MakeSound();
            cat.Eat("Fish");

            IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
            PaymentService paymentService = new PaymentService(creditCardProcessor);
            paymentService.ProcessOrderPayment(100.00m);

            IPaymentProcessor paypalProcessor = new PaypalProcessor();
            paymentService = new PaymentService(paypalProcessor);
            paymentService.ProcessOrderPayment(200.00m);

            Console.ReadKey();
        }
    }
}
