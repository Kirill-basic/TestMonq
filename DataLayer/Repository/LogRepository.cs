using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repository
{
    public interface ILogRepository
    {
        public Task<IEnumerable<Log>> GetLogs();
        
        public Task PostLog(Log log);
    }

    
    public class LogRepository : ILogRepository
    {
        private readonly ApplicationDbContext _context;

        public LogRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<IEnumerable<Log>> GetLogs()
        {
            var logs = await _context.Logs.ToListAsync();
            return logs;
        }
        
        public async Task PostLog(Log log)
        {
            _context.Add(log);
            await _context.SaveChangesAsync();
        }
    }
}