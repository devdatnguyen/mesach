﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeSachBlog.Data
{
    public class MeSachContextFactory : IDesignTimeDbContextFactory<MeSachContext>
    {
        public MeSachContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<MeSachContext>();
            builder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            return new MeSachContext(builder.Options);
        }
    }
}
