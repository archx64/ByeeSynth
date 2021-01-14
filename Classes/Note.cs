using UnityEngine;

public class Note
{
    private readonly float semiToneRatio = Mathf.Pow(2, 1 / 12);

    public float Frequency(int power)
    {
        
        return 440 * Mathf.Pow(semiToneRatio, power);
    }
}
