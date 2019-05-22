using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyController : MonoBehaviour
{
    private Hv_HeavyDemo_AudioLib HeavyScript;
    // Start is called before the first frame update
    void Start()
    {
        HeavyScript = GetComponent<Hv_HeavyDemo_AudioLib>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")) {
            HeavyScript.SendFloatToReceiver("onOff", 1);
        }
        if (Input.GetKeyDown("q"))
        {
            HeavyScript.SendFloatToReceiver("onOff", 0);
        }
    }
}
