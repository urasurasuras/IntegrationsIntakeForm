namespace IntegrationsIntakeForm.Models;

// Model for each Required Field
public class RequiredFieldModel
{
    public string FieldName { get; set; } = "";
    public MappingDetail Mapping { get; set; } = new MappingDetail();
}