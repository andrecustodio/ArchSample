using System;
using System.Collections.Generic;
using System.Text;

namespace ArchSample.Domain.Base.Abstractions
{
    public abstract class Entity
    {
        public Guid Id { get; protected internal set; }

        public Entity() { }
        public Entity(Guid guid) { this.Id = guid; }
    }
}
