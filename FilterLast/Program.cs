namespace FilterLast
{
    internal static class Program
    {
        static void Main(string[] args)
        {


            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = numbers.FilterLast(-11);
            Console.WriteLine(string.Join(", ", result));
            Console.ReadKey();
        }


        public static IEnumerable<T> FilterLast<T>(this IEnumerable<T> source, int N)
        {
            if (N < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(N), "N не может быть отрицательным.");
            }

            if (source == null)
            {
                throw new ArgumentNullException(nameof(source), "Источник не может быть null.");
            }

            var queue = new Queue<T>();

            foreach (var item in source)
            {
                queue.Enqueue(item);

                if (queue.Count > N)
                {
                    yield return queue.Dequeue();
                }
            }


        }
    }
}
