using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyController : MonoBehaviour
{
    public Hv_firstUnityTest_AudioLib HeavyScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")) {
            print(HeavyScript);
            HeavyScript.SendMessage("Channel-A");
        }
    }
}
