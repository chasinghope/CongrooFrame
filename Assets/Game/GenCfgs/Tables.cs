
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;

namespace cfg
{
public partial class Tables
{
    public TBTemp TBTemp {get; }

    public Tables(System.Func<string, JSONNode> loader)
    {
        TBTemp = new TBTemp(loader("tbtemp"));
        ResolveRef();
    }
    
    private void ResolveRef()
    {
        TBTemp.ResolveRef(this);
    }
}

}
