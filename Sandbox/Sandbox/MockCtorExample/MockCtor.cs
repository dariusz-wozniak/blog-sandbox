namespace Sandbox.MockCtorExample;

public class MockCtor
{
    [Test]
    public void demonstrate_ctor_creation()
    {
        var cls = Create();
        cls.Dep1 = "test";

        cls.Dep1.Should().Be("test");
    }
    
    private static ClassWithDifficultCtorToMock Create() =>
        (ClassWithDifficultCtorToMock)FormatterServices.GetUninitializedObject(typeof(ClassWithDifficultCtorToMock));
}

public class ClassWithDifficultCtorToMock
{
    private ClassWithDifficultCtorToMock(string dep1)
    {
        Dep1 = dep1;
    }
    
    public string Dep1 { get; set; }
}