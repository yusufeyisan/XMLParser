using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace XMLOkuyucu.Models
{
    [XmlRoot("CxXMLResults")]
    public class CxXMLResults
    {
        [XmlElement("Query")]
        public List<Query> Query { get; set; }

    }

    public class Query
    {
        [XmlElement("Result")]
        public List<Result> Result { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
    }

    public class Result
    {
        [XmlElement("Path")]
        public Path Path { get; set; }
    }

    public class Path
    {
        [XmlElement("PathNode")]
        public List<PathNode> PathNode { get; set; }
    }

    public class PathNode
    {
        [XmlElement("FileName")]
        public string FileName { get; set; }

        [XmlElement("Line")]
        public int Line { get; set; }

        [XmlElement("Column")]
        public int Column { get; set; }

        [XmlElement("Snippet")]
        public Snippet Snippet { get; set; }
    }

    public class Snippet
    {
        [XmlElement("Line")]
        public Line Line { get; set; }
    }

    public class Line
    {
        [XmlElement("Code")]
        public string Code { get; set; }
    }

    public class XmlYuklenenler
    {
        public string XmlYuklenen { get; set; }
    }




}