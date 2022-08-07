Console.WriteLine("Четвёртая задача на определение ряда чётных чисел от 1 до N");

bool valid = false;
int num1 = 0;
int num2 = 1;

while (valid == false) {
Console.WriteLine("Введите число больше 1: ");
string? str = Console.ReadLine();
if(int.TryParse(str, out int number1)) {
    if(number1 > 1) {
    num1 = number1;
    valid = true;
    }
    else Console.WriteLine("Ошибка! Введено число < либо = 1");
}
else Console.WriteLine("Некорректно введено число!");
}

Console.WriteLine("Ряд чётных чисел от 1 до " + num1 + " :");
while (num2 <= num1) {
    if(num2 % 2 == 0) {
    Console.Write(num2 + ", ");
    }
    num2++;
}