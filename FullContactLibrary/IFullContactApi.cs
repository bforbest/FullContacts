using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullContactLibrary
{
    public interface IFullContactApi
    {
        Task<FullContactPerson> LookupPersonByEmailAsync(string email);
    }
}
