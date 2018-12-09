using System;
using System.Collections.Generic;
using System.Text;

namespace ArchSample.Domain.Base.Abstractions
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
    }
}
