using System.Collections.Generic;
using System.Linq;

namespace Wiz.Template.Infra.Context
{
    public class EntityContextSeed
    {
        private readonly EntityContext _context;

        public EntityContextSeed(EntityContext context)
        {
            this._context = context;
            this.SeedInitial();
        }

        public void SeedInitial()
        {
        }
    }
}
