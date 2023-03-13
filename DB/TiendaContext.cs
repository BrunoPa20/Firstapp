using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class TiendaContext : DbContext
    {
      public TiendaContext(DbContextOptions<TiendaContext> options)
             :base(options)
        {

        }

    }
}