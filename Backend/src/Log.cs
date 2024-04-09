public static class Log
{
    public static void Out(params object[] paras)
    {
        Console.WriteLine(String.Join(" ", paras
            .Select(x => x != null ? x : "null")));
    }
}