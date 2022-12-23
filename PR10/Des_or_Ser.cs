using System.Text.Json.Nodes;
using Newtonsoft.Json;

namespace PR10;

internal class Des_or_Ser
{
    
    
    public static void MySerialeze<T>(T pers)
    {
        string desktop = Environment.GetFolderPath((Environment.SpecialFolder.Desktop));
        
        string json = JsonConvert.SerializeObject(pers);
        File.WriteAllText(desktop + "/PEOPLE_PASSWORD.json", json);
    }

    public static T MyDesirialize<T>()
    {
        string desktop = Environment.GetFolderPath((Environment.SpecialFolder.Desktop));
        
        string json = File.ReadAllText(desktop + "/PEOPLE_PASSWORD.json");
        T type = JsonConvert.DeserializeObject<T>(json);
        return type;
    }
}