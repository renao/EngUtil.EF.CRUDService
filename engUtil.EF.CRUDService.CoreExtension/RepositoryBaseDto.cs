// --------------------------------------------------------------------------------
// <copyright filename="RepositoryBaseDto.cs" date="12-13-2019">(c) 2019 All Rights Reserved</copyright>
// <author>Oliver Engels</author>
// --------------------------------------------------------------------------------
using System;
using System.Linq.Expressions;
using EngUtil.Dto;
using Microsoft.EntityFrameworkCore;

namespace EngUtil.EF.CRUDService.Core
{
    public abstract class RepositoryDto<TDbContext, TEntity, TModel> : Repository<TDbContext, TEntity, TModel>
        where TDbContext : DbContext
        where TEntity : class
        where TModel : class
    {   
        protected RepositoryDto(ISessionContext<TDbContext> contextService) 
            : base(contextService)
        {
        }

        protected RepositoryDto(ISessionContext<TDbContext> contextService, IMapper dtoMapper) 
            : base(contextService)
        {
            AsEntityExpression = (Expression<Func<TModel, TEntity>>)dtoMapper.GetExpressionMap(typeof(TModel), typeof(TEntity));
            AsModelExpression = (Expression<Func<TEntity, TModel>>)dtoMapper.GetExpressionMap(typeof(TEntity), typeof(TModel));
            if (AsEntityExpression == null 
                || AsModelExpression == null)
                dtoMapper.GetMapDefinition(this);
        }

        protected RepositoryDto(DbContextOptions<TDbContext> contextOptions) 
            : base(contextOptions)
        {
        }

        protected RepositoryDto(DbContextOptions<TDbContext> contextOptions, IMapper dtoMapper)
            : base(contextOptions)
        {
            AsEntityExpression = (Expression<Func<TModel, TEntity>>)dtoMapper.GetExpressionMap(typeof(TModel), typeof(TEntity));
            AsModelExpression = (Expression<Func<TEntity, TModel>>)dtoMapper.GetExpressionMap(typeof(TEntity), typeof(TModel));
            if (AsEntityExpression == null
                || AsModelExpression == null)
                dtoMapper.GetMapDefinition(this);
        }
    }
}
