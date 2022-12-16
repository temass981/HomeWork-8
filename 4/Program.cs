System.Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());

int [,,] arTest = NewArrayRandom(a,b,c);
ArrayOut(arTest);
System.Console.WriteLine();


void ArrayOut(int [,,] array){
    for(int i=0;i<array.GetLength(0); i++){
        for (int j=0;j<array.GetLength(1); j++){
                for (int k=0;k<array.GetLength(2); k++){
                System.Console.Write(array[i,j,k]+ " {"+i+","+j+","+k+"} ");
        }
         System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

    int [,,] NewArrayRandom(int length, int width, int depth){
            int [] array = new int [length*width*depth];
            for (int i =0; i<array.Length; i++){
                array [i]= new Random().Next(10,100);
                if (i>=1){
                    for (int j =0; j<i;j++){
                        while (array[i]==array[j]){
                            array[i]= new Random().Next(10,100);
                            j=0;
                        }
                    }
                }
            } 
            int count=0;
            int [,,] array1 = new int [length, width,depth];
             for (int i =0; i<array1.GetLength(0); i++){
              for (int j=0; j<array1.GetLength(1); j++){
               for (int k=0; k<array1.GetLength(2); k++){
                array1 [i,j,k] = array[count];
                count++;
             }
        }
    }
    return array1;
    }
