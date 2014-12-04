using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planru.Crosscutting.IoC;
using Planru.Crosscutting.IoC.Unity;

namespace Planru.Crosscutting.IoC.Tests.Tests
{
    public interface ITestService
    { 
        
    }

    public class TestService1 : ITestService
    { 
        
    }

    public class TestService2 : ITestService
    { 
    
    }

    [TestClass]
    public class RegisterAndResolveTypes
    {
        [TestMethod]
        public void RegisterTypes()
        {
            IContainer container = ContainerFactory.CreateContainer();
            container.Register<ITestService, TestService1>();

            var testService = container.Resolve<ITestService>();

            Assert.IsNotNull(testService);
            Assert.IsInstanceOfType(testService, typeof(TestService1));
        }
    }
}
