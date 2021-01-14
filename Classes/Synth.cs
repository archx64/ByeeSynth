using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Synth : SynthManager
{
    private readonly int samplingFrequency = 48000;
    private float increment;
    private float phase;
    private float notePressedTime;

    [SerializeField] int wavetype = 0;

    private  float gain = 0f;

    private readonly Note note = new Note();
    private readonly Envelope envelope = new Envelope();

    private void FixedUpdate()
    {
        bool isPlaying = Input.GetKey(KeyCode.Space);
        Debug.Log(notePressedTime);
        if (isPlaying)
        {
            notePressedTime += Time.deltaTime;
            gain = envelope.ADSR(0.1f, 0.08f, 0.04f, 0.5f, 0.2f, 1, 1, 1, 0.2f, notePressedTime, gain);
        }
        else
        {
            notePressedTime = 0;
            gain = envelope.Release(gain, 2);
        }
    }


    private void OnAudioFilterRead(float[] data, int channels)
    {
        increment = note.Frequency(0) * 2 * Mathf.PI / samplingFrequency;

        for (int i = 0; i < data.Length; i += channels)
        {
            phase += increment;

            switch (wavetype)
            {
                case 0:
                    data[i] = gain * Mathf.Sin(phase);
                    break;

                case 1:
                    if (gain * Mathf.Sin(phase) >= 0 * gain)
                    {
                        data[i] = gain * 0.5f;
                    }
                    else
                    {
                        data[i] = -gain * 0.5f;
                    }
                    break;

                case 2:
                    data[i] = gain * Mathf.PingPong(phase, 1);
                    break;

                default:
                    break;
            }

            if (channels == 2)
            {
                data[i + 1] = data[i];
            }

            if (phase > Mathf.PI * 2)
            {
                phase = 0;
            }
        }
    }
}
