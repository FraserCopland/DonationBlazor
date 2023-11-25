using DonationLibrary.Data;
using DonationLibrary.Donation;
using Microsoft.EntityFrameworkCore;

namespace ServerBlazorFC;

public class DonationService
{
    private DonationDbContext _context;
    public DonationService(DonationDbContext context)
    {
        _context = context;
    }
    public async Task<List<Donations>> GetDonationsAsync()
    {
        return await _context.Donations.ToListAsync();
    }
    public async Task<Donations> GetDonationAsync(int id)
    {
        return await _context.Donations.FindAsync(id) ?? null!;
    }
    public async Task<Donations> AddDonationAsync(Donations donation)
    {
        _context.Donations.Add(donation);
        await _context.SaveChangesAsync();
        return donation;
    }
    public async Task<Donations> UpdateDonationAsync(Donations donation)
    {
        var donationToUpdate = await _context.Donations!.FindAsync(donation.TransId);
        if (donationToUpdate == null)
        {
            return null!;
        }
        _context.Entry(donation).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return donation;
    }
    public async Task<Donations> DeleteDonationAsync(int id)
    {
        var donation = await _context.Donations!.FindAsync(id);
        if (donation == null)
        {
            return null!;
        }
        _context.Donations.Remove(donation);
        await _context.SaveChangesAsync();
        return donation;
    }
    private bool DonationsExists(int id)
    {
        return _context.Donations.Any(e => e.TransId == id);
    }
    
}
