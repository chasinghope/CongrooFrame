using Newtonsoft.Json;

public class AOTGather
{
    public static void Gather()
    {
        JsonConvert.SerializeObject(new { a = 1, b = "2" });
    }
}