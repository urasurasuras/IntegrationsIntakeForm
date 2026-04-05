namespace IntegrationsIntakeForm.Models;

public class MappingEntry(string Key, string Value)
{
    public string Key { get; set; } = Key;
    public string Value { get; set; } = Value;
}
