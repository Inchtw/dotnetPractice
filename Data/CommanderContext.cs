using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data
{
    public class CommanderContext : DbContext
    {
        //ctor 簡寫去新增
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {

        }
        // prop 簡寫新增
        public DbSet<Command> Commands { get; set; }

    }
}