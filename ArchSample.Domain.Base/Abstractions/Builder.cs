using System;
using System.Collections.Generic;
using System.Text;

namespace ArchSample.Domain.Base.Abstractions
{
    public abstract class Builder<TObject>
    {
        public abstract TObject BuildObject();
    }
}
