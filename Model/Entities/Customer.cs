using System.ComponentModel.DataAnnotations;

namespace Model.Entities;

public class Customer
{
    [Key]
    public Guid Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string MemoName { get; set; } = string.Empty;
    public string TaxCode { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public int DistrictId { get; set; }
    public int ProvinceId { get; set; }
    public int TaxAuthorityId { get; set; }
    public virtual TaxAuthority TaxAuthority { get; set; } = new TaxAuthority();
    public int ParentTaxAuthorityId { get; set; }

    public bool FdiInvestment { get; set; } = false;
    public bool MonthlyTaxPeriod { get; set; }
    public int BusinessType { get; set; }
    public string MainBusiness { get; set; } = string.Empty;
    public int StartYear { get; set; }

    public DateTime CreateDate { get; set; }
    public DateTime? EndDate { get; set; }
}