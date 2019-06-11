using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private Light lt;
    private GameObject player;
    private Color color;
    private Hv_bgSynth_AudioLib bgSynth;

    private ColorGrading colorGrading;
    private PostProcessVolume ppp; 

    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();
        player = GameObject.Find("Player");
        bgSynth = GameObject.Find("HeavyController").GetComponentInChildren<Hv_bgSynth_AudioLib>();
        ppp = player.GetComponentInChildren<PostProcessVolume>();
        ppp.profile.TryGetSettings(out colorGrading);
    }

    // Update is called once per frame
    void Update()
    {
        color.r = bgSynth.GetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Attack2) / 200;
        color.g = bgSynth.GetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Metro) / 400;
        color.b = bgSynth.GetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Lowpass2) / 60;

        lt.color = color;
        colorGrading.tint.value = (player.transform.position.x) * 2;
    }
}
