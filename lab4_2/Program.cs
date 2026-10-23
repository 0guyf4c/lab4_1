int[,] a = new int[4, 4];
a[0,0] = 1; a[0, 1] = 2; a[0, 2] = 3; a[0, 3] = 4;
a[1, 0] = 12; a[1, 1] = 13; a[1, 2] = 14; a[1, 3] = 5;
a[2, 0] = 11; a[2, 1] = 16; a[2, 2] = 15; a[2,3] = 6;
a[3, 0] = 10; a[3, 1] = 9; a[3, 2] = 8; a[3, 3] = 7;
for (int i = 0; i < 4; i++)
{
    for(int j = 0; j < 4; j++)
    {
        if (a[i,j] <10)
            Console.Write("0" + a[i, j] + " ");
        else
            Console.Write(a[i,j] + " ");
    }
    Console.WriteLine();
}