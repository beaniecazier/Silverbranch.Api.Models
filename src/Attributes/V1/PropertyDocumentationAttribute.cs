using Gay.Silverbranch.API.Models.Enum;
using Gay.Silverbranch.API.Models.Enum.V1;

namespace Gay.Silverbranch.API.Models.Attributes.V1;

[System.AttributeUsage(System.AttributeTargets.All)]
public class PropertyDocumentationAttribute : System.Attribute
{
    protected const string BaseErrorMessage = "The model requires this property to be set";

    public string Description = "Undescribed property of this model";
    public string Error = BaseErrorMessage;
    public string DefaultValue = "";
    public eDbType DbType { get; init; }
    public eFormat Format { get; init; }
    public eEncoding Encoding { get; init; }
    public eValidationType ValidationType { get; init; }
    public bool Required = false;
    public bool ReadOnly = false;
    public string AlternateName = "";
    public int FieldLength = 0;

    public PropertyDocumentationAttribute() { }

    public PropertyDocumentationAttribute(string error)
    {
        if (!string.IsNullOrWhiteSpace(error)) Error += $". {error}";
    }
}
