using Domain.Models;
using FinalProject.Controllers;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Controllers;
using System.Reflection;

namespace FinalProject
{
    public class GenericTypeControllerFeatureProvider : IApplicationFeatureProvider<ControllerFeature>
    {
        public void PopulateFeature(IEnumerable<ApplicationPart> parts, ControllerFeature feature)
        {
            var assembly = Assembly.GetAssembly(typeof(EntityBase));
            var types = assembly.GetTypes().Where(s => s.Namespace == typeof(EntityBase).Namespace && !s.Name.Contains("Base")).ToList();

            foreach(var type in types)
            {
                feature.Controllers.Add(typeof(BaseController<>).MakeGenericType(type).GetTypeInfo());
            }
        }
    }
}
