namespace IntegrationsIntakeForm.Models;

// The full intake form state
public class IntegrationIntakeModel
{
    // Integration Capabilities
    public List<IntegrationFeature> Features { get; set; } = new List<IntegrationFeature>
    {
        new IntegrationFeature { Name = "Order Creation", IsEnabled = true },
        new IntegrationFeature { Name = "Update", IsEnabled = true },
        new IntegrationFeature { Name = "Deletion", IsEnabled = true }
    };

    // Global Account Mapping
    public MappingDetail GlobalAccountMapping { get; set; } = new MappingDetail();

    // Required ID Fields (with nested rules)
    public List<RequiredFieldModel> RequiredIdFields { get; set; } = new List<RequiredFieldModel>
    {
        new RequiredFieldModel { FieldName = "Account Number" },
        new RequiredFieldModel { FieldName = "Service Type" },
        new RequiredFieldModel { FieldName = "Vehicle Type" },
        new RequiredFieldModel { FieldName = "Package Type" }
    };

    // Pickup / Delivery Target Time Windows (Conditional Section)
    public bool MapInboundTimeWindows { get; set; } = false;
    public bool InboundDate_FromFile { get; set; } = true;
    public bool InboundTime_FromFile { get; set; } = false;

    // Package Itemization (Conditional Section)
    public bool EnableItemization { get; set; } = false; // Starts unchecked based on picture
    public NoItemizationType NoItemizationSubOption { get; set; } = NoItemizationType.FromFileWithMapping;
    public string ItemizedRefNoMapping { get; set; }

    // Misc Notes
    public List<string> MiscNotes { get; set; } = new List<string>
    {
        "No need to have non-mappings",
        "Be explicit with usage",
        "Section off mapping w/ multiple layers"
    };
}