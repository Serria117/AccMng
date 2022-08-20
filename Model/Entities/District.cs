namespace Model.Entities;

public class District
{
    public int Id { get; set; }
    public string DistrictName { get; set; } = string.Empty;
    public string DistrictCode { get; set; } = string.Empty;
    public int ProvinceId { get; set; }
    public virtual Province Province { get; set; } = new Province();
}