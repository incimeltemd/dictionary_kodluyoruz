
internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();

        kullanıcılar.Add(3,"meltem d");
        kullanıcılar.Add(5,"murat c");
        kullanıcılar.Add(12,"safiye d");

        foreach ( var item in kullanıcılar)
            Console.WriteLine(item);

        Console.WriteLine(kullanıcılar.Count);
        Console.WriteLine(kullanıcılar.ContainsKey(3));
        Console.WriteLine(kullanıcılar.ContainsValue("murat c"));

        Console.WriteLine(kullanıcılar.Remove(12));
        
        foreach (var item in kullanıcılar.Values)
            Console.WriteLine(item);

    }
}