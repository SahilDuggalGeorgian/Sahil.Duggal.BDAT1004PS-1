

//Ques number 3 below


static double trianglearea(double a, double b, double c)
    
{
   

    double s = (a + b + c) / 2;

    double Area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

    
    return Area;
}
Console.Write("Enter the length of side 1:");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the length of side 2:");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the length of side 3:");
double c = Convert.ToDouble(Console.ReadLine());
Console.Write("Area of a Triangle = " +trianglearea(a, b, c));
Console.ReadKey();
Console.WriteLine("\n \n");

//Quest no 4 below
Console.WriteLine("\n ques no 4 below \n");


int[] arr1 = new int[10];
int[] arr2 = new int[10];
int[] arr3 = new int[10];
int i, j = 0, k = 0, n;

Console.Write("\n\nSeparate odd and even integers in separate arrays:\n");
Console.Write("------------------------------------------------------\n");

Console.Write("Input the number of elements to be stored in the array :");
n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input {0} elements in the array :\n", n);
for (i = 0; i < n; i++)
{
    Console.Write("element - {0} : ", i);
    arr1[i] = Convert.ToInt32(Console.ReadLine());
}
for (i = 0; i < n; i++)
{
    if (arr1[i] % 2 == 0)
    {
        arr2[j] = arr1[i];
        j++;
    }
    else
    {
        arr3[k] = arr1[i];
        k++;
    }
}

Console.Write("\nThe Even elements are : \n");
for (i = 0; i < j; i++)
{
    Console.Write("{0} ", arr2[i]);
}

Console.Write("\nThe Odd elements are :\n");
for (i = 0; i < k; i++)
{
    Console.Write("{0} ", arr3[i]);
}
Console.Write("\n\n");

// Question number 5 below
Console.WriteLine("\n................. quest 5 below \n");

 static bool inside(float X1, float Y1, float X2, float Y2, float X, float Y)
{
    if (X > X1 && X<X2 && Y > Y1 && Y<Y2)
    {
    return true;

    }

        return false;
    

}
Console.Write("enter the value of X1: ");
float X1 = float.Parse(Console.ReadLine());

Console.Write("enter the value of Y1: ");
float Y1 = float.Parse(Console.ReadLine());

Console.Write("enter the value of X2: ");
float X2 = float.Parse(Console.ReadLine());

Console.Write("enter the value of Y2: ");
float Y2 = float.Parse(Console.ReadLine());

Console.Write("enter the value of X: ");
float X = float.Parse(Console.ReadLine());

Console.Write("enter the value of Y: ");
float Y = float.Parse(Console.ReadLine());

Console.Write(inside(X1, Y1, X2, Y2, X, Y));
Console.WriteLine("\n");
Console.WriteLine(inside(0.3f, 0.5f, 1.1f, 0.7f,(float)1, (float)1));
Console.WriteLine("\n");
Console.WriteLine(inside(0.5f, 0.2f,  1.1f,(float)2, (float)1, (float)1));