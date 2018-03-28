<pre style="background:#042029;color:#839496">[XmlRoot(<span style="color:#269186"><span style="color:#269186">"</span>CxXMLResults<span style="color:#269186">"</span></span>)]
    public class CxXMLResults
    {
        [<span style="color:#536871">XmlElement</span>("Query")]
        public List&lt;Query> Query { get; set; }

    }

    public class Query
    {
        [<span style="color:#536871">XmlElement</span>("Result")]
        public List&lt;Result> Result { get; set; }
        [<span style="color:#536871">XmlAttribute</span>("name")]
        public string Name { get; set; }
    }

    public class Result
    {
        [<span style="color:#536871">XmlElement</span>("Path")]
        public Path Path { get; set; }
    }

    public class Path
    {
        [<span style="color:#536871">XmlElement</span>("PathNode")]
        public List&lt;PathNode> PathNode { get; set; }
    }

    public class PathNode
    {
        [<span style="color:#536871">XmlElement</span>("FileName")]
        public string FileName { get; set; }

        [<span style="color:#536871">XmlElement</span>("Line")]
        public int Line { get; set; }

        [<span style="color:#536871">XmlElement</span>("Column")]
        public int Column { get; set; }

        [<span style="color:#536871">XmlElement</span>("Snippet")]
        public Snippet Snippet { get; set; }
    }

    public class Snippet
    {
        [<span style="color:#536871">XmlElement</span>("Line")]
        public Line Line { get; set; }
    }

    public class Line
    {
        [<span style="color:#536871">XmlElement</span>("Code")]
        public string Code { get; set; }
    }

    public class XmlYuklenenler
    {
        public string XmlYuklenen { get; set; }
    }


</pre>