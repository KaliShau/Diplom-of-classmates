using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using EduManage.Shared;
using EduManage.Shared.Main;
using Microsoft.Extensions.DependencyInjection;

namespace EduManage
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            var assembly = Assembly.GetExecutingAssembly();

            assembly.GetTypes()
                .Where(t => t.Name.EndsWith("Controller") && !t.IsAbstract)
                .ToList()
                .ForEach(type => services.AddTransient(type));

            assembly.GetTypes()
                .Where(t => t.Name.EndsWith("Service") && !t.IsAbstract)
                .ToList()
                .ForEach(type => services.AddSingleton(type));

            assembly.GetTypes()
                .Where(t => t.IsSubclassOf(typeof(Form)) && !t.IsAbstract)
                .ToList()
                .ForEach(type => services.AddTransient(type));

            services.AddSingleton<FormManager>();
            services.AddSingleton<DatabaseRepository>();
            services.AddSingleton<Context>();

            var provider = services.BuildServiceProvider();

            var formManager = provider.GetRequiredService<FormManager>();
            var homeForm = provider.GetRequiredService<HomeForm>();

            Application.Run(homeForm);
        }
    }
}
