using System;

namespace Engine.Vectors;

public class Vec3D
{
    double x, y, z;

    public Vec3D(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public override string ToString()
    {
        return $"X: {this.x}, Y: {this.y}, Z: {this.z}";
    }

    public double GetMagnitude()
    {
        double sum = Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2);
        return Math.Sqrt(sum);
    }
}
