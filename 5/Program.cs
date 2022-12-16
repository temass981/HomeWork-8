
int [,] array1 = Snake (4,4);
ArrayOut(array1);

int [,] Snake(int n, int m){
    
    int [,] array = new int [n,m];
    int temp = 1;
    int i = 0;
    int j = 0;

while (temp <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}
return array;
}


void ArrayOut(int [,] array){
    for(int i=0;i<array.GetLength(0); i++){
        for (int j=0;j<array.GetLength(1); j++){
                if (array[i,j] / 10 < 1 ) System.Console.Write(array[i,j]+ "  ");
                else System.Console.Write(array[i,j]+ " ");
        }
        System.Console.WriteLine();
    }
}

