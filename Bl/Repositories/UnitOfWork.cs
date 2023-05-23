using Bl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Repositories
{
     
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GoldenWorkDbContext _context;
    private bool disposed = false;

    public UnitOfWork(GoldenWorkDbContext context)
    {
        _context = context;
    }

    public void Commit()
    {
        _context.SaveChanges();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
        disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
    }

    void IUnitOfWork.CommitAsync()
    {
        throw new NotImplementedException();
    }
}
}
