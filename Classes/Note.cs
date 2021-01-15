using UnityEngine;

public class Note
{
    private readonly float semiToneRatio = 1.05946309436f;

    public float Frequency(int power, int offset)
    {
        float frequency = 220 * Mathf.Pow(semiToneRatio, power);

        if (offset >= 0)
        {
            frequency *= Mathf.Pow(2, offset);
            return frequency;
        }
        else
        {
            offset = Mathf.Abs(offset);
            frequency *= Mathf.Pow(0.5f, offset);
            return frequency;
        }

    }
}
