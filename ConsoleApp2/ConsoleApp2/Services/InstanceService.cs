using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Services
{
    public class InstanceService
    {
        public IEnumerable<T> GetInstance<T>() where T : class
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in types)
            {
                if (typeof(T).IsAssignableFrom(type) && !type.IsAbstract && type.GetConstructor(Type.EmptyTypes) != null)
                    yield return (T)Activator.CreateInstance(type);
            }
        }
    }
}
