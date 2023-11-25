

namespace DonationLibrary.Donation;

public class PaymentMethod
{
    [Key]
    public int PaymentMethodId { get; set; }
    [Required]
    public string? Name { get; set; }
    //updated by system
    public DateTime Created { get; set; }
    public DateTime? Modified { get; set; }
    public string? CreatedBy { get; set; }
    public string? ModifiedBy { get; set; }
}
