using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SalesWebMvc.Services
{
    public class SalesRecordService
    {
        private readonly SalesWebMvcContext _context;

        public SalesRecordService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = (IQueryable<SalesRecord>) from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.date <= maxDate.Value);
            }
            return await result
                .Include(x => x.seller)
                .Include(x => x.seller.department)
                .OrderByDescending(x => x.date)
                .ToListAsync();
        }
    }
}
