int[] array = RadMas(8);
Console.WriteLine($"[{String.Join(",", array)}]");

int[] RadMas(int size){
    int[] massiv = new int[size];
    for(int i=0;i<size;i++){
        massiv[i] = new Random().Next(0,100);
    }
    return massiv;
}