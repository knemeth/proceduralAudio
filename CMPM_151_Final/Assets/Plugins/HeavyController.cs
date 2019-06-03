using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyController : MonoBehaviour
{
    public float tone = 1;
    private Hv_HeavyDemo_AudioLib HeavyScript;

    private float onOff = 1;
    private float freq = 314;
    // Start is called before the first frame update
    void Start()
    {
        HeavyScript = GameObject.Find("HeavyController").GetComponent<Hv_HeavyDemo_AudioLib>();
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        HeavyScript.SendFloatToReceiver("waveToggle", tone);
    }
}
