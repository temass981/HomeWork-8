System.Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());

int [,] ar1 = NewArrayRandom(a,b);
ArrayOut(ar1);
System.Console.WriteLine();
int [,] ar2 = NewArrayRandom(a,b);
ArrayOut(ar2);
System.Console.WriteLine();
int [,] ar3 = ProductOfMatrices(ar1, ar2);
ArrayOut(ar3);


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


int [,] ProductOfMatrices(int [,] array, int [,] array1){
    int [,] array3 = new int [array.GetLength(0),array.GetLength(1)];
    for(int i=0;i<array.GetLength(0); i++){
        for (int j=0;j<array.GetLength(1); j++){
             for (int k=0;k<array.GetLength(1); k++){
               array3 [i,j] += array[i,k] * array1[k,j];
        }
        }
        
    }
    return array3;
}

        