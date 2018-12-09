using System;
using ArchSample.Application.Base.Interfaces;
using ArchSample.Domain.Base.Abstractions;

namespace ArchSample.Application.Base.Abstractions
{
    public abstract class AppService<TEntity> : IAppService<TEntity> where TEntity : Entity
    {

    }
}
