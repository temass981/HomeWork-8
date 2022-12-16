int [,] arTest = NewArrayRandom(4,6);
ArrayOut(arTest);
System.Console.WriteLine();
int [] asd = SumOfElements(arTest);
ArrayOut1(asd);
int small = smallestElement(asd);
System.Console.WriteLine();
System.Console.WriteLine("Сумма элементов в строке " + (small+1) + " является наимешьей");



void ArrayOut(int [,] array){
    for(int i=0;i<array.GetLength(0); i++){
        for (int j=0;j<array.GetLength(1); j++){
                System.Console.Write(array[i,j]+ " ");
        }
        System.Console.WriteLine();
    }
}
void ArrayOut1(int [] array){
    for(int i=0;i<array.Length; i++){
        
  System.Console.Write(array[i]+ " ");

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

int [] SumOfElements(int[,] array){
    int [] arrays = new int [array.GetLength(0)];
     for (int i =0; i<array.GetLength(0); i++){
        int sum =0;
        for (int j=0; j<array.GetLength(1); j++){
            sum+=array[i,j];
            
        }
        arrays [i]=sum;
    }
    return arrays;
}

 int smallestElement (int []array){
    int min = array [0];
    int indexStr =0;
    for (int i =0; i<array.Length; i++){
        if (min>array[i]) {
            min = array[i];
            indexStr = i;
        }
    }
    return indexStr;
 }
