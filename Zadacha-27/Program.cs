Console.Write("Вводите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(Sum(num));

int Sum(int n){
    int s=0,k=0;
    while (n!=0){
        k=n%10;
        s+=k;
        n/=10;
    }
    return s;
}
