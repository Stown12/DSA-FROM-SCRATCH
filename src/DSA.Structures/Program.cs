using DSA.Structures.Linear;

public class Program
{
    public static void Main(string[] args)
    {
        var arrayList = new MyArrayList<int>(5);
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(3);
        arrayList.Add(4);
        Console.WriteLine($"Count: {arrayList.Count}, Capacity: {arrayList.Capacity}");
        arrayList.Insert(1, 99);
        Console.WriteLine($"Count: {arrayList.Count}, Capacity: {arrayList.Capacity}");
        
        
    }
}