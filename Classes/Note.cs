using UnityEngine;

public class Note
{
    public float Frequency(int power)
    {
        return 440 * Mathf.Pow(1.0594630943593f, power);
    }
}
