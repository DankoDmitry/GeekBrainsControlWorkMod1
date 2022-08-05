namespace ControlWork
{
    class Program
    {
        public static void Main()
        {
            int limited = 3;
            string[] array = new string[] {"hello", "world", "hi", "wor", "wo"};

            string[] args = new string[CountTheNumberOfElements(array, limited)];

            FillArgs(args, array, limited);

            Console.WriteLine("[{0}]", string.Join(", ", args));
        }
        public static int CountTheNumberOfElements(string[] arr, int lim)
        {
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i].Length <= lim) count++;
            }
            return count;
        }
        public static void FillArgs(string[] args, string[] array, int lim)
        {
            int counter = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i].Length <= lim)
                {
                    args[counter] = array[i];
                    counter++;
                }
            }
        }
    }
}