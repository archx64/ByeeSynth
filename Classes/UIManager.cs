using UnityEngine;

public class UIManager : MonoBehaviour
{
    private SynthParameters synthParameters;

    private void Awake()
    {
        synthParameters = SynthManager.Instance.SynthParameters;
        synthParameters.attackVolume = 0.1f;
        synthParameters.decayVolume = 0.08f;
        synthParameters.sustainVolume = 0.04f;
        synthParameters.attackTime = 0.5f;
        synthParameters.decayTime = 0.2f;
        synthParameters.sustainVolume = 1;
        synthParameters.attackRate = 1;
        synthParameters.decayRate = 1;
        synthParameters.sustainRate = 0.2f;
    }

    private void Start()
    {

    }

    public void SetAttackRate(float rate)
    {
        synthParameters.attackRate = rate;
    }

    public void SetDecayRate(float rate)
    {
        synthParameters.decayRate = rate;
    }

    public void SetSustainRate(float rate)
    {
        synthParameters.sustainRate = rate;
    }

    public void SetAttackTime(float milliSecond)
    {
        synthParameters.attackTime = milliSecond;
    }

    public void SetDecayTime(float milliSecond)
    {
        synthParameters.decayTime = milliSecond;
    }

    public void SetSustainTime(float milliSecond)
    {
        synthParameters.decayTime = milliSecond;
    }

    public void SetReleaseRate(float rate)
    {
        synthParameters.releaseRate = rate;
    }

    public void SetAttackVolume(float volume)
    {
        synthParameters.attackVolume = volume;
    }

    public void SetDecayVolume(float volume)
    {
        synthParameters.decayVolume = volume;
    }

    public void SetSustainVolume(float volume)
    {
        synthParameters.sustainVolume = volume;
    }
}
