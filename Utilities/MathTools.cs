using FlaxEngine;

namespace Utilities;

public class MathTools
{
    public static float Magnitude(Vector3 vec3) //Unity-like vector3 magnitude
    {
        return float.Sqrt((vec3.X * vec3.X) + (vec3.Y * vec3.Y) + (vec3.Z * vec3.Z));
    }
}
