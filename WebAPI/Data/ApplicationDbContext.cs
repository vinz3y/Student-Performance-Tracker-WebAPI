using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext( DbContextOptions options ) : base( options ) 
        {
            
        }
        public DbSet<StudySession> StudySessions { get; set; }
        public DbSet<BreakSession> BreakSessions { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
