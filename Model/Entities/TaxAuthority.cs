namespace Model.Entities;

public class TaxAuthority
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public int ParentId { get; set; }
    public int Level { get; set; }
    public string LevelPath { get; set; } = string.Empty;
    public virtual ICollection<Customer> Customers { get; set; } = new HashSet<Customer>();
}