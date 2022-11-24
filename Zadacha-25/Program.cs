Console.Write("A = ");
int a = int.Parse(Console.ReadLine());

Console.Write("B = ");
int b = int.Parse(Console.ReadLine());
 
Console.WriteLine();
Console.WriteLine(Step(a,b));

int Step(int num1, int num2){
    int num3 = num1;
    for(int i=1;i<num2;i++){
        num1 *= num3;
    }
    return num1;
}