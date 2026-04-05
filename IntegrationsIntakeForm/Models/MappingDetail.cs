namespace IntegrationsIntakeForm.Models;

public class MappingDetail
{
    public MappingType SelectedType { get; set; } = MappingType.NoMapping;
    public string XSegment { get; set; } = string.Empty;
    
    public string SingleValue { get; set; } = string.Empty;

    public List<MappingEntry> OneToOneMappings { get; set; } = new();
}
