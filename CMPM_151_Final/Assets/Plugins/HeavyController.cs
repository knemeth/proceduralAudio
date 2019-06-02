using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyController : MonoBehaviour
{ 
    private Hv_HeavyDemo_AudioLib HeavyScript;
    private float onOff = 1;
    private float freq = 314;
    // Start is called before the first frame update
    void Start()
    {
        HeavyScript = GetComponent<Hv_HeavyDemo_AudioLib>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")) {
            print(onOff);
            if(onOff == 0)
            {
                onOff = 1;
                HeavyScript.SendFloatToReceiver("onOff", 1);
            } else
            {
                onOff = 0;
                HeavyScript.SendFloatToReceiver("onOff", 0);
            }

        }
        if (Input.GetKeyDown("q"))
        {
            HeavyScript.SendFloatToReceiver("waveToggle", 0);
        }
        if (Input.GetKeyDown("w"))
        {
            HeavyScript.SendFloatToReceiver("waveToggle", 1);
        }
        if (Input.GetKey("a"))
        {
            freq -= 2;
            HeavyScript.SendFloatToReceiver("freq", freq);
        }
        else if (Input.GetKey("s"))
        {
            freq += 2;
            HeavyScript.SendFloatToReceiver("freq", freq);
        }
    }
}
