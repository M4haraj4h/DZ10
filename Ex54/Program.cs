int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int temp = 0;

int[,] array = new int[a,b];
Random rnd = new Random();

for (int i = 0; i < a; i++)
    {   
        for (int j = 0; j < b; j++)
            {
                array[i,j] = rnd.Next(1,10);
            }
    }

for (int i = 0; i < a; i++)
    {   
        for (int j = 0; j < b; j++)
            {
                Console.Write(array[i,j]);
            }
            Console.WriteLine("");
    }

Console.WriteLine("");

for (int i = 0; i < a; i++)
    {   
     
        for (int j = 0; j < b; j++)
            {
                int min=j;
                for (int k = j + 1; k < a; k++)
                {
                    if (array[i,k] > array[i,min])
                    {
                        min = k;
                    }
                }

                temp = array[i,j];
                array[i,j] = array[i,min];
                array[i,min] = temp;
            }
    }
    

for (int i = 0; i < a; i++)
    {   
        for (int j = 0; j < b; j++)
            {
                Console.Write(array[i,j]);
            }
            Console.WriteLine("");
    }