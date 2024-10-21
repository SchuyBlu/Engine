using Engine.Vectors;
namespace Engine.UnitTests.Vectors;

[TestClass]
public class Vec3DTests
{
    [TestMethod]
    public void Should_Give_Correct_Length()
    {
        Vec3D vec = new(2.123, 8.182, 9.128);

        decimal difference = (decimal)(vec.GetLength() - 12.4407651292);
        Assert.IsTrue(difference < 0.00001M);
    }

	[TestMethod]
	public void Should_Normalize_Correctly()
	{
		Vec3D vec1 = new(2.0, 2.0, 1.0);
		
		Vec3D result1 = vec1.Normalize();

		Assert.IsTrue(result1.GetX() - 0.666666666 < 0.00001D);
		Assert.IsTrue(result1.GetY() - 0.666666666 < 0.00001D);
		Assert.IsTrue(result1.GetZ() - 0.333333333 < 0.00001D);
	}

	[TestMethod]
	public void Should_Add_Vectors_Correctly()
	{
		Vec3D vec1 = new(2.0, 3.0, 5.0);
		Vec3D vec2 = new(1.0, 2.0, 7.0);

		Vec3D result = vec1.Add(vec2); // (3.0, 5.0, 12.0)

		Assert.AreEqual(3.0, result.GetX());
		Assert.AreEqual(5.0, result.GetY());
		Assert.AreEqual(12.0, result.GetZ());
	}

	[TestMethod]
	public void Should_Sub_Vectors_Correctly()
	{
		Vec3D vec1 = new(2.0, 3.0, 5.0);
		Vec3D vec2 = new(1.0, 2.0, 7.0);

		Vec3D result = vec1.Sub(vec2);

		Assert.AreEqual(1.0, result.GetX());
		Assert.AreEqual(1.0, result.GetY());
		Assert.AreEqual(-2.0, result.GetZ());
	}

	[TestMethod]
	public void Should_Dot_Product_Correctly()
	{
		Vec3D vec1 = new(2.0, 3.0, 5.0);
		Vec3D vec2 = new(1.0, 2.0, 7.0);

		double result = vec1.Dot(vec2);
		/*
		 * 2.0 * 1.0 = 2.0
		 * 3.0 * 2.0 = 6.0
		 * 5.0 * 7.0 = 35.0
		 * ----------------
		 *             43.0
		 */

		Assert.AreEqual(43.0, result);
	}

	[TestMethod]
	public void Should_Cross_Product_Correctly()
	{
		Vec3D vec1 = new(2.0, 3.0, 5.0);
		Vec3D vec2 = new(1.0, 2.0, 7.0);

		Vec3D result = vec1.Cross(vec2);

		Assert.AreEqual(11.0, result.GetX());
		Assert.AreEqual(-9.0, result.GetY());
		Assert.AreEqual(1.0, result.GetZ());
	}
}
