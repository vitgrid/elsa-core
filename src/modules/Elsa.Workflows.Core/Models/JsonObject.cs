using Elsa.Expressions.Models;

namespace Elsa.Workflows.Core.Models;

public class JsonObject : MemoryDatumReference
{
    public JsonObject()
    {
    }

    public JsonObject(string? defaultValue)
    {
        DefaultValue = defaultValue;
    }

    public string? Name { get; set; }
    public string? DefaultValue { get; }
    public override MemoryDatum Declare() => new(DefaultValue);
}