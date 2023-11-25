

namespace DonationLibrary.Donation;

public class Donations
{
    [Key]
    public int TransId { get; set; }
    [Required]
    public DateTime Date { get; set; }
    [Required]
    public int AccountNo { get; set; }
    [ForeignKey("TransactionType")]
    [Required]
    public int TransactionTypeId { get; set; }
    [Required]
    public float Amount { get; set; }
    [ForeignKey("PaymentMethod")]
    [Required]
    public int PaymentMethodId { get; set; }
    [Required]
    public string? Notes { get; set; }
    //updated by system
    public DateTime Created { get; set; }
    public DateTime? Modified { get; set; }
    public string? CreatedBy { get; set; }
    public string? ModifiedBy { get; set; }
}
