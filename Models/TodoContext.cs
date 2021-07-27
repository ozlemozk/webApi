using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Models
{
    public class TodoContext : DbContext //*databse crud yapmayı sağlar
    {
        public TodoContext(DbContextOptions<TodoContext> options):base (options)
        { }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
