
namespace DonationLibrary.Donation;

public class Contact
{
    [Key]
    public int AccoutNo { get; set; }
    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? LastName { get; set; }
    [Required]
    public string? Email { get; set; }
    [Required]
    public string? Street { get; set; }
    [Required]
    public string? City { get; set; }
    [Required]
    public string? PostalCode { get; set; }
    [Required]
    public string? Country { get; set; }
    
    //updated by system
    public DateTime Created { get; set; }
    public DateTime? Modified { get; set; }
    public string? CreatedBy { get; set; }
    public string? ModifiedBy { get; set; }
}