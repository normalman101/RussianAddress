namespace Address.Core;

public class Address
{
    public FederalSubjectType SubjectType { get; set; }
    public string? District { get; set; }
    public string? Settlement { get; set; }
    public string? Locality { get; set; }
    public string? CityDistrict { get; set; }
    public string? PlanningElement { get; set; }
    public StreetType? Street { get; set; }
    public string? LandPlot { get; set; }
    public BuildingType? Building { get; set; }
    public string? Room { get; set; }
    public Address() {}
}