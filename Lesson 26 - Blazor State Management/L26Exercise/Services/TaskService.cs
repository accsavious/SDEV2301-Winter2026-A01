using L26Exercise.Data;
using L26Exercise.Models;
using Microsoft.EntityFrameworkCore;

namespace L26Exercise.Services
{
    public class TaskService
    {
        private readonly AppDbContext _db;

        public TaskService(AppDbContext db)
        {
            _db = db;
        }
        
        public async Task<TaskItem> AddTaskAsync(TaskItem? t)
        {
            ArgumentNullException.ThrowIfNull(t);

            _db.TaskItems.Add(t);
            await _db.SaveChangesAsync();
            return t;
        }

        public async Task<TaskItem> UpdateItemAsnyc(TaskItem? t)
        {

            ArgumentNullException.ThrowIfNull(t);
            _db.TaskItems.Update(t);
            await _db.SaveChangesAsync();
            return t;
        }

        public async Task DeleteTaskAsync(int id)
        {
            TaskItem? task = await _db.TaskItems.FindAsync(id);
            if (task == null) throw new KeyNotFoundException($"No item with id {id}");

            _db.TaskItems.Remove(task);
            await _db.SaveChangesAsync();
        }
    }
}
