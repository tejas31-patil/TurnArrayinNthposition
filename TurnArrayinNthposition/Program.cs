namespace TurnArrayinNthposition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Turn the Array in nth Positions

            //initialization of Array
            int[] Arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //print array elements
            Console.WriteLine("Array is :");
            for(int i=0;i<Arr.Length;i++)
            {
                Console.Write("\t"+Arr[i]);
            }
            //get nth value from a user to turn thr Array
            Console.WriteLine("\nenter the nth index positon whewr the turn the ARRAY:");
            int n = int.Parse(Console.ReadLine());
            //initialize a new array where store a your old Array elements
            int[] temp=new int[Arr.Length];
            int j = 0;
            //loop interation from nth to end of Array
            for (int i = n; i < Arr.Length; i++)
            {
                temp[j] = Arr[i];
                j++;
                //Console.Write("\t" + Arr[i]);
            }
            //second iteration to oth position to nth position
            for (int i = 0; i < n; i++)
            {
                temp[j] = Arr[i];
                j++;
               // Console.Write("\t" + Arr[i]);
            }
            //print the new Array
            Console.WriteLine("\nNew Array is :");
            for (int i = 0; i < temp.Length; i++)
            {
                //store elements in old Array
                Arr[i] = temp[i];
                Console.Write("\t" + Arr[i]);
            }
        }
    }
}
