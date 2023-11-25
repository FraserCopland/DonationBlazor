
namespace DonationLibrary.Donation;

public class TransactionType
{
    [Key]
    public int TransactionTypeId { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Description { get; set; }
    //updated by system
    public DateTime Created { get; set; }
    public DateTime? Modified { get; set; }
    public string? CreatedBy { get; set; }
    public string? ModifiedBy { get; set; }
}
