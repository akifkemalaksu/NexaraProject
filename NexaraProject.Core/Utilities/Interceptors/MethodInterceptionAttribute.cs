using Castle.DynamicProxy;

namespace NexaraProject.Core.Utilities.Interceptors
{
    public class MethodInterceptionAttribute : MethodInterceptionBaseAttribute
    {
        public override void Intercept(IInvocation invocation)
        {
            bool successFlag = true;

            OnBefore(invocation);

            try
            {
                invocation.Proceed();
            }
            catch (Exception ex)
            {
                OnException(invocation, ex);
                throw;
            }
            finally
            {
                if (successFlag)
                {
                    OnSuccess(invocation);
                }
            }

            OnAfter(invocation);
        }

        public virtual void OnBefore(IInvocation invocation)
        { }

        public virtual void OnAfter(IInvocation invocation)
        { }

        public virtual void OnSuccess(IInvocation invocation)
        { }

        public virtual void OnException(IInvocation invocation, Exception exception)
        { }
    }
}