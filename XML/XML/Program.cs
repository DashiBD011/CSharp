using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {

            var user = new User
            {
                Name = "Andrey",
                Age = 35,
                Phones = new List<string>
                {
                    "+79042144491",
                    "2575755"
                }
            };



            var xmlSerializer = new XmlSerializer(typeof(User));
            using (var filexmlOutput = new FileStream("user.xml", FileMode.Truncate))
            {

                xmlSerializer.Serialize(filexmlOutput, user);
            }

            using (var fileJsonOutput = new FileStream("user.json", FileMode.Truncate))
            {
                JsonSerializer.SerializeAsync(fileJsonOutput, user);
            }

            var xmlDeserializer = new XmlSerializer(typeof(User));
            using var fileXmlInput = new FileStream("user.xml", FileMode.Open);
            var userXml = (User)xmlDeserializer.Deserialize(fileXmlInput);

            using var fileJsonInput = new FileStream("user.json", FileMode.Open);
            var userJson = JsonSerializer.DeserializeAsync<User>(fileJsonInput).Result;

            
            PrintUser(user, "Исходные данные: ");
            PrintUser(userXml, "Десериализованные данные Xml: ");
            PrintUser(userJson, "Десериализованные данные Json: ");
            
            /*var doc = new XmlDocument();
              doc.Load("users.xml");
              var root = doc.DocumentElement; //содержит корневой тег
              Console.WriteLine($"root.InnerText: {root.InnerText}");
              Console.WriteLine($"root.InnerXml: {root.InnerXml}");
              Console.WriteLine();

              var children = root.ChildNodes;
              foreach (XmlNode child in children)
              {
                  var attributes = child.Attributes;
                  foreach (XmlAttribute attribute in attributes)
                  {
                      Console.WriteLine($"attribute: {attribute.Name} - {attribute.Value}");
                  }

                  var innerNode = child.ChildNodes;
                  foreach (XmlNode item in innerNode)
                  {
                      if (item.Name == "company")
                      {
                          Console.WriteLine($"{item.InnerText}");
                      }
                  }
              }
              */

        }
        static void PrintUser(User user, string msg)
        {
            Console.Write($"{msg}: {user.Name}, {user.Age}");
            foreach (var phone in user.Phones)
            {
                Console.Write($" {phone} ");
              
            }
            Console.WriteLine();
        }
    }
}
