﻿using Microsoft.EntityFrameworkCore;
using Portfolio.Interfaces;
using Portfolio.Models;
using Portfolio.Repositories.Data;

namespace Portfolio.Repositories
{
    public class HomeRepo(PortfolioDbContext context) : IHomeRepo
    {
        private readonly PortfolioDbContext _context = context;

        public async Task<int?> GetUnreadMessagesCountAsync()
        {
            return await _context.CONTACTS.Where(x => x.IsConfirmed == null || x.IsConfirmed == 0).CountAsync();
        }
    }
}