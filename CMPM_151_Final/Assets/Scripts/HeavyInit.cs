using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyInit : MonoBehaviour
{
    //private Hv_UnitySynth_AudioLib HeavyScript;
    private Hv_walkSynth_AudioLib walkSynth;
    private Hv_sprintSynth_AudioLib sprintSynth;
    private Hv_glideSynth_AudioLib glideSynth;
    private Hv_bgSynth_AudioLib bgSynth;

    public float tempo = 400;
    // Start is called before the first frame update
    void Start()
    {
        walkSynth = GetComponentInChildren<Hv_walkSynth_AudioLib>();
        sprintSynth = GetComponentInChildren<Hv_sprintSynth_AudioLib>();
        glideSynth = GetComponentInChildren<Hv_glideSynth_AudioLib>();
        bgSynth = GetComponentInChildren<Hv_bgSynth_AudioLib>();
        // Global tempo
        //HeavyScript.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Tempo, 800);
        walkSynth.SetFloatParameter(Hv_walkSynth_AudioLib.Parameter.Metro, tempo);
        sprintSynth.SetFloatParameter(Hv_sprintSynth_AudioLib.Parameter.Metro, tempo / 2);
        glideSynth.SetFloatParameter(Hv_glideSynth_AudioLib.Parameter.Metro, tempo);
        bgSynth.SetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Metro, tempo);

        //
        // Synth 4 : BG Music
        bgSynth.SetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Vol2, 0.3f);

        //
        // Synth 1 : Walking

        // Sequence
        walkSynth.SetFloatParameter(Hv_walkSynth_AudioLib.Parameter.Seq2_0, 4);
        walkSynth.SetFloatParameter(Hv_walkSynth_AudioLib.Parameter.Seq2_1, 2);
        walkSynth.SetFloatParameter(Hv_walkSynth_AudioLib.Parameter.Seq2_2, 4);
        walkSynth.SetFloatParameter(Hv_walkSynth_AudioLib.Parameter.Seq2_3, 2);
        walkSynth.SetFloatParameter(Hv_walkSynth_AudioLib.Parameter.Seq2_4, 0);
        walkSynth.SetFloatParameter(Hv_walkSynth_AudioLib.Parameter.Seq2_5, 2);
        walkSynth.SetFloatParameter(Hv_walkSynth_AudioLib.Parameter.Seq2_6, 4);
        walkSynth.SetFloatParameter(Hv_walkSynth_AudioLib.Parameter.Seq2_7, 2);
        // Mix
        walkSynth.SetFloatParameter(Hv_walkSynth_AudioLib.Parameter.Oscmix2, 0.8f);
        walkSynth.SetFloatParameter(Hv_walkSynth_AudioLib.Parameter.Squaremix2, 0.2f);
        // ADSR
        walkSynth.SetFloatParameter(Hv_walkSynth_AudioLib.Parameter.Attack2, 50);
        walkSynth.SetFloatParameter(Hv_walkSynth_AudioLib.Parameter.Decay2, 150);
        // Pitch
        walkSynth.SetFloatParameter(Hv_walkSynth_AudioLib.Parameter.Midioffset2, 45);

        //
        // Synth 2 : Sprinting
        sprintSynth.SetFloatParameter(Hv_sprintSynth_AudioLib.Parameter.Freqmod2, 100);
        sprintSynth.SetFloatParameter(Hv_sprintSynth_AudioLib.Parameter.Modfactor2, 5);

        sprintSynth.SetFloatParameter(Hv_sprintSynth_AudioLib.Parameter.Midioffset2, 58);

        //
        // Synth 3 : Gliding
        glideSynth.SetFloatParameter(Hv_glideSynth_AudioLib.Parameter.Attack2, 30);
        glideSynth.SetFloatParameter(Hv_glideSynth_AudioLib.Parameter.Midioffset2, 62);

        glideSynth.SetFloatParameter(Hv_glideSynth_AudioLib.Parameter.Oscmix2, 0.5f);
        glideSynth.SetFloatParameter(Hv_glideSynth_AudioLib.Parameter.Squaremix2, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
