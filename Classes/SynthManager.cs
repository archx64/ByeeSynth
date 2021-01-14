using UnityEngine;

public class SynthManager : MonoBehaviour
{
    protected float attackRate;
    protected float decayRate;
    protected float sustainRate;
    protected float releaseRate;

    protected float attackVolume;
    protected float decayVolume;
    protected float sustainVolume;

    public void SetAttackRate(float rate)
    {
        attackRate = rate;
    }

    public void SetDecayRate(float rate)
    {
        decayRate = rate;
    }

    public void SetSustainRate(float rate)
    {
        sustainRate = rate;
    }

    public void SetReleaseRate(float rate)
    {
        releaseRate = rate;
    }

    public void SetAttackVolume(float volume)
    {
        attackVolume = volume;
    }

    public void SetDecayVolume(float volume)
    {
        decayVolume = volume;
    }

    public void SetSustainVolume(float volume)
    {
        sustainVolume = volume;
    }
}
