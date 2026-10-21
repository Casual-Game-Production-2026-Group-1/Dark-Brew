using UnityEngine;

public static class Utilities
{
    // Returns true if the first and second float are within epsilon of each other.
    public static bool IsNear(float first, float second, float epsilon)
    {
        if (Mathf.Abs(first - second) <= epsilon)
        {
            return true;
        }
        return false;
    }

    // Returns true if the first and second Vector2 are within epsilon of each other on each axis.
    public static bool IsNearVector2(Vector2 first, Vector2 second, float epsilon)
    {
        if (Mathf.Abs(first.x - second.x) <= epsilon)
        {
            if (Mathf.Abs(first.y - second.y) <= epsilon)
            {
                return true;
            }
        }
        return false;
    }

    // Returns true if the first and second Vector3 are within epsilon of each other on each axis.
    public static bool IsNearVector3(Vector3 first, Vector3 second, float epsilon)
    {
        if (Mathf.Abs(first.x - second.x) <= epsilon)
        {
            if (Mathf.Abs(first.y - second.y) <= epsilon)
            {
                if (Mathf.Abs(first.z - second.z) <= epsilon)
                {
                    return true;
                }
            }
        }
        return false;
    }
}
