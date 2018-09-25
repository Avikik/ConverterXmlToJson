using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlToJsonConverter.Model;
namespace XmlToJsonConverter.Core
{
    public class XmlParser
    {
        public static List<Layer> ParseXmlDocument(string inputFileName)
        {
            List<Layer> layerList =
                (
                    from LayerLevelOne in XDocument.Load(inputFileName).Root.Elements("Layer")
                    select new Layer
                    {
                        Name = (string)LayerLevelOne.Element("Name"),
                        Title = "",
                        Sublayers =
                        (
                            from SubLayer in LayerLevelOne.Elements("Layer")
                            select new Layer
                            {
                                Name = (string)SubLayer.Element("Name"),
                                Title = (string)SubLayer.Element("Title"),
                                Attributes = (
                                    from AttributeSubLayer in SubLayer.Elements("Attributes").Elements("Attribute")
                                    select new Model.Attribute
                                    {
                                        Name = (string)AttributeSubLayer.Attribute("name").Value,
                                        Type = (string)AttributeSubLayer.Attribute("type").Value
                                    }
                                ).ToArray()
                            }
                        ).ToArray()
                    }).ToList();
            return layerList;
        }
    }
}
