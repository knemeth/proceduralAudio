/**
 * Copyright (c) 2019 Enzien Audio, Ltd.
 * 
 * Redistribution and use in source and binary forms, with or without modification,
 * are permitted provided that the following conditions are met:
 * 
 * 1. Redistributions of source code must retain the above copyright notice,
 *    this list of conditions, and the following disclaimer.
 * 
 * 2. Redistributions in binary form must reproduce the phrase "powered by heavy",
 *    the heavy logo, and a hyperlink to https://enzienaudio.com, all in a visible
 *    form.
 * 
 *   2.1 If the Application is distributed in a store system (for example,
 *       the Apple "App Store" or "Google Play"), the phrase "powered by heavy"
 *       shall be included in the app description or the copyright text as well as
 *       the in the app itself. The heavy logo will shall be visible in the app
 *       itself as well.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
 * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO,
 * THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
 * ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
 * FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
 * DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
 * CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
 * OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
 * THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 * 
 */

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Assertions;
using AOT;

#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(Hv_bgSynth_AudioLib))]
public class Hv_bgSynth_Editor : Editor {

  [MenuItem("Heavy/bgSynth")]
  static void CreateHv_bgSynth() {
    GameObject target = Selection.activeGameObject;
    if (target != null) {
      target.AddComponent<Hv_bgSynth_AudioLib>();
    }
  }

  private Hv_bgSynth_AudioLib _dsp;

  private void OnEnable() {
    _dsp = target as Hv_bgSynth_AudioLib;
  }

