// --------------------------------------------------------------------------------
// <copyright filename="CRUDServiceBase.cs" date="12-13-2019">(c) 2019 All Rights Reserved</copyright>
// <author>Oliver Engels</author>
// --------------------------------------------------------------------------------
using EngUtil.EF.CRUDService.Core.Interfaces;

namespace EngUtil.EF.CRUDService.Core.Base
{
    public abstract class CRUDServiceBase<TContext> 
    { 
        protected internal ISessionContext<TContext> SessionContext;

        protected internal string ConnectionString;

        public CRUDServiceBase(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public CRUDServiceBase (ISessionContext<TContext> sessionContext)
        {
            SessionContext = sessionContext;            
        }
    }
}
