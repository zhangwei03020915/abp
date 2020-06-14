﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Volo.Abp.Application.Dtos;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace Volo.Abp.Application.Services
{
    public abstract class ReadOnlyAppService<TEntity, TEntityDto, TKey>
        : ReadOnlyAppService<TEntity, TEntityDto, TEntityDto, TKey, PagedAndSortedResultRequestDto>
        where TEntity : class, IEntity<TKey>
        where TEntityDto : IEntityDto<TKey>
    {
        protected ReadOnlyAppService(IRepository<TEntity, TKey> repository) : base(repository)
        {
        }
    }

    public abstract class ReadOnlyAppService<TEntity, TEntityDto, TKey, TGetListInput>
        : ReadOnlyAppService<TEntity, TEntityDto, TEntityDto, TKey, TGetListInput>
        where TEntity : class, IEntity<TKey>
        where TEntityDto : IEntityDto<TKey>
    {
        protected ReadOnlyAppService(IRepository<TEntity, TKey> repository) : base(repository)
        {
        }
    }

    public abstract class ReadOnlyAppService<TEntity, TGetOutputDto, TGetListOutputDto, TKey, TGetListInput>
        : AbstractKeyReadOnlyAppService<TEntity, TGetOutputDto, TGetListOutputDto, TKey, TGetListInput>
        where TEntity : class, IEntity<TKey>
        where TGetOutputDto : IEntityDto<TKey>
        where TGetListOutputDto : IEntityDto<TKey>
    {
        protected new IRepository<TEntity, TKey> Repository { get; }

        protected ReadOnlyAppService(IRepository<TEntity, TKey> repository)
        : base(repository)
        {
            Repository = repository;
        }

        protected override async Task<TEntity> GetEntityByIdAsync(TKey id)
        {
            return await Repository.GetAsync(id);
        }

        protected override IQueryable<TEntity> ApplyDefaultSorting(IQueryable<TEntity> query)
        {
            if (typeof(TEntity).IsAssignableTo<ICreationAuditedObject>())
            {
                return query.OrderByDescending(e => ((ICreationAuditedObject)e).CreationTime);
            }
            else
            {
                return query.OrderByDescending(e => e.Id);
            }
        }
    }
}
