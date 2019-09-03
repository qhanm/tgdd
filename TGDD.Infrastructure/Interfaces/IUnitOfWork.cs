using System;
using System.Collections.Generic;
using System.Text;

namespace TGDD.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
