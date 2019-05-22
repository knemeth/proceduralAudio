using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyController : MonoBehaviour
{
    private Hv_firstUnityTest_AudioLib HeavyScript;
    // Start is called before the first frame update
    void Start()
    {
        HeavyScript = GetComponent<Hv_firstUnityTest_AudioLib>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")) {
            HeavyScript.SendFloatToReceiver("Channel-A", 100);
        }
    }
}
