using System;
using System.Collections.Generic;
using System.Linq;

namespace IoCFirstPrinciples.App
{
    public class AutomaticFactory
    {
        public static object GimmiOne(Type type)
        {
            var constructor = type.GetConstructors().Single();
            var parameters = constructor.GetParameters();

            if (!parameters.Any())
                return Activator.CreateInstance(type);

            var args = new List<object>();
            foreach (var parameter in parameters)
            {
                var arg = Activator.CreateInstance(parameter.ParameterType);
                args.Add(args);
            }

            var result = Activator.CreateInstance(type, args);
            return Activator.CreateInstance(type);
        }
    }
}