namespace IntegrationsIntakeForm.Models;

public class PackageItemization : RequiredFieldModel
{
    public bool EnableItemization { get; set; } = false;
    public NoItemizationType NoItemizationSubOption { get; set; } = NoItemizationType.FromFileWithMapping;
    public string ItemizedRefNoMapping { get; set; } = string.Empty;
}
