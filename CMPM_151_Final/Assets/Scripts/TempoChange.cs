using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempoChange : MonoBehaviour
{
    private Hv_walkSynth_AudioLib walkSynth;
    private Hv_sprintSynth_AudioLib sprintSynth;
    private Hv_glideSynth_AudioLib glideSynth;
    private Hv_bgSynth_AudioLib bgSynth;

    public float tempo = 400;

    // Start is called before the first frame update
    void Start()
    {
        walkSynth = GameObject.Find("HeavyController").GetComponentInChildren<Hv_walkSynth_AudioLib>();
        sprintSynth = GameObject.Find("HeavyController").GetComponentInChildren<Hv_sprintSynth_AudioLib>();
        glideSynth = GameObject.Find("HeavyController").GetComponentInChildren<Hv_glideSynth_AudioLib>();
        bgSynth = GameObject.Find("HeavyController").GetComponentInChildren<Hv_bgSynth_AudioLib>();
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        walkSynth.SetFloatParameter(Hv_walkSynth_AudioLib.Parameter.Metro, tempo);
        sprintSynth.SetFloatParameter(Hv_sprintSynth_AudioLib.Parameter.Metro, tempo / 2);
        glideSynth.SetFloatParameter(Hv_glideSynth_AudioLib.Parameter.Metro, tempo);
        bgSynth.SetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Metro, tempo);
    }
}