  public override void OnInspectorGUI() {
    bool isEnabled = _dsp.IsInstantiated();
    if (!isEnabled) {
      EditorGUILayout.LabelField("Press Play!",  EditorStyles.centeredGreyMiniLabel);
    }
    GUILayout.BeginVertical();
    
    // PARAMETERS
    GUI.enabled = true;
    EditorGUILayout.Space();
    EditorGUI.indentLevel++;

    // attack2
    GUILayout.BeginHorizontal();
    float attack2 = _dsp.GetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Attack2);
    float newAttack2 = EditorGUILayout.Slider("attack2", attack2, 10.0f, 1000.0f);
    if (attack2 != newAttack2) {
      _dsp.SetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Attack2, newAttack2);
    }
    GUILayout.EndHorizontal();

    // decay2
    GUILayout.BeginHorizontal();
    float decay2 = _dsp.GetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Decay2);
    float newDecay2 = EditorGUILayout.Slider("decay2", decay2, 10.0f, 1000.0f);
    if (decay2 != newDecay2) {
      _dsp.SetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Decay2, newDecay2);
    }
    GUILayout.EndHorizontal();

    // freqMod2
    GUILayout.BeginHorizontal();
    float freqMod2 = _dsp.GetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Freqmod2);
    float newFreqmod2 = EditorGUILayout.Slider("freqMod2", freqMod2, 0.0f, 1000.0f);
    if (freqMod2 != newFreqmod2) {
      _dsp.SetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Freqmod2, newFreqmod2);
    }
    GUILayout.EndHorizontal();

    // highPass2
    GUILayout.BeginHorizontal();
    float highPass2 = _dsp.GetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Highpass2);
    float newHighpass2 = EditorGUILayout.Slider("highPass2", highPass2, 0.0f, 2000.0f);
    if (highPass2 != newHighpass2) {
      _dsp.SetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Highpass2, newHighpass2);
    }
    GUILayout.EndHorizontal();

    // lowPass2
    GUILayout.BeginHorizontal();
    float lowPass2 = _dsp.GetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Lowpass2);
    float newLowpass2 = EditorGUILayout.Slider("lowPass2", lowPass2, 0.0f, 100.0f);
    if (lowPass2 != newLowpass2) {
      _dsp.SetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Lowpass2, newLowpass2);
    }
    GUILayout.EndHorizontal();

    // metro
    GUILayout.BeginHorizontal();
    float metro = _dsp.GetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Metro);
    float newMetro = EditorGUILayout.Slider("metro", metro, 100.0f, 1000.0f);
    if (metro != newMetro) {
      _dsp.SetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Metro, newMetro);
    }
    GUILayout.EndHorizontal();

    // midiOffset2
    GUILayout.BeginHorizontal();
    float midiOffset2 = _dsp.GetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Midioffset2);
    float newMidioffset2 = EditorGUILayout.Slider("midiOffset2", midiOffset2, 40.0f, 69.0f);
    if (midiOffset2 != newMidioffset2) {
      _dsp.SetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Midioffset2, newMidioffset2);
    }
    GUILayout.EndHorizontal();

    // modFactor2
    GUILayout.BeginHorizontal();
    float modFactor2 = _dsp.GetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Modfactor2);
    float newModfactor2 = EditorGUILayout.Slider("modFactor2", modFactor2, 0.0f, 1000.0f);
    if (modFactor2 != newModfactor2) {
      _dsp.SetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Modfactor2, newModfactor2);
    }
    GUILayout.EndHorizontal();

    // oscMix2
    GUILayout.BeginHorizontal();
    float oscMix2 = _dsp.GetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Oscmix2);
    float newOscmix2 = EditorGUILayout.Slider("oscMix2", oscMix2, 0.0f, 1.0f);
    if (oscMix2 != newOscmix2) {
      _dsp.SetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Oscmix2, newOscmix2);
    }
    GUILayout.EndHorizontal();

    // release2
    GUILayout.BeginHorizontal();
    float release2 = _dsp.GetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Release2);
    float newRelease2 = EditorGUILayout.Slider("release2", release2, 10.0f, 1000.0f);
    if (release2 != newRelease2) {
      _dsp.SetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Release2, newRelease2);
    }
    GUILayout.EndHorizontal();

    // seq2_0
    GUILayout.BeginHorizontal();
    float seq2_0 = _dsp.GetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Seq2_0);
    float newSeq2_0 = EditorGUILayout.Slider("seq2_0", seq2_0, 0.0f, 11.0f);
    if (seq2_0 != newSeq2_0) {
      _dsp.SetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Seq2_0, newSeq2_0);
    }
    GUILayout.EndHorizontal();

    // seq2_1
    GUILayout.BeginHorizontal();
    float seq2_1 = _dsp.GetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Seq2_1);
    float newSeq2_1 = EditorGUILayout.Slider("seq2_1", seq2_1, 0.0f, 11.0f);
    if (seq2_1 != newSeq2_1) {
      _dsp.SetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Seq2_1, newSeq2_1);
    }
    GUILayout.EndHorizontal();

    // seq2_2
    GUILayout.BeginHorizontal();
    float seq2_2 = _dsp.GetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Seq2_2);
    float newSeq2_2 = EditorGUILayout.Slider("seq2_2", seq2_2, 0.0f, 11.0f);
    if (seq2_2 != newSeq2_2) {
      _dsp.SetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Seq2_2, newSeq2_2);
    }
    GUILayout.EndHorizontal();

    // seq2_3
    GUILayout.BeginHorizontal();
    float seq2_3 = _dsp.GetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Seq2_3);
    float newSeq2_3 = EditorGUILayout.Slider("seq2_3", seq2_3, 0.0f, 11.0f);
    if (seq2_3 != newSeq2_3) {
      _dsp.SetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Seq2_3, newSeq2_3);
    }
    GUILayout.EndHorizontal();

    // seq2_4
    GUILayout.BeginHorizontal();
    float seq2_4 = _dsp.GetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Seq2_4);
    float newSeq2_4 = EditorGUILayout.Slider("seq2_4", seq2_4, 0.0f, 11.0f);
    if (seq2_4 != newSeq2_4) {
      _dsp.SetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Seq2_4, newSeq2_4);
    }
    GUILayout.EndHorizontal();

    // seq2_5
    GUILayout.BeginHorizontal();
    float seq2_5 = _dsp.GetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Seq2_5);
    float newSeq2_5 = EditorGUILayout.Slider("seq2_5", seq2_5, 0.0f, 11.0f);
    if (seq2_5 != newSeq2_5) {
      _dsp.SetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Seq2_5, newSeq2_5);
    }
    GUILayout.EndHorizontal();

    // seq2_6
    GUILayout.BeginHorizontal();
    float seq2_6 = _dsp.GetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Seq2_6);
    float newSeq2_6 = EditorGUILayout.Slider("seq2_6", seq2_6, 0.0f, 11.0f);
    if (seq2_6 != newSeq2_6) {
      _dsp.SetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Seq2_6, newSeq2_6);
    }
    GUILayout.EndHorizontal();

    // seq2_7
    GUILayout.BeginHorizontal();
    float seq2_7 = _dsp.GetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Seq2_7);
    float newSeq2_7 = EditorGUILayout.Slider("seq2_7", seq2_7, 0.0f, 11.0f);
    if (seq2_7 != newSeq2_7) {
      _dsp.SetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Seq2_7, newSeq2_7);
    }
    GUILayout.EndHorizontal();

    // squareMix2
    GUILayout.BeginHorizontal();
    float squareMix2 = _dsp.GetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Squaremix2);
    float newSquaremix2 = EditorGUILayout.Slider("squareMix2", squareMix2, 0.0f, 1.0f);
    if (squareMix2 != newSquaremix2) {
      _dsp.SetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Squaremix2, newSquaremix2);
    }
    GUILayout.EndHorizontal();

    // sustain2
    GUILayout.BeginHorizontal();
    float sustain2 = _dsp.GetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Sustain2);
    float newSustain2 = EditorGUILayout.Slider("sustain2", sustain2, 0.0f, 1.0f);
    if (sustain2 != newSustain2) {
      _dsp.SetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Sustain2, newSustain2);
    }
    GUILayout.EndHorizontal();

    // vol2
    GUILayout.BeginHorizontal();
    float vol2 = _dsp.GetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Vol2);
    float newVol2 = EditorGUILayout.Slider("vol2", vol2, 0.0f, 1.0f);
    if (vol2 != newVol2) {
      _dsp.SetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Vol2, newVol2);
    }
    GUILayout.EndHorizontal();

    EditorGUI.indentLevel--;

    

    GUILayout.EndVertical();
  }
}
#endif // UNITY_EDITOR

[RequireComponent (typeof (AudioSource))]
public class Hv_bgSynth_AudioLib : MonoBehaviour {
  
  // Parameters are used to send float messages into the patch context (thread-safe).
  // Example usage:
  /*
    void Start () {
        Hv_bgSynth_AudioLib script = GetComponent<Hv_bgSynth_AudioLib>();
        // Get and set a parameter
        float attack2 = script.GetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Attack2);
        script.SetFloatParameter(Hv_bgSynth_AudioLib.Parameter.Attack2, attack2 + 0.1f);
    }
  */
  public enum Parameter : uint {
    Attack2 = 0xF3436A8,
    Decay2 = 0x66E0438,
    Freqmod2 = 0x738741C9,
    Highpass2 = 0xA15A2873,
    Lowpass2 = 0xDB8990D5,
    Metro = 0x9E78BC0,
    Midioffset2 = 0x4D9F69BC,
    Modfactor2 = 0x9DCECDED,
    Oscmix2 = 0xFF49CCFC,
    Release2 = 0x9CA5B2E4,
    Seq2_0 = 0x493A23BA,
    Seq2_1 = 0x4C380B71,
    Seq2_2 = 0x4EAD1D8A,
    Seq2_3 = 0x35F9071F,
    Seq2_4 = 0x3B4BD382,
    Seq2_5 = 0x20CA14C5,
    Seq2_6 = 0x7B509FA2,
    Seq2_7 = 0xCC9ECF0D,
    Squaremix2 = 0xBCD4BEA5,
    Sustain2 = 0x2A64D1A4,
    Vol2 = 0xD595CC91,
  }
  
  // Delegate method for receiving float messages from the patch context (thread-safe).
  // Example usage:
  /*
    void Start () {
        Hv_bgSynth_AudioLib script = GetComponent<Hv_bgSynth_AudioLib>();
        script.RegisterSendHook();
        script.FloatReceivedCallback += OnFloatMessage;
    }

    void OnFloatMessage(Hv_bgSynth_AudioLib.FloatMessage message) {
        Debug.Log(message.receiverName + ": " + message.value);
    }
  */
  public class FloatMessage {
    public string receiverName;
    public float value;

