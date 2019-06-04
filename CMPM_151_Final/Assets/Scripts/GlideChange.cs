using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlideChange : MonoBehaviour
{
    enum Param : uint
    {
        Volume = Hv_glideSynth_AudioLib.Parameter.Vol2,
        Attack = Hv_glideSynth_AudioLib.Parameter.Attack2,
        Decay = Hv_glideSynth_AudioLib.Parameter.Decay2,
        Sustain = Hv_glideSynth_AudioLib.Parameter.Sustain2,
        Release = Hv_glideSynth_AudioLib.Parameter.Release2,
        Freqmod = Hv_glideSynth_AudioLib.Parameter.Freqmod2,
        ModFactor = Hv_glideSynth_AudioLib.Parameter.Modfactor2,
        HighPass = Hv_glideSynth_AudioLib.Parameter.Highpass2,
        LowPass = Hv_glideSynth_AudioLib.Parameter.Lowpass2,
        MidiOffset = Hv_glideSynth_AudioLib.Parameter.Midioffset2,
        OscMix = Hv_glideSynth_AudioLib.Parameter.Oscmix2,
        SquareMix = Hv_glideSynth_AudioLib.Parameter.Squaremix2
    }

    private Hv_glideSynth_AudioLib glideSynth;
    private Hv_glideSynth_AudioLib.Parameter paramCheck;

    [SerializeField] private Param parameter = Param.Volume;
    public float value;

    // Start is called before the first frame update
    void Start()
    {
        glideSynth = GameObject.Find("HeavyController").GetComponentInChildren<Hv_glideSynth_AudioLib>();

        foreach (Hv_glideSynth_AudioLib.Parameter p in Enum.GetValues(typeof(Hv_glideSynth_AudioLib.Parameter)))
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
        glideSynth.SetFloatParameter(paramCheck, value);
    }
}
