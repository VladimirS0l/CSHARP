int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

//int[]array = {15, 221, 29, 34, 13, 11, 16, 44, 22};

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(
    //Max(array[0], array[1], array[2]),
    //Max(array[3], array[4], array[5]),
    //Max(array[6], array[7], array[8])
//);
//Console.WriteLine(max);

int[] array = {12, 3, 42, 45, 52, 14, 15, 12, 52};
int n = array.Length;
int find = 52;
int index = 0;
while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