    public FloatMessage(string name, float x) {
      receiverName = name;
      value = x;
    }
  }
  public delegate void FloatMessageReceived(FloatMessage message);
  public FloatMessageReceived FloatReceivedCallback;
  public float attack2 = 10.0f;
  public float decay2 = 150.0f;
  public float freqMod2 = 0.0f;
  public float highPass2 = 0.0f;
  public float lowPass2 = 100.0f;
  public float metro = 400.0f;
  public float midiOffset2 = 50.0f;
  public float modFactor2 = 0.0f;
  public float oscMix2 = 0.0f;
  public float release2 = 150.0f;
  public float seq2_0 = 0.0f;
  public float seq2_1 = 4.0f;
  public float seq2_2 = 7.0f;
  public float seq2_3 = 11.0f;
  public float seq2_4 = 7.0f;
  public float seq2_5 = 4.0f;
  public float seq2_6 = 0.0f;
  public float seq2_7 = 4.0f;
  public float squareMix2 = 1.0f;
  public float sustain2 = 0.5f;
  public float vol2 = 0.1f;

  // internal state
  private Hv_bgSynth_Context _context;

  public bool IsInstantiated() {
    return (_context != null);
  }

  public void RegisterSendHook() {
    _context.RegisterSendHook();
  }
  
  // see Hv_bgSynth_AudioLib.Parameter for definitions
  public float GetFloatParameter(Hv_bgSynth_AudioLib.Parameter param) {
    switch (param) {
      case Parameter.Attack2: return attack2;
      case Parameter.Decay2: return decay2;
      case Parameter.Freqmod2: return freqMod2;
      case Parameter.Highpass2: return highPass2;
      case Parameter.Lowpass2: return lowPass2;
      case Parameter.Metro: return metro;
      case Parameter.Midioffset2: return midiOffset2;
      case Parameter.Modfactor2: return modFactor2;
      case Parameter.Oscmix2: return oscMix2;
      case Parameter.Release2: return release2;
      case Parameter.Seq2_0: return seq2_0;
      case Parameter.Seq2_1: return seq2_1;
      case Parameter.Seq2_2: return seq2_2;
      case Parameter.Seq2_3: return seq2_3;
      case Parameter.Seq2_4: return seq2_4;
      case Parameter.Seq2_5: return seq2_5;
      case Parameter.Seq2_6: return seq2_6;
      case Parameter.Seq2_7: return seq2_7;
      case Parameter.Squaremix2: return squareMix2;
      case Parameter.Sustain2: return sustain2;
      case Parameter.Vol2: return vol2;
      default: return 0.0f;
    }
  }

  public void SetFloatParameter(Hv_bgSynth_AudioLib.Parameter param, float x) {
    switch (param) {
      case Parameter.Attack2: {
        x = Mathf.Clamp(x, 10.0f, 1000.0f);
        attack2 = x;
        break;
      }
      case Parameter.Decay2: {
        x = Mathf.Clamp(x, 10.0f, 1000.0f);
        decay2 = x;
        break;
      }
      case Parameter.Freqmod2: {
        x = Mathf.Clamp(x, 0.0f, 1000.0f);
        freqMod2 = x;
        break;
      }
      case Parameter.Highpass2: {
        x = Mathf.Clamp(x, 0.0f, 2000.0f);
        highPass2 = x;
        break;
      }
      case Parameter.Lowpass2: {
        x = Mathf.Clamp(x, 0.0f, 100.0f);
        lowPass2 = x;
        break;
      }
      case Parameter.Metro: {
        x = Mathf.Clamp(x, 100.0f, 1000.0f);
        metro = x;
        break;
      }
      case Parameter.Midioffset2: {
        x = Mathf.Clamp(x, 40.0f, 69.0f);
        midiOffset2 = x;
        break;
      }
      case Parameter.Modfactor2: {
        x = Mathf.Clamp(x, 0.0f, 1000.0f);
        modFactor2 = x;
        break;
      }
      case Parameter.Oscmix2: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        oscMix2 = x;
        break;
      }
      case Parameter.Release2: {
        x = Mathf.Clamp(x, 10.0f, 1000.0f);
        release2 = x;
        break;
      }
      case Parameter.Seq2_0: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq2_0 = x;
        break;
      }
      case Parameter.Seq2_1: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq2_1 = x;
        break;
      }
      case Parameter.Seq2_2: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq2_2 = x;
        break;
      }
      case Parameter.Seq2_3: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq2_3 = x;
        break;
      }
      case Parameter.Seq2_4: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq2_4 = x;
        break;
      }
      case Parameter.Seq2_5: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq2_5 = x;
        break;
      }
      case Parameter.Seq2_6: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq2_6 = x;
        break;
      }
      case Parameter.Seq2_7: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq2_7 = x;
        break;
      }
      case Parameter.Squaremix2: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        squareMix2 = x;
        break;
      }
      case Parameter.Sustain2: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        sustain2 = x;
        break;
      }
      case Parameter.Vol2: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        vol2 = x;
        break;
      }
      default: return;
    }
    if (IsInstantiated()) _context.SendFloatToReceiver((uint) param, x);
  }
  
  public void SendFloatToReceiver(string receiverName, float x) {
    _context.SendFloatToReceiver(StringToHash(receiverName), x);
  }

  public void FillTableWithMonoAudioClip(string tableName, AudioClip clip) {
    if (clip.channels > 1) {
      Debug.LogWarning("Hv_bgSynth_AudioLib: Only loading first channel of '" +
          clip.name + "' into table '" +
          tableName + "'. Multi-channel files are not supported.");
    }
    float[] buffer = new float[clip.samples]; // copy only the 1st channel
    clip.GetData(buffer, 0);
    _context.FillTableWithFloatBuffer(StringToHash(tableName), buffer);
  }

  public void FillTableWithMonoAudioClip(uint tableHash, AudioClip clip) {
    if (clip.channels > 1) {
      Debug.LogWarning("Hv_bgSynth_AudioLib: Only loading first channel of '" +
          clip.name + "' into table '" +
          tableHash + "'. Multi-channel files are not supported.");
    }
    float[] buffer = new float[clip.samples]; // copy only the 1st channel
    clip.GetData(buffer, 0);
    _context.FillTableWithFloatBuffer(tableHash, buffer);
  }

  public void FillTableWithFloatBuffer(string tableName, float[] buffer) {
    _context.FillTableWithFloatBuffer(StringToHash(tableName), buffer);
  }

  public void FillTableWithFloatBuffer(uint tableHash, float[] buffer) {
    _context.FillTableWithFloatBuffer(tableHash, buffer);
  }

  public uint StringToHash(string str) {
    return _context.StringToHash(str);
  }

  private void Awake() {
    _context = new Hv_bgSynth_Context((double) AudioSettings.outputSampleRate);
    
  }
  
  private void Start() {
    _context.SendFloatToReceiver((uint) Parameter.Attack2, attack2);
    _context.SendFloatToReceiver((uint) Parameter.Decay2, decay2);
    _context.SendFloatToReceiver((uint) Parameter.Freqmod2, freqMod2);
    _context.SendFloatToReceiver((uint) Parameter.Highpass2, highPass2);
    _context.SendFloatToReceiver((uint) Parameter.Lowpass2, lowPass2);
    _context.SendFloatToReceiver((uint) Parameter.Metro, metro);
    _context.SendFloatToReceiver((uint) Parameter.Midioffset2, midiOffset2);
    _context.SendFloatToReceiver((uint) Parameter.Modfactor2, modFactor2);
    _context.SendFloatToReceiver((uint) Parameter.Oscmix2, oscMix2);
    _context.SendFloatToReceiver((uint) Parameter.Release2, release2);
    _context.SendFloatToReceiver((uint) Parameter.Seq2_0, seq2_0);
    _context.SendFloatToReceiver((uint) Parameter.Seq2_1, seq2_1);
    _context.SendFloatToReceiver((uint) Parameter.Seq2_2, seq2_2);
    _context.SendFloatToReceiver((uint) Parameter.Seq2_3, seq2_3);
    _context.SendFloatToReceiver((uint) Parameter.Seq2_4, seq2_4);
    _context.SendFloatToReceiver((uint) Parameter.Seq2_5, seq2_5);
    _context.SendFloatToReceiver((uint) Parameter.Seq2_6, seq2_6);
    _context.SendFloatToReceiver((uint) Parameter.Seq2_7, seq2_7);
    _context.SendFloatToReceiver((uint) Parameter.Squaremix2, squareMix2);
    _context.SendFloatToReceiver((uint) Parameter.Sustain2, sustain2);
    _context.SendFloatToReceiver((uint) Parameter.Vol2, vol2);
  }
  
  private void Update() {
    // retreive sent messages
    if (_context.IsSendHookRegistered()) {
      Hv_bgSynth_AudioLib.FloatMessage tempMessage;
      while ((tempMessage = _context.msgQueue.GetNextMessage()) != null) {
        FloatReceivedCallback(tempMessage);
      }
    }
  }

  private void OnAudioFilterRead(float[] buffer, int numChannels) {
    Assert.AreEqual(numChannels, _context.GetNumOutputChannels()); // invalid channel configuration
    _context.Process(buffer, buffer.Length / numChannels); // process dsp
  }
}

