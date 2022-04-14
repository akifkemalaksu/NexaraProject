using Castle.DynamicProxy;
using NexaraProject.Core.Utilities.Interceptors;
using System;
using System.Transactions;

namespace NexaraProject.Core.Aspects.Transaction
{
    public class TransactionScopeAspect : MethodInterceptionAttribute
    {
        public override void Intercept(IInvocation invocation)
        {
            using (TransactionScope scope = new())
            {
                try
                {
                    invocation.Proceed();
                    scope.Complete();
                }
                catch (Exception e)
                {
                    scope.Dispose();
                    throw e;
                }
            }
        }
    }
}