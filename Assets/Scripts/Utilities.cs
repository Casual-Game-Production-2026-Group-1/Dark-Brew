using TMPro;
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

    public static void PlayOneShotRandomPitch(AudioSource audioSource, AudioClip audioClip, float pitchVariance = 0.15f, bool compound = false)
    {
        float pitch = 1.0f;

        // Compound makes it base the new random pitch off of the current pitch
        if (compound)
        {
            pitch = audioSource.pitch;
        }
        
        float randomPitch = Random.Range(pitch - pitchVariance, pitch + pitchVariance);

        audioSource.pitch = randomPitch;
        audioSource.PlayOneShot(audioClip);
    }
}
