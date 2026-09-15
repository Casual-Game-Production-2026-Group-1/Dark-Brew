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
}
