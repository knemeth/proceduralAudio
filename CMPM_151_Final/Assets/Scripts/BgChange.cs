using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgChange : MonoBehaviour
{
    enum Param : uint
    {
        Volume = Hv_bgSynth_AudioLib.Parameter.Vol2,
        Attack = Hv_bgSynth_AudioLib.Parameter.Attack2,
        Decay = Hv_bgSynth_AudioLib.Parameter.Decay2,
        Sustain = Hv_bgSynth_AudioLib.Parameter.Sustain2,
        Release = Hv_bgSynth_AudioLib.Parameter.Release2,
        Freqmod = Hv_bgSynth_AudioLib.Parameter.Freqmod2,
        ModFactor = Hv_bgSynth_AudioLib.Parameter.Modfactor2,
        HighPass = Hv_bgSynth_AudioLib.Parameter.Highpass2,
        LowPass = Hv_bgSynth_AudioLib.Parameter.Lowpass2,
        MidiOffset = Hv_bgSynth_AudioLib.Parameter.Midioffset2,
        OscMix = Hv_bgSynth_AudioLib.Parameter.Oscmix2,
        SquareMix = Hv_bgSynth_AudioLib.Parameter.Squaremix2
    }

    private Hv_bgSynth_AudioLib bgSynth;
    private Hv_bgSynth_AudioLib.Parameter paramCheck;

    [SerializeField] private Param parameter = Param.Volume;
    public float value;

    // Start is called before the first frame update
    void Start()
    {
        bgSynth = GameObject.Find("HeavyController").GetComponentInChildren<Hv_bgSynth_AudioLib>();

        foreach (Hv_bgSynth_AudioLib.Parameter p in Enum.GetValues(typeof(Hv_bgSynth_AudioLib.Parameter)))
        {
            if ((uint)p == (uint)parameter)
            {
                paramCheck = p;
                break;
            }
        }
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        bgSynth.SetFloatParameter(paramCheck, value);
    }
}
