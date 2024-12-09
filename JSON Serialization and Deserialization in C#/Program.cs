using System.Text.Json;

namespace JSON_Serialization_and_Deserialization_in_C_
{
    [Serializable]
    public class Fruit
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an instance of the class
            Fruit fruit = new Fruit { Name = "Apple", Price = 26 };
            // Serialize the object to JSON
            string json = SerializeObjectToJson(fruit);
            // Display the serialized JSON
            Console.WriteLine("Serialized JSON Output:");
            Console.WriteLine(json);
            // Deserialize the JSON to an object
            Fruit deserializedPerson = DeserializeJsonToObject(json);
            // Display the deserialized object
            Console.WriteLine("Deserialized Object:");
            Console.WriteLine($"Name: {deserializedPerson.Name}, Price: {deserializedPerson.Price}");
        }
        // Serialize an object to JSON
        static string SerializeObjectToJson(Fruit obj)
        {
            return JsonSerializer.Serialize(obj);
        }
        // Deserialize JSON to an object
        static Fruit DeserializeJsonToObject(string json)
        {
            return JsonSerializer.Deserialize<Fruit>(json);
        }
    }
}
