namespace IntegrationsIntakeForm.Models;

// Encapsulates mapping rules for a field
public class MappingDetail
{
    public MappingType SelectedType { get; set; } = MappingType.NoMapping;
    public string XSegment { get; set; }
}