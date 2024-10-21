using System;

namespace Engine.Vectors;

public class Vec3D
{
    private double x, y, z;

    public Vec3D(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

	public double GetX()
	{
		return this.x;
	}

	public double GetY()
	{
		return this.y;
	}

	public double GetZ()
	{
		return this.z;
	}

    public override string ToString()
    {
        return $"X: {this.x}, Y: {this.y}, Z: {this.z}";
    }

    public double GetLength()
    {
        double sum = Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2);
        return Math.Sqrt(sum);
    }

	public Vec3D Normalize()
	{
		double x = this.x / this.GetLength();
		double y = this.y / this.GetLength();
		double z = this.z / this.GetLength();

		return new Vec3D(x, y, z);
	}

	public Vec3D Add(Vec3D other)
	{
		double x = this.x + other.GetX();
		double y = this.y + other.GetY();
		double z = this.z + other.GetZ();

		return new Vec3D(x, y, z);
	}

	public Vec3D Sub(Vec3D other)
	{
		double x = this.x - other.GetX();
		double y = this.y - other.GetY();
		double z = this.z - other.GetZ();

		return new Vec3D(x, y, z);
	}

	public double Dot(Vec3D other)
	{
		double rx = this.x * other.GetX();
		double ry = this.y * other.GetY();
		double rz = this.z * other.GetZ();

		return rx + ry + rz;
	}

	public Vec3D Cross(Vec3D other)
	{
        //         |  i   j   k |
        // A x B = | ax  ay  az |
        //         | bx  by  bz |
        //     | ay az |     | ax az |     | ax ay |
        // = i | by bz | - j | bx bz | + k | bx by |
		//
		// Get determinant via ad - bc

		double i = (this.y * other.GetZ()) - (this.z * other.GetY());
		double j = -((this.x * other.GetZ()) - (this.z * other.GetX()));
		double k = (this.x * other.GetY()) - (this.y * other.GetX());

		return new Vec3D(i, j, k);
	}
}
