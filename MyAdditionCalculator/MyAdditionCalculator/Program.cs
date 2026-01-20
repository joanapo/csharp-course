// See https://aka.ms/new-console-template for more information
int firstNumber = 0;
int secondNumber = 0;
string operation;
            
Console.WriteLine("Enter the first number: ");
bool success1 = int.TryParse(Console.ReadLine(), out firstNumber);
Console.WriteLine("Enter the second number: ");
bool success2 = int.TryParse(Console.ReadLine(), out secondNumber);
Console.WriteLine("Choose an operation: +, -, *, /");
operation = Console.ReadLine();
if (success1 && success2){
    switch(operation){
        case "+":
            Console.WriteLine($"Result: {firstNumber + secondNumber}");
            break;
        case "-":
            Console.WriteLine($"Result: {firstNumber - secondNumber}");
            break;
        case "*":
            Console.WriteLine($"Result: {firstNumber * secondNumber}");
            break;
        case "/":
            if (secondNumber != 0){
            Console.WriteLine($"Result: {firstNumber / secondNumber}");
            } else {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            break;
        default:
            Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
            break;
    }
}

Console.ReadKey();