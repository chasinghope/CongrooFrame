
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;


namespace cfg.test
{
public abstract partial class Shape : Luban.BeanBase
{
    public Shape(JSONNode _buf) 
    {
    }

    public static Shape DeserializeShape(JSONNode _buf)
    {
        switch ((string)_buf["$type"])
        {
            case "Circle": return new test.Circle(_buf);
            case "test2.Rectangle": return new test2.Rectangle(_buf);
            default: throw new SerializationException();
        }
    }

   

    public virtual void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "}";
    }
}

}

