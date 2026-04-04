namespace IntegrationsIntakeForm
{
    // Enum for the general mapping options
    public enum MappingType
    {
        NoMapping, // single value
        OneToOne, // based on X segment
        ManyToOne // based on X segment
    }

    // Enum for "No Itemization" sub-options
    public enum NoItemizationType
    {
        FromFileWithMapping,
        SingularDefaultFromConfig
    }

    // Model for global features
    public class IntegrationFeature
    {
        public string Name { get; set; }
        public bool IsEnabled { get; set; }
    }

    // Model for each Required Field
    public class RequiredFieldModel
    {
        public string FieldName { get; set; }
        public MappingDetail Mapping { get; set; } = new MappingDetail();
    }

    // Encapsulates mapping rules for a field
    public class MappingDetail
    {
        public MappingType SelectedType { get; set; } = MappingType.NoMapping;
        public string XSegment { get; set; }
    }

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
}