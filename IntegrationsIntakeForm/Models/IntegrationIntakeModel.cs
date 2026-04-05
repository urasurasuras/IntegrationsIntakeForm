namespace IntegrationsIntakeForm.Models;

// The full intake form state
public class IntegrationIntakeModel
{
    public List<Feature> Features { get; set; } = 
    [
        new Feature { Name = "Order Creation", IsEnabled = true },
        new Feature { Name = "Update", IsEnabled = true },
        new Feature { Name = "Deletion", IsEnabled = true }
    ];
    public List<RequiredFieldModel> RequiredIdFields { get; set; } =
    [
        new RequiredFieldModel { FieldName = "Account Number" },
        new RequiredFieldModel { FieldName = "Service Type" },
        new RequiredFieldModel { FieldName = "Vehicle Type" },
        new PackageItemization { FieldName = "Package Type" }
    ];    
    // Time Windows Properties
    public string PickupFromDateSource { get; set; } = "FromFile";
    public string PickupFromTimeSource { get; set; } = "FromFile";
    public string PickupToDateSource { get; set; } = "FromFile";
    public string PickupToTimeSource { get; set; } = "FromFile";
    public string DeliveryFromDateSource { get; set; } = "FromFile";
    public string DeliveryFromTimeSource { get; set; } = "FromFile";
    public string DeliveryToDateSource { get; set; } = "FromFile";
    public string DeliveryToTimeSource { get; set; } = "FromFile";
}
