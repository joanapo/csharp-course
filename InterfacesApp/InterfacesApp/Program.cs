namespace InterfacesApp
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(Decimal amount);
    }

    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount}.");
            // implement credit card payment logic
        }
    }

    public class PayPalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount}.");
            // implement PayPal payment logic
        }
    }

    public class PaymentService
    {
        private readonly IPaymentProcessor _processor;
        public PaymentService(IPaymentProcessor processor)
        {
            _processor = processor;
        }
        public void ProcessOrderPayment(decimal amount)
        {
            _processor.ProcessPayment(amount);
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentProcessor creditCsrdProcessor = new CreditCardProcessor();
            PaymentService paymentService = new PaymentService(creditCsrdProcessor);
            paymentService.ProcessOrderPayment(100.00m);

            IPaymentProcessor payPalProcessor = new PayPalProcessor();
            paymentService.ProcessOrderPayment(200.00m);

            Console.ReadKey();
        }
    }
}
