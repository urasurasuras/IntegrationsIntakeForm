namespace IntegrationsIntakeForm.Models;

public class MappingDetail
{
    public MappingType SelectedType { get; set; } = MappingType.NoMapping;
    public string XSegment { get; set; } = string.Empty;
    
    // For "No mapping"
    public string SingleValue { get; set; } = string.Empty;

    // For "One-to-one"
    public List<MappingEntry> OneToOneMappings { get; set; } = new();
}
