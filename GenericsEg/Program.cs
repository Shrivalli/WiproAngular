namespace GenericEg
{
    class ArrayEg
    {
        public static void main()
        {
            // int[] a = new int[4] { 3, 4, 5, 3 };
            Console.WriteLine("Enter the size of the array");
            int size;
            int.TryParse(Console.ReadLine(), out size);//avoid exception
            Console.WriteLine("Size: "+size);
            if (size != 0)
            {
                int[] a = new int[size];

                Console.WriteLine("Enter the items ");
                for (int i = 0; i < size; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());//format exception
                }

                Console.WriteLine("Printing the items");
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine(a[i]);
                }
                
            }
            Console.ReadLine();
        }
    }
}