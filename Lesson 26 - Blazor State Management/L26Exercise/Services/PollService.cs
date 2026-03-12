using L26Exercise.Data;
using L26Exercise.Models;
using Microsoft.EntityFrameworkCore;

namespace L26Exercise.Services
{
    public class PollService
    {
        private readonly AppDbContext _db;

        public PollService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<List<Poll>> ListPollsAsync()
        {
            return await _db.Polls.OrderBy(p => p.Name).ToListAsync();
        }

        public async Task<Poll> AddPollAsync(Poll? p)
        {

            ArgumentNullException.ThrowIfNull(p);

            _db.Polls.Add(p);
            await _db.SaveChangesAsync();
            return p;
        }

        public async Task<List<(string? Candidate, int Votes)>> GetVoteCounts()
        {
            return await _db.Polls.GroupBy(p => p.Candidate)
                .Select(g => new ValueTuple<string?, int>(
                    g.Key,
                    g.Count()))
                .OrderByDescending(g => g.Item2).ThenBy(g => g.Item1).ToListAsync();
        }
    }
}
