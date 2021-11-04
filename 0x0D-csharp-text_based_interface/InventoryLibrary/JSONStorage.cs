using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

///<summary>JSON storage class</summary>
public class JSONStorage
{
    public Dictionary<string, object> objects { get; set; } = new Dictionary<string, object>();

    ///<summary>Returns objects dictionary</summary>
    public Dictionary<string, object> All()
    {
        return (this.objects);
    }

    ///<summary>Adds new key-value pair to objects</summary>
    public void New(object obj)
    {
        objects.Add($"{obj.GetType().Name}.{obj.id}", obj);
    }

    ///<summary>Serialize objects to JSON and save in JSON file</summary>
    public void Save()
    {
        var options = new JsonSerializerOptions
        {
            IgnoreNullValues = true,
        };

        string jsonString = JsonSerializer.Serialize<Dictionary<string, object>>(objects, options);

        using (StreamWriter sw = File.CreateText("./storage/inventory_manager.json"))
        {
            sw.WriteLine(jsonString);
        }
    }

    ///<summary>Deserializes JSON file to objects</summary>
    public void Load()
    {
        try
        {
            using (StreamReader sw = File.OpenText("./storage/inventory_manager.json"))
            {
                string jsonString = File.ReadAllText("./storage/inventory_manager.json");
            }
        }
        catch (JsonException)
        {
            Console.WriteLine("Nothing there, boss");
        }
    }
}