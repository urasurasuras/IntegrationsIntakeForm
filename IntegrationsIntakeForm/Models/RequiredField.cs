namespace IntegrationsIntakeForm.Models;

public class RequiredField
{
    public string FieldName { get; set; } = "";
    public MappingDetail Mapping { get; set; } = new MappingDetail();
}