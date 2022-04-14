using Castle.DynamicProxy;
using System.Reflection;

namespace NexaraProject.Core.Utilities.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>(true).ToList();

            var methodAttributes = type.GetMethod(method.Name).GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            if (methodAttributes != null)
            {
                classAttributes.AddRange(methodAttributes);
            }

            return classAttributes.OrderBy(a => a.Priority).ToArray();
        }
    }
}