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

        public async Task<List<(string? Candidate, int Votes)>> GetVoteCountsAsync()
        {
            var data = await _db.Polls.GroupBy(p => p.Candidate)
                .Select(g => new
                {
                    Candidate = g.Key,
                    Votes = g.Count()
                })
                .OrderByDescending(g => g.Votes).ThenBy(g => g.Candidate).ToListAsync();
            return data.Select(x => (x.Candidate, x.Votes)).ToList();
        }
    }
}
