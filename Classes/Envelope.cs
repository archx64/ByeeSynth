using UnityEngine;

public class Envelope
{
    public float ADSR(float maxAmp, float decayAmp, float susAmp, float at, float dt, float st, float ar, float dr, float sr, float t, float amp)
    {
        if (t <= at)
        {
            // Attack
            amp = Mathf.Lerp(amp, maxAmp, ar * Time.deltaTime);
        }
        else if (t > at && t < (at + dt))
        {
            // Decay
            amp = Mathf.Lerp(amp, decayAmp, dr * Time.deltaTime);
        }
        else if (t >= (at + dt) && t < (at + dt + st))
        {
            // Sustain
            amp = Mathf.Lerp(amp, susAmp, sr * Time.deltaTime);
        }
        else //if (t >= (at + dt + st))
        {
            amp = Mathf.Lerp(amp, 0, sr * Time.deltaTime);
        }
        return amp;
    }

    public float Release(float amp, float rr)
    {
        amp = Mathf.Lerp(amp, 0, rr * Time.deltaTime);
        return amp;
    }
}
