System.Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());

int [,] arTest = NewArrayRandom(a,b);
ArrayOut(arTest);
System.Console.WriteLine();
StringOrdering(arTest);
ArrayOut(arTest);

void ArrayOut(int [,] array){
    for(int i=0;i<array.GetLength(0); i++){
        for (int j=0;j<array.GetLength(1); j++){
                System.Console.Write(array[i,j]+ " ");
        }
        System.Console.WriteLine();
    }
}

int [,] NewArrayRandom(int col, int row){
          int [,] array = new int [col, row];
    for (int i =0; i<array.GetLength(0); i++){
        for (int j=0; j<array.GetLength(1); j++){
            array [i,j] = new Random().Next(0,10);
        }
    }
    return array;
}



void StringOrdering(int [,] array){
    
    for(int i =0; i<array.GetLength(0); i++){
        for (int j = 0; j<array.GetLength(1); j++){
            int min = array[i,j];
            for (int k=0; k<array.GetLength(1); k++){
                if (min>array[i,k]){
                    min = array[i,k];
                    array[i,k]=array[i,j];
                    array[i,j]=min;
                }
            }
            }
        }
    }
