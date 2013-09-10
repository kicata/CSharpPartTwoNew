using System;
using System.Linq;
using System.Xml;
using System.IO;
using System.Text;

//Write a program that extracts from given XML file all the text without the tags.Example:

//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3">
//<interest> Games</instrest><interest>C#</instrest><interest>Java</instrest></interests></student>

class ExtractFromXMLFile
{

    static void Main()
    {
        string path = @"../../example.xml";
        string pathToWrite = @"../../example.txt";
        XmlTextReader reader = new XmlTextReader(path);
        using (reader)
        {
            StreamWriter writer = new StreamWriter(pathToWrite, false, Encoding.GetEncoding("utf-8"));
            using (writer)
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Text)
                    {
                        writer.WriteLine(reader.Value);
                    }
                }
            }
        } 
    }
}



