namespace GeoShared.Main.Configuration;

public abstract class DbInjection
{
    protected readonly AppDbContext _context;

    public DbInjection(AppDbContext context) 
    { 
        this._context = context;
    }
}
