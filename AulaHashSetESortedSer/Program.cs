
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            // union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrinyCollection(c);

            // INTERSECTION
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrinyCollection(d);

            // difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrinyCollection(e);
        }
        static void PrinyCollection<T>(IEnumerable<T> collection) {
            foreach (T obj in collection)
            {
                Console.Write(obj + " " );
            }
            Console.WriteLine();
        }
    }
}