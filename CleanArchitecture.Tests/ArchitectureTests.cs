using NUnit.Framework;
using Is = ArrowAsserts.Is;

namespace CleanArchitecture.Tests
{
    [TestFixture]
    public class ArchitectureTests
    {
        [Test]
        public void UI_Does_Not_Reference_Infrastructure()
        {
            Assert.That("CleanArchitecture.UI", Is.Not.Referencing("CleanArchitecture.Infrastructure"), 
                "The UI Project should not have direct knowledge of Data Persistence." +
                "You may want to consider adding an interface in Core for whatever you need, and" +
                "Binding your interface to the concrete implementation found in Infrastructure." +
                "That way, your UI depends on the abstraction and not the implementation.");
        }

        [Test]
        public void UI_Is_Not_Coupled_To_IoC_Implementation()
        {
            Assert.That("CleanArchitecture.UI", Is.Not.Referencing("Ninject"),
                "Inversion of Control should be delegated away from the UI.  The IoC project should be " +
                "the only project with direct knowledge of HOW IoC is handled.  Obviously, the UI project " +
                "needs to utilize the IoC container - which is fine - but it shouldn't know the details of " +
                "how that's done."); 
        }

        [Test]
        public void UI_Is_Not_Coupled_To_Data_Persistence_Implementation()
        {
            Assert.That("CleanArchitecture.UI", Is.Not.Referencing("EntityFramework"),
                "Implementation details of how data is persisted and retriever should be delegated away from the UI. " +
                "The Infrastructure project is responsible for knowing that.  Other projects depend on the abstractions, " +
                "but not the details.  EntityFramework is a detail that should not leak out of that project.");
        }
    }
}
