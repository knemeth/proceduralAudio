using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprintChange : MonoBehaviour
{
    enum Param : uint
    {
        Volume = Hv_sprintSynth_AudioLib.Parameter.Vol2,
        Attack = Hv_sprintSynth_AudioLib.Parameter.Attack2,
        Decay = Hv_sprintSynth_AudioLib.Parameter.Decay2,
        Sustain = Hv_sprintSynth_AudioLib.Parameter.Sustain2,
        Release = Hv_sprintSynth_AudioLib.Parameter.Release2,
        Freqmod = Hv_sprintSynth_AudioLib.Parameter.Freqmod2,
        ModFactor = Hv_sprintSynth_AudioLib.Parameter.Modfactor2,
        HighPass = Hv_sprintSynth_AudioLib.Parameter.Highpass2,
        LowPass = Hv_sprintSynth_AudioLib.Parameter.Lowpass2,
        MidiOffset = Hv_sprintSynth_AudioLib.Parameter.Midioffset2,
        OscMix = Hv_sprintSynth_AudioLib.Parameter.Oscmix2,
        SquareMix = Hv_sprintSynth_AudioLib.Parameter.Squaremix2
    }

    private Hv_sprintSynth_AudioLib sprintSynth;
    private Hv_sprintSynth_AudioLib.Parameter paramCheck;

    [SerializeField] private Param parameter = Param.Volume;
    public float value;

    // Start is called before the first frame update
    void Start()
    {
        sprintSynth = GameObject.Find("HeavyController").GetComponentInChildren<Hv_sprintSynth_AudioLib>();

        foreach (Hv_sprintSynth_AudioLib.Parameter p in Enum.GetValues(typeof(Hv_sprintSynth_AudioLib.Parameter)))
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
        sprintSynth.SetFloatParameter(paramCheck, value);
    }
}
