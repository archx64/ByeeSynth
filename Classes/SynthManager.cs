
using UnityEngine;

public class SynthManager
{
    private GameObject gameObject;

    private static SynthManager m_Instance;

    public static SynthManager Instance
    {
        get
        {
            if (m_Instance == null)
            {
                m_Instance = new SynthManager
                {
                    gameObject = new GameObject("SynthManager")
                };

                m_Instance.gameObject.AddComponent<SynthParameters>();
            }
            return m_Instance;
        }
    }

    private SynthParameters m_SyntheParameters;
    public SynthParameters SynthParameters
    {
        get
        {
            if(m_SyntheParameters == null)
            {
                m_SyntheParameters = gameObject.GetComponent<SynthParameters>();
            }
            return m_SyntheParameters;
        }
    }

}
