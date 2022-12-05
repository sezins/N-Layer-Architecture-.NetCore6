using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.UnitOfWorks
{
    public interface IUnitofWork
    {
        //Dncontextsavechange and savechangeAsync
        Task CommitAsync();
        void Commit();
    }
}
