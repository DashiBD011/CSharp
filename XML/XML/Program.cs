using System;
using System.Xml;
namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new XmlDocument();
            doc.Load("users.xml");

            var root = doc.DocumentElement;
            var children = root.ChildNodes;
            foreach (var child in children)
            {
                var attributes = root.Attributes;
                foreach  (XmlAttribute attribute in attributes)
                {

                }
            }
        }
    }
}
