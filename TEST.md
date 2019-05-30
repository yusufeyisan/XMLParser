<pre style="background:#042029;color:#839496">[XmlRoot(<span style="color:#269186"><span style="color:#c60000">"</span>CxXMLResults<span style="color:#c60000">"</span></span>)]
<pre style="background:#042029;color:#839496">[XmlRoot(<span style="color:#269186"><span style="color:#c60000">"</span>CxXMLResults<span style="color:#c60000">"</span></span>)]
    <span style="color:#859900">public</span> <span style="color:#738a05">class</span> <span style="color:#268bd2">CxXMLResults</span>
    {ddd
        [XmlElement(<span style="color:#269186"><span style="color:#c60000">"</span>Query<span style="color:#c60000">"</span></span>)]
        <span style="color:#859900">public</span> <span style="color:#859900">List</span>&lt;Query> Query { <span style="color:#268bd2">get</span>; <span style="color:#268bd2">set</span>; }

    }

    <span style="color:#859900">public</span> <span style="color:#738a05">class</span> <span style="color:#268bd2">Query</span>
    {
        [XmlElement(<span style="color:#269186"><span style="color:#c60000">"</span>Result<span style="color:#c60000">"</span></span>)]
        <span style="color:#859900">public</span> <span style="color:#859900">List</span>&lt;Result> Result { <span style="color:#268bd2">get</span>; <span style="color:#268bd2">set</span>; }
        [XmlAttribute(<span style="color:#269186"><span style="color:#c60000">"</span>name<span style="color:#c60000">"</span></span>)]
        <span style="color:#859900">public</span> string Name { <span style="color:#268bd2">get</span>; <span style="color:#268bd2">set</span>; }
    }

    <span style="color:#859900">public</span> <span style="color:#738a05">class</span> <span style="color:#268bd2">Result</span>
    {
        [XmlElement(<span style="color:#269186"><span style="color:#c60000">"</span>Path<span style="color:#c60000">"</span></span>)]
        <span style="color:#859900">public</span> Path Path { <span style="color:#268bd2">get</span>; <span style="color:#268bd2">set</span>; }
    }

    <span style="color:#859900">public</span> <span style="color:#738a05">class</span> <span style="color:#268bd2">Path</span>
    {
        [XmlElement(<span style="color:#269186"><span style="color:#c60000">"</span>PathNode<span style="color:#c60000">"</span></span>)]
        <span style="color:#859900">public</span> <span style="color:#859900">List</span>&lt;PathNode> PathNode { <span style="color:#268bd2">get</span>; <span style="color:#268bd2">set</span>; }
    }

    <span style="color:#859900">public</span> <span style="color:#738a05">class</span> <span style="color:#268bd2">PathNode</span>
    {
        [XmlElement(<span style="color:#269186"><span style="color:#c60000">"</span>FileName<span style="color:#c60000">"</span></span>)]
        <span style="color:#859900">public</span> string FileName { <span style="color:#268bd2">get</span>; <span style="color:#268bd2">set</span>; }

        [XmlElement(<span style="color:#269186"><span style="color:#c60000">"</span>Line<span style="color:#c60000">"</span></span>)]
        <span style="color:#859900">public</span> <span style="color:#268bd2">int</span> Line { <span style="color:#268bd2">get</span>; <span style="color:#268bd2">set</span>; }

        [XmlElement(<span style="color:#269186"><span style="color:#c60000">"</span>Column<span style="color:#c60000">"</span></span>)]
        <span style="color:#859900">public</span> <span style="color:#268bd2">int</span> Column { <span style="color:#268bd2">get</span>; <span style="color:#268bd2">set</span>; }

        [XmlElement(<span style="color:#269186"><span style="color:#c60000">"</span>Snippet<span style="color:#c60000">"</span></span>)]
        <span style="color:#859900">public</span> Snippet Snippet { <span style="color:#268bd2">get</span>; <span style="color:#268bd2">set</span>; }
    }

    <span style="color:#859900">public</span> <span style="color:#738a05">class</span> <span style="color:#268bd2">Snippet</span>
    {
        [XmlElement(<span style="color:#269186"><span style="color:#c60000">"</span>Line<span style="color:#c60000">"</span></span>)]
        <span style="color:#859900">public</span> Line Line { <span style="color:#268bd2">get</span>; <span style="color:#268bd2">set</span>; G}
    }

    <span style="color:#859900">public</span> <span style="color:#738a05">class</span> <span style="color:#268bd2">Line</span>
    {
        [XmlElement(<span style="color:#269186"><span style="color:#c60000">"</span>Code<span style="color:#c60000">"</span></span>)]
        <span style="color:#859900">public</span> string Code { <span style="color:#268bd2">get</span>; <span style="color:#268bd2">set</span>; }
    }

    <span style="color:#859900">public</span> <span style="color:#738a05">class</span> <span style="color:#268bd2">XmlYuklenenler</span>
    {
        <span style="color:#859900">public</span> string XmlYuklenen { <span style="color:#268bd2">get</span>; <span style="color:#268bd2">set</span>; }
    }


</pre>

hoppicik
