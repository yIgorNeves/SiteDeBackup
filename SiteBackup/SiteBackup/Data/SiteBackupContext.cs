using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SiteBackup.Models;

namespace SiteBackup.Data
{
    public class SiteBackupContext : DbContext
    {
        public SiteBackupContext (DbContextOptions<SiteBackupContext> options)
            : base(options)
        {
        }

        public DbSet<SiteBackup.Models.File> File { get; set; }
    }
}
