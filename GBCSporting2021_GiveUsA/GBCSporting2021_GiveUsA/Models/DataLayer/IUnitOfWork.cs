using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_GiveUsA.Models.DataLayer
{
    public interface IUnitOfWork
    {
        public void Save();
    }
}
