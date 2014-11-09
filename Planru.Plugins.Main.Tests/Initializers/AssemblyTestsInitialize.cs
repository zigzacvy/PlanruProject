using Microsoft.VisualStudio.TestTools.UnitTesting;
using Planru.Crosscutting.Adapter;
using Planru.Crosscutting.NetFramework.Adapter;
using Planru.Plugins.Main.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Planru.Plugins.Main.Tests.Initializers
{
    [TestClass]
    public class AssemblyTestsInitialize
    {
        [AssemblyInitialize]
        public static void InitializeFactories(TestContext context)
        {
            Assembly.Load("Planru.Plugins.Main");
            ITypeAdapterFactory adapterfactory = new AutomapperTypeAdapterFactory();
            TypeAdapterFactory.SetCurrent(adapterfactory);
        }
    }
}