class Hv_bgSynth_Context {

#if UNITY_IOS && !UNITY_EDITOR
  private const string _dllName = "__Internal";
#else
  private const string _dllName = "Hv_bgSynth_AudioLib";
#endif

  // Thread-safe message queue
  public class SendMessageQueue {
    private readonly object _msgQueueSync = new object();
    private readonly Queue<Hv_bgSynth_AudioLib.FloatMessage> _msgQueue = new Queue<Hv_bgSynth_AudioLib.FloatMessage>();

    public Hv_bgSynth_AudioLib.FloatMessage GetNextMessage() {
      lock (_msgQueueSync) {
        return (_msgQueue.Count != 0) ? _msgQueue.Dequeue() : null;
      }
    }

    public void AddMessage(string receiverName, float value) {
      Hv_bgSynth_AudioLib.FloatMessage msg = new Hv_bgSynth_AudioLib.FloatMessage(receiverName, value);
      lock (_msgQueueSync) {
        _msgQueue.Enqueue(msg);
      }
    }
  }

  public readonly SendMessageQueue msgQueue = new SendMessageQueue();
  private readonly GCHandle gch;
  private readonly IntPtr _context; // handle into unmanaged memory
  private SendHook _sendHook = null;

  [DllImport (_dllName)]
  private static extern IntPtr hv_bgSynth_new_with_options(double sampleRate, int poolKb, int inQueueKb, int outQueueKb);

  [DllImport (_dllName)]
  private static extern int hv_processInlineInterleaved(IntPtr ctx,
      [In] float[] inBuffer, [Out] float[] outBuffer, int numSamples);

  [DllImport (_dllName)]
  private static extern void hv_delete(IntPtr ctx);

  [DllImport (_dllName)]
  private static extern double hv_getSampleRate(IntPtr ctx);

  [DllImport (_dllName)]
  private static extern int hv_getNumInputChannels(IntPtr ctx);

  [DllImport (_dllName)]
  private static extern int hv_getNumOutputChannels(IntPtr ctx);

  [DllImport (_dllName)]
  private static extern void hv_setSendHook(IntPtr ctx, SendHook sendHook);

  [DllImport (_dllName)]
  private static extern void hv_setPrintHook(IntPtr ctx, PrintHook printHook);

  [DllImport (_dllName)]
  private static extern int hv_setUserData(IntPtr ctx, IntPtr userData);

  [DllImport (_dllName)]
  private static extern IntPtr hv_getUserData(IntPtr ctx);

  [DllImport (_dllName)]
  private static extern void hv_sendBangToReceiver(IntPtr ctx, uint receiverHash);

  [DllImport (_dllName)]
  private static extern void hv_sendFloatToReceiver(IntPtr ctx, uint receiverHash, float x);

  [DllImport (_dllName)]
  private static extern uint hv_msg_getTimestamp(IntPtr message);

  [DllImport (_dllName)]
  private static extern bool hv_msg_hasFormat(IntPtr message, string format);

  [DllImport (_dllName)]
  private static extern float hv_msg_getFloat(IntPtr message, int index);

  [DllImport (_dllName)]
  private static extern bool hv_table_setLength(IntPtr ctx, uint tableHash, uint newSampleLength);

  [DllImport (_dllName)]
  private static extern IntPtr hv_table_getBuffer(IntPtr ctx, uint tableHash);

  [DllImport (_dllName)]
  private static extern float hv_samplesToMilliseconds(IntPtr ctx, uint numSamples);

  [DllImport (_dllName)]
  private static extern uint hv_stringToHash(string s);

  private delegate void PrintHook(IntPtr context, string printName, string str, IntPtr message);

  private delegate void SendHook(IntPtr context, string sendName, uint sendHash, IntPtr message);

  public Hv_bgSynth_Context(double sampleRate, int poolKb=10, int inQueueKb=21, int outQueueKb=2) {
    gch = GCHandle.Alloc(msgQueue);
    _context = hv_bgSynth_new_with_options(sampleRate, poolKb, inQueueKb, outQueueKb);
    hv_setPrintHook(_context, new PrintHook(OnPrint));
    hv_setUserData(_context, GCHandle.ToIntPtr(gch));
  }

  ~Hv_bgSynth_Context() {
    hv_delete(_context);
    GC.KeepAlive(_context);
    GC.KeepAlive(_sendHook);
    gch.Free();
  }

  public void RegisterSendHook() {
    // Note: send hook functionality only applies to messages containing a single float value
    if (_sendHook == null) {
      _sendHook = new SendHook(OnMessageSent);
      hv_setSendHook(_context, _sendHook);
    }
  }

  public bool IsSendHookRegistered() {
    return (_sendHook != null);
  }

  public double GetSampleRate() {
    return hv_getSampleRate(_context);
  }

  public int GetNumInputChannels() {
    return hv_getNumInputChannels(_context);
  }

  public int GetNumOutputChannels() {
    return hv_getNumOutputChannels(_context);
  }

  public void SendBangToReceiver(uint receiverHash) {
    hv_sendBangToReceiver(_context, receiverHash);
  }

  public void SendFloatToReceiver(uint receiverHash, float x) {
    hv_sendFloatToReceiver(_context, receiverHash, x);
  }

  public void FillTableWithFloatBuffer(uint tableHash, float[] buffer) {
    if (hv_table_getBuffer(_context, tableHash) != IntPtr.Zero) {
      hv_table_setLength(_context, tableHash, (uint) buffer.Length);
      Marshal.Copy(buffer, 0, hv_table_getBuffer(_context, tableHash), buffer.Length);
    } else {
      Debug.Log(string.Format("Table '{0}' doesn't exist in the patch context.", tableHash));
    }
  }

  public uint StringToHash(string s) {
    return hv_stringToHash(s);
  }

  public int Process(float[] buffer, int numFrames) {
    return hv_processInlineInterleaved(_context, buffer, buffer, numFrames);
  }

  [MonoPInvokeCallback(typeof(PrintHook))]
  private static void OnPrint(IntPtr context, string printName, string str, IntPtr message) {
    float timeInSecs = hv_samplesToMilliseconds(context, hv_msg_getTimestamp(message)) / 1000.0f;
    Debug.Log(string.Format("{0} [{1:0.000}]: {2}", printName, timeInSecs, str));
  }

  [MonoPInvokeCallback(typeof(SendHook))]
  private static void OnMessageSent(IntPtr context, string sendName, uint sendHash, IntPtr message) {
    if (hv_msg_hasFormat(message, "f")) {
      SendMessageQueue msgQueue = (SendMessageQueue) GCHandle.FromIntPtr(hv_getUserData(context)).Target;
      msgQueue.AddMessage(sendName, hv_msg_getFloat(message, 0));
    }
  }
}
