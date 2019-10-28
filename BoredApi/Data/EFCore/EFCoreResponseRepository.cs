using BoredDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoredApi.Data.EFCore
{
    public class EFCoreResponseRepository : EFCoreRepository<Response, BoredDbContext>
    {
        public EFCoreResponseRepository(BoredDbContext context) : base(context)
        {

        }

    }
}
