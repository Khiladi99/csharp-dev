public class fibonacci
{
    public static void Main(string[] args)
    {
        int a=0,b=1,c,n,i;
        System.Console.Write("Enter number of terms: ");
        n = int.Parse(System.Console.ReadLine());

        System.Console.Write(a+" "+b+" ");
        for(i=0;i<n-2;i++)
        {
            c=a+b;
            System.Console.Write(c+" ");
            a=b;
            b=c;
        }
        System.Console.WriteLine();
    }
}