using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Planru.Crosscutting.Adapter.Automapper;
using Planru.Crosscutting.Adapter.Tests.Models;

namespace Planru.Crosscutting.Adapter.Tests.AutomapperTests
{
    [TestClass]
    public class TypeAdapterTests
    {
        ITypeAdapter _typeAdapter;

        [TestInitialize]
        public void Initialize()
        { 
            ITypeAdapterFactory typeAdapterFactory = new AutomapperTypeAdapterFactory();
            TypeAdapterFactory.SetCurrent(typeAdapterFactory);

            _typeAdapter = typeAdapterFactory.Create();
        }

        [TestMethod]
        public void CreateMapTest()
        {
            _typeAdapter.CreateMap<ClassA, ClassB>();

            ClassA source = new ClassA();
            source.A = "A";
            source.B = "B";
            source.C = "C";

            ClassB target = _typeAdapter.Adapt<ClassB>(source);

            Assert.AreEqual(target.A, source.A);
            Assert.AreEqual(target.B, source.B);
            Assert.AreEqual(target.C, source.C);
        }
        
        [TestMethod]
        public void CreateCustomMappingTest()
        {
            _typeAdapter.CreateMap<ClassA, ClassB>()
                .ForMember(d => d.A, m => m.MapFrom(s => s.C))
                .ForMember(d => d.B, m => m.MapFrom(s => s.B))
                .ForMember(d => d.C, m => m.MapFrom(s => s.A));

            ClassA source = new ClassA();
            source.A = "A";
            source.B = "B";
            source.C = "C";

            ClassB target = _typeAdapter.Adapt<ClassB>(source);

            Assert.AreEqual(target.A, source.C);
            Assert.AreEqual(target.B, source.B);
            Assert.AreEqual(target.C, source.A);
        }
    }
}
