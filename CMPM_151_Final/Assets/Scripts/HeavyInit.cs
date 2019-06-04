using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyInit : MonoBehaviour
{
    private Hv_UnitySynth_AudioLib HeavyScript;
    // Start is called before the first frame update
    void Start()
    {
        HeavyScript = GetComponent<Hv_UnitySynth_AudioLib>();
        // Global tempo
        //HeavyScript.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Tempo, 800);

        //
        // Synth 4 : BG Music
        HeavyScript.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Vol4, 1);
        HeavyScript.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Lowpass4, 100);

        //
        // Synth 1 : Walking

        // Sequence
        HeavyScript.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq1_0, 4);
        HeavyScript.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq1_1, 2);
        HeavyScript.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq1_2, 4);
        HeavyScript.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq1_3, 2);
        HeavyScript.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq1_4, 4);
        HeavyScript.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq1_5, 2);
        HeavyScript.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq1_6, 4);
        HeavyScript.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq1_7, 2);
        // Mix
        HeavyScript.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Oscmix1, 0.8f);
        HeavyScript.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Squaremix1, 0.2f);

        //
        // Synth 2 : Sprinting
        HeavyScript.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq2_0, 7);
        HeavyScript.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq2_1, 0);
        HeavyScript.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq2_2, 2);
        HeavyScript.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq2_3, 4);
        HeavyScript.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq2_4, 7);
        HeavyScript.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq2_5, 0);
        HeavyScript.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq2_6, 9);
        HeavyScript.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq2_7, 7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
