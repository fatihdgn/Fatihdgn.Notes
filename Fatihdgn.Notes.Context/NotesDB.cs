using Fatihdgn.Notes.Context.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fatihdgn.Notes.Context;

public class NotesDB : DbContext
{
    public NotesDB(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Note> Notes { get; set; }
}