using Microsoft.VisualStudio.TestTools.UnitTesting;
using Planru.Crosscutting.IoC;
using Planru.Crosscutting.IoC.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Planru.Crosscutting.IoC.Tests.Initializers
{
    [TestClass]
    public class TestInitialize
    {
        [AssemblyInitialize]
        public static void InitializeFactories(TestContext context)
        {
            IContainerFactory unityContainerFactory = new UnityContainerFactory();
            ContainerFactory.SetCurrent(unityContainerFactory);
        }            
    }
}
