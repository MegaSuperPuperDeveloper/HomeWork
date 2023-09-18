Console.Write("Введите число: ");
int a =  Convert.ToInt32(Console.ReadLine());
int b = 1;
while(b <= a) {
    if(b % 2 == 0) {
        if(b == a || b == a - 1) {
            Console.Write($"{b}.");
        } else {
            Console.Write($"{b}, ");
        }
    }
    b++;
}