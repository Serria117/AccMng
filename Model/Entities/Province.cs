namespace Model.Entities;

public class Province
{
    public int Id { get; set; }
    public string ProvinceName { get; set; } = string.Empty;
    public string ProvinceCode { get; set; } = string.Empty;

    public virtual ICollection<District> Districts { get; set; } = new HashSet<District>();
 }