using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkChange : MonoBehaviour
{
    enum Param : uint
    {
        Volume = Hv_walkSynth_AudioLib.Parameter.Vol2,
        Attack = Hv_walkSynth_AudioLib.Parameter.Attack2,
        Decay = Hv_walkSynth_AudioLib.Parameter.Decay2,
        Sustain = Hv_walkSynth_AudioLib.Parameter.Sustain2,
        Release = Hv_walkSynth_AudioLib.Parameter.Release2,
        Freqmod = Hv_walkSynth_AudioLib.Parameter.Freqmod2,
        ModFactor = Hv_walkSynth_AudioLib.Parameter.Modfactor2,
        HighPass = Hv_walkSynth_AudioLib.Parameter.Highpass2,
        LowPass = Hv_walkSynth_AudioLib.Parameter.Lowpass2,
        MidiOffset = Hv_walkSynth_AudioLib.Parameter.Midioffset2,
        OscMix = Hv_walkSynth_AudioLib.Parameter.Oscmix2,
        SquareMix = Hv_walkSynth_AudioLib.Parameter.Squaremix2
    }

    private Hv_walkSynth_AudioLib walkSynth;
    private Hv_walkSynth_AudioLib.Parameter paramCheck;

    [SerializeField] private Param parameter = Param.Volume;
    public float value;

    // Start is called before the first frame update
    void Start()
    {
        walkSynth = GameObject.Find("HeavyController").GetComponentInChildren<Hv_walkSynth_AudioLib>();

        foreach(Hv_walkSynth_AudioLib.Parameter p in Enum.GetValues(typeof(Hv_walkSynth_AudioLib.Parameter)))
        {
            if((uint)p == (uint)parameter)
            {
                paramCheck = p;
                break;
            }
        }
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        walkSynth.SetFloatParameter(paramCheck, value);
    }
}
