using UnityEngine;

public class UIManager : MonoBehaviour
{
    private SynthParameters synthParameters;
    private GameObject panel;
    private Vector3 panelPosition;
    private bool movedPanel;

    private void Awake()
    {
        if (synthParameters == null)
        {
            synthParameters = SynthManager.Instance.SynthParameters;
        }

        synthParameters.attackVolume = 0.1f;
        synthParameters.decayVolume = 0.08f;
        synthParameters.sustainVolume = 0.04f;
        synthParameters.attackTime = 0.5f;
        synthParameters.decayTime = 0.2f;
        synthParameters.sustainVolume = 1;
        synthParameters.attackRate = 1;
        synthParameters.decayRate = 1;
        synthParameters.sustainRate = 0.2f;
        panel = GameObject.FindWithTag("Panel");
    }


    public void MovePanel()
    {
        movedPanel = !movedPanel;
    }


    private void LerpPanel()
    {

        if (!panel)
        {
            return;
        }

        if (movedPanel)
        {
            panelPosition = Vector3.Lerp(panelPosition, Vector3.up * 500, 5 * Time.deltaTime);
            panel.transform.localPosition = panelPosition;
        }
        else
        {
            panelPosition = Vector3.Lerp(panelPosition, Vector3.zero, 5 * Time.deltaTime);
            panel.transform.localPosition = panelPosition;
        }
    }


    private void Update()
    {
        LerpPanel();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
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

    public void SetWaveType(float type)
    {
        synthParameters.waveType = Mathf.RoundToInt(type);
    }
}
