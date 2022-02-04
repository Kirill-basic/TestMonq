using System;
using System.Collections.Generic;
using DataLayer.Models;

namespace DataLayer.Repository
{
    public interface ILogRepository
    {
        public IEnumerable<Log> GetLogs();

    }
    
    public class LogRepository : ILogRepository
    {
        public IEnumerable<Log> GetLogs()
        {
            Console.Write("Hello world from logs");
            return new List<Log>();
        }
    }
}