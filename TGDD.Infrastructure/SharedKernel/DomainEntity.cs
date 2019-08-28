using System;
using System.Collections.Generic;
using System.Text;

namespace TGDD.Infrastructure.SharedKernel
{
    public abstract class DomainEntity<T>
    {
        public T Id { get; set; }
    }
}
