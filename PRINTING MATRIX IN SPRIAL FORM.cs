int[,] a =new int[4,4] {{ 1, 2, 3 ,4},{5,6,7,8},{9,10,11,12},{ 13,14,15,16} };
int j = 0, k = 0, n = 0,z = 0;
for(int i = 0; i < 4; i++)
{
    while (k < 4 - z)
    {
        Console.Write(a[n,j]+" ");
        if (n < 2&&j<3)
        {
            j++;
        }
        else if(n>1&&j>0)
        {
            j--;
        }
        k++;
    }
    if(z<3)
        z++;

    k = 0;
    while (k < 4 - z)
    {
        
        Console.Write(a[n, j] + " ");
        if (j <1&&n<4)
        {
            n--;
        }
        else if(j>1&&n>-1)
        {
            n++;
        }
        k++;
    }
    k = 0;

}