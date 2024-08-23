using Engine.Vectors;
namespace Engine.UnitTests.Vectors;

[TestClass]
public class Vec3DTests
{
    [TestMethod]
    public void Should_Give_Correct_Magnitude()
    {
        Vec3D vec = new(2.123, 8.182, 9.128);

        decimal difference = (decimal)(vec.GetMagnitude() - 12.4407651292);
        Assert.IsTrue(difference < 0.00001M);
    }
}