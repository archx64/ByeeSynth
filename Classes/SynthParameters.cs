using UnityEngine;

public class SynthParameters : MonoBehaviour
{
    public float attackRate;
    public float decayRate;
    public float sustainRate;
    public float releaseRate;

    public float attackTime;
    public float decayTime;
    public float sustainTime;

    public float attackVolume;
    public float decayVolume;
    public float sustainVolume;

    private void Update()
    {
        //    if(decayVolume > attackVolume)
        //    {
        //        decayVolume = attackVolume;
        //    }

        //    if(sustainVolume > attackVolume)
        //    {
        //        sustainVolume = attackVolume;
        //    }
    }
}
