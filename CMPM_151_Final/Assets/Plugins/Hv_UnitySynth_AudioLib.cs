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

[CustomEditor(typeof(Hv_UnitySynth_AudioLib))]
public class Hv_UnitySynth_Editor : Editor {

  [MenuItem("Heavy/UnitySynth")]
  static void CreateHv_UnitySynth() {
    GameObject target = Selection.activeGameObject;
    if (target != null) {
      target.AddComponent<Hv_UnitySynth_AudioLib>();
    }
  }

  private Hv_UnitySynth_AudioLib _dsp;

  private void OnEnable() {
    _dsp = target as Hv_UnitySynth_AudioLib;
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

    // attack1
    GUILayout.BeginHorizontal();
    float attack1 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Attack1);
    float newAttack1 = EditorGUILayout.Slider("attack1", attack1, 10.0f, 1000.0f);
    if (attack1 != newAttack1) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Attack1, newAttack1);
    }
    GUILayout.EndHorizontal();

    // attack2
    GUILayout.BeginHorizontal();
    float attack2 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Attack2);
    float newAttack2 = EditorGUILayout.Slider("attack2", attack2, 10.0f, 1000.0f);
    if (attack2 != newAttack2) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Attack2, newAttack2);
    }
    GUILayout.EndHorizontal();

    // attack3
    GUILayout.BeginHorizontal();
    float attack3 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Attack3);
    float newAttack3 = EditorGUILayout.Slider("attack3", attack3, 10.0f, 1000.0f);
    if (attack3 != newAttack3) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Attack3, newAttack3);
    }
    GUILayout.EndHorizontal();

    // attack4
    GUILayout.BeginHorizontal();
    float attack4 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Attack4);
    float newAttack4 = EditorGUILayout.Slider("attack4", attack4, 10.0f, 1000.0f);
    if (attack4 != newAttack4) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Attack4, newAttack4);
    }
    GUILayout.EndHorizontal();

    // decay1
    GUILayout.BeginHorizontal();
    float decay1 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Decay1);
    float newDecay1 = EditorGUILayout.Slider("decay1", decay1, 10.0f, 1000.0f);
    if (decay1 != newDecay1) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Decay1, newDecay1);
    }
    GUILayout.EndHorizontal();

    // decay2
    GUILayout.BeginHorizontal();
    float decay2 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Decay2);
    float newDecay2 = EditorGUILayout.Slider("decay2", decay2, 10.0f, 1000.0f);
    if (decay2 != newDecay2) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Decay2, newDecay2);
    }
    GUILayout.EndHorizontal();

    // decay3
    GUILayout.BeginHorizontal();
    float decay3 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Decay3);
    float newDecay3 = EditorGUILayout.Slider("decay3", decay3, 10.0f, 1000.0f);
    if (decay3 != newDecay3) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Decay3, newDecay3);
    }
    GUILayout.EndHorizontal();

    // decay4
    GUILayout.BeginHorizontal();
    float decay4 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Decay4);
    float newDecay4 = EditorGUILayout.Slider("decay4", decay4, 10.0f, 1000.0f);
    if (decay4 != newDecay4) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Decay4, newDecay4);
    }
    GUILayout.EndHorizontal();

    // freqMod1
    GUILayout.BeginHorizontal();
    float freqMod1 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Freqmod1);
    float newFreqmod1 = EditorGUILayout.Slider("freqMod1", freqMod1, 0.0f, 1000.0f);
    if (freqMod1 != newFreqmod1) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Freqmod1, newFreqmod1);
    }
    GUILayout.EndHorizontal();

    // freqMod2
    GUILayout.BeginHorizontal();
    float freqMod2 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Freqmod2);
    float newFreqmod2 = EditorGUILayout.Slider("freqMod2", freqMod2, 0.0f, 1000.0f);
    if (freqMod2 != newFreqmod2) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Freqmod2, newFreqmod2);
    }
    GUILayout.EndHorizontal();

    // freqMod3
    GUILayout.BeginHorizontal();
    float freqMod3 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Freqmod3);
    float newFreqmod3 = EditorGUILayout.Slider("freqMod3", freqMod3, 0.0f, 1000.0f);
    if (freqMod3 != newFreqmod3) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Freqmod3, newFreqmod3);
    }
    GUILayout.EndHorizontal();

    // freqMod4
    GUILayout.BeginHorizontal();
    float freqMod4 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Freqmod4);
    float newFreqmod4 = EditorGUILayout.Slider("freqMod4", freqMod4, 0.0f, 1000.0f);
    if (freqMod4 != newFreqmod4) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Freqmod4, newFreqmod4);
    }
    GUILayout.EndHorizontal();

    // highPass1
    GUILayout.BeginHorizontal();
    float highPass1 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Highpass1);
    float newHighpass1 = EditorGUILayout.Slider("highPass1", highPass1, 0.0f, 2000.0f);
    if (highPass1 != newHighpass1) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Highpass1, newHighpass1);
    }
    GUILayout.EndHorizontal();

    // highPass2
    GUILayout.BeginHorizontal();
    float highPass2 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Highpass2);
    float newHighpass2 = EditorGUILayout.Slider("highPass2", highPass2, 0.0f, 2000.0f);
    if (highPass2 != newHighpass2) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Highpass2, newHighpass2);
    }
    GUILayout.EndHorizontal();

    // highPass3
    GUILayout.BeginHorizontal();
    float highPass3 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Highpass3);
    float newHighpass3 = EditorGUILayout.Slider("highPass3", highPass3, 0.0f, 2000.0f);
    if (highPass3 != newHighpass3) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Highpass3, newHighpass3);
    }
    GUILayout.EndHorizontal();

    // highPass4
    GUILayout.BeginHorizontal();
    float highPass4 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Highpass4);
    float newHighpass4 = EditorGUILayout.Slider("highPass4", highPass4, 0.0f, 2000.0f);
    if (highPass4 != newHighpass4) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Highpass4, newHighpass4);
    }
    GUILayout.EndHorizontal();

    // lowPass1
    GUILayout.BeginHorizontal();
    float lowPass1 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Lowpass1);
    float newLowpass1 = EditorGUILayout.Slider("lowPass1", lowPass1, 0.0f, 100.0f);
    if (lowPass1 != newLowpass1) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Lowpass1, newLowpass1);
    }
    GUILayout.EndHorizontal();

    // lowPass2
    GUILayout.BeginHorizontal();
    float lowPass2 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Lowpass2);
    float newLowpass2 = EditorGUILayout.Slider("lowPass2", lowPass2, 0.0f, 100.0f);
    if (lowPass2 != newLowpass2) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Lowpass2, newLowpass2);
    }
    GUILayout.EndHorizontal();

    // lowPass3
    GUILayout.BeginHorizontal();
    float lowPass3 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Lowpass3);
    float newLowpass3 = EditorGUILayout.Slider("lowPass3", lowPass3, 0.0f, 100.0f);
    if (lowPass3 != newLowpass3) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Lowpass3, newLowpass3);
    }
    GUILayout.EndHorizontal();

    // lowPass4
    GUILayout.BeginHorizontal();
    float lowPass4 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Lowpass4);
    float newLowpass4 = EditorGUILayout.Slider("lowPass4", lowPass4, 0.0f, 100.0f);
    if (lowPass4 != newLowpass4) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Lowpass4, newLowpass4);
    }
    GUILayout.EndHorizontal();

    // midiOffset1
    GUILayout.BeginHorizontal();
    float midiOffset1 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Midioffset1);
    float newMidioffset1 = EditorGUILayout.Slider("midiOffset1", midiOffset1, 40.0f, 69.0f);
    if (midiOffset1 != newMidioffset1) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Midioffset1, newMidioffset1);
    }
    GUILayout.EndHorizontal();

    // midiOffset2
    GUILayout.BeginHorizontal();
    float midiOffset2 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Midioffset2);
    float newMidioffset2 = EditorGUILayout.Slider("midiOffset2", midiOffset2, 40.0f, 69.0f);
    if (midiOffset2 != newMidioffset2) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Midioffset2, newMidioffset2);
    }
    GUILayout.EndHorizontal();

    // midiOffset3
    GUILayout.BeginHorizontal();
    float midiOffset3 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Midioffset3);
    float newMidioffset3 = EditorGUILayout.Slider("midiOffset3", midiOffset3, 40.0f, 69.0f);
    if (midiOffset3 != newMidioffset3) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Midioffset3, newMidioffset3);
    }
    GUILayout.EndHorizontal();

    // midiOffset4
    GUILayout.BeginHorizontal();
    float midiOffset4 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Midioffset4);
    float newMidioffset4 = EditorGUILayout.Slider("midiOffset4", midiOffset4, 40.0f, 69.0f);
    if (midiOffset4 != newMidioffset4) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Midioffset4, newMidioffset4);
    }
    GUILayout.EndHorizontal();

    // modFactor1
    GUILayout.BeginHorizontal();
    float modFactor1 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Modfactor1);
    float newModfactor1 = EditorGUILayout.Slider("modFactor1", modFactor1, 0.0f, 1000.0f);
    if (modFactor1 != newModfactor1) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Modfactor1, newModfactor1);
    }
    GUILayout.EndHorizontal();

    // modFactor2
    GUILayout.BeginHorizontal();
    float modFactor2 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Modfactor2);
    float newModfactor2 = EditorGUILayout.Slider("modFactor2", modFactor2, 0.0f, 1000.0f);
    if (modFactor2 != newModfactor2) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Modfactor2, newModfactor2);
    }
    GUILayout.EndHorizontal();

    // modFactor3
    GUILayout.BeginHorizontal();
    float modFactor3 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Modfactor3);
    float newModfactor3 = EditorGUILayout.Slider("modFactor3", modFactor3, 0.0f, 1000.0f);
    if (modFactor3 != newModfactor3) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Modfactor3, newModfactor3);
    }
    GUILayout.EndHorizontal();

    // modFactor4
    GUILayout.BeginHorizontal();
    float modFactor4 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Modfactor4);
    float newModfactor4 = EditorGUILayout.Slider("modFactor4", modFactor4, 0.0f, 1000.0f);
    if (modFactor4 != newModfactor4) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Modfactor4, newModfactor4);
    }
    GUILayout.EndHorizontal();

    // oscMix1
    GUILayout.BeginHorizontal();
    float oscMix1 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Oscmix1);
    float newOscmix1 = EditorGUILayout.Slider("oscMix1", oscMix1, 0.0f, 1.0f);
    if (oscMix1 != newOscmix1) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Oscmix1, newOscmix1);
    }
    GUILayout.EndHorizontal();

    // oscMix2
    GUILayout.BeginHorizontal();
    float oscMix2 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Oscmix2);
    float newOscmix2 = EditorGUILayout.Slider("oscMix2", oscMix2, 0.0f, 1.0f);
    if (oscMix2 != newOscmix2) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Oscmix2, newOscmix2);
    }
    GUILayout.EndHorizontal();

    // oscMix3
    GUILayout.BeginHorizontal();
    float oscMix3 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Oscmix3);
    float newOscmix3 = EditorGUILayout.Slider("oscMix3", oscMix3, 0.0f, 1.0f);
    if (oscMix3 != newOscmix3) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Oscmix3, newOscmix3);
    }
    GUILayout.EndHorizontal();

    // oscMix4
    GUILayout.BeginHorizontal();
    float oscMix4 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Oscmix4);
    float newOscmix4 = EditorGUILayout.Slider("oscMix4", oscMix4, 0.0f, 1.0f);
    if (oscMix4 != newOscmix4) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Oscmix4, newOscmix4);
    }
    GUILayout.EndHorizontal();

    // release1
    GUILayout.BeginHorizontal();
    float release1 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Release1);
    float newRelease1 = EditorGUILayout.Slider("release1", release1, 10.0f, 1000.0f);
    if (release1 != newRelease1) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Release1, newRelease1);
    }
    GUILayout.EndHorizontal();

    // release2
    GUILayout.BeginHorizontal();
    float release2 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Release2);
    float newRelease2 = EditorGUILayout.Slider("release2", release2, 10.0f, 1000.0f);
    if (release2 != newRelease2) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Release2, newRelease2);
    }
    GUILayout.EndHorizontal();

    // release3
    GUILayout.BeginHorizontal();
    float release3 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Release3);
    float newRelease3 = EditorGUILayout.Slider("release3", release3, 10.0f, 1000.0f);
    if (release3 != newRelease3) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Release3, newRelease3);
    }
    GUILayout.EndHorizontal();

    // release4
    GUILayout.BeginHorizontal();
    float release4 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Release4);
    float newRelease4 = EditorGUILayout.Slider("release4", release4, 10.0f, 1000.0f);
    if (release4 != newRelease4) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Release4, newRelease4);
    }
    GUILayout.EndHorizontal();

    // seq1_0
    GUILayout.BeginHorizontal();
    float seq1_0 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq1_0);
    float newSeq1_0 = EditorGUILayout.Slider("seq1_0", seq1_0, 0.0f, 11.0f);
    if (seq1_0 != newSeq1_0) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq1_0, newSeq1_0);
    }
    GUILayout.EndHorizontal();

    // seq1_1
    GUILayout.BeginHorizontal();
    float seq1_1 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq1_1);
    float newSeq1_1 = EditorGUILayout.Slider("seq1_1", seq1_1, 0.0f, 11.0f);
    if (seq1_1 != newSeq1_1) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq1_1, newSeq1_1);
    }
    GUILayout.EndHorizontal();

    // seq1_2
    GUILayout.BeginHorizontal();
    float seq1_2 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq1_2);
    float newSeq1_2 = EditorGUILayout.Slider("seq1_2", seq1_2, 0.0f, 11.0f);
    if (seq1_2 != newSeq1_2) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq1_2, newSeq1_2);
    }
    GUILayout.EndHorizontal();

    // seq1_3
    GUILayout.BeginHorizontal();
    float seq1_3 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq1_3);
    float newSeq1_3 = EditorGUILayout.Slider("seq1_3", seq1_3, 0.0f, 11.0f);
    if (seq1_3 != newSeq1_3) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq1_3, newSeq1_3);
    }
    GUILayout.EndHorizontal();

    // seq1_4
    GUILayout.BeginHorizontal();
    float seq1_4 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq1_4);
    float newSeq1_4 = EditorGUILayout.Slider("seq1_4", seq1_4, 0.0f, 11.0f);
    if (seq1_4 != newSeq1_4) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq1_4, newSeq1_4);
    }
    GUILayout.EndHorizontal();

    // seq1_5
    GUILayout.BeginHorizontal();
    float seq1_5 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq1_5);
    float newSeq1_5 = EditorGUILayout.Slider("seq1_5", seq1_5, 0.0f, 11.0f);
    if (seq1_5 != newSeq1_5) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq1_5, newSeq1_5);
    }
    GUILayout.EndHorizontal();

    // seq1_6
    GUILayout.BeginHorizontal();
    float seq1_6 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq1_6);
    float newSeq1_6 = EditorGUILayout.Slider("seq1_6", seq1_6, 0.0f, 11.0f);
    if (seq1_6 != newSeq1_6) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq1_6, newSeq1_6);
    }
    GUILayout.EndHorizontal();

    // seq1_7
    GUILayout.BeginHorizontal();
    float seq1_7 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq1_7);
    float newSeq1_7 = EditorGUILayout.Slider("seq1_7", seq1_7, 0.0f, 11.0f);
    if (seq1_7 != newSeq1_7) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq1_7, newSeq1_7);
    }
    GUILayout.EndHorizontal();

    // seq2_0
    GUILayout.BeginHorizontal();
    float seq2_0 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq2_0);
    float newSeq2_0 = EditorGUILayout.Slider("seq2_0", seq2_0, 0.0f, 11.0f);
    if (seq2_0 != newSeq2_0) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq2_0, newSeq2_0);
    }
    GUILayout.EndHorizontal();

    // seq2_1
    GUILayout.BeginHorizontal();
    float seq2_1 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq2_1);
    float newSeq2_1 = EditorGUILayout.Slider("seq2_1", seq2_1, 0.0f, 11.0f);
    if (seq2_1 != newSeq2_1) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq2_1, newSeq2_1);
    }
    GUILayout.EndHorizontal();

    // seq2_2
    GUILayout.BeginHorizontal();
    float seq2_2 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq2_2);
    float newSeq2_2 = EditorGUILayout.Slider("seq2_2", seq2_2, 0.0f, 11.0f);
    if (seq2_2 != newSeq2_2) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq2_2, newSeq2_2);
    }
    GUILayout.EndHorizontal();

    // seq2_3
    GUILayout.BeginHorizontal();
    float seq2_3 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq2_3);
    float newSeq2_3 = EditorGUILayout.Slider("seq2_3", seq2_3, 0.0f, 11.0f);
    if (seq2_3 != newSeq2_3) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq2_3, newSeq2_3);
    }
    GUILayout.EndHorizontal();

    // seq2_4
    GUILayout.BeginHorizontal();
    float seq2_4 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq2_4);
    float newSeq2_4 = EditorGUILayout.Slider("seq2_4", seq2_4, 0.0f, 11.0f);
    if (seq2_4 != newSeq2_4) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq2_4, newSeq2_4);
    }
    GUILayout.EndHorizontal();

    // seq2_5
    GUILayout.BeginHorizontal();
    float seq2_5 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq2_5);
    float newSeq2_5 = EditorGUILayout.Slider("seq2_5", seq2_5, 0.0f, 11.0f);
    if (seq2_5 != newSeq2_5) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq2_5, newSeq2_5);
    }
    GUILayout.EndHorizontal();

    // seq2_6
    GUILayout.BeginHorizontal();
    float seq2_6 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq2_6);
    float newSeq2_6 = EditorGUILayout.Slider("seq2_6", seq2_6, 0.0f, 11.0f);
    if (seq2_6 != newSeq2_6) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq2_6, newSeq2_6);
    }
    GUILayout.EndHorizontal();

    // seq2_7
    GUILayout.BeginHorizontal();
    float seq2_7 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq2_7);
    float newSeq2_7 = EditorGUILayout.Slider("seq2_7", seq2_7, 0.0f, 11.0f);
    if (seq2_7 != newSeq2_7) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq2_7, newSeq2_7);
    }
    GUILayout.EndHorizontal();

    // seq3_0
    GUILayout.BeginHorizontal();
    float seq3_0 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq3_0);
    float newSeq3_0 = EditorGUILayout.Slider("seq3_0", seq3_0, 0.0f, 11.0f);
    if (seq3_0 != newSeq3_0) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq3_0, newSeq3_0);
    }
    GUILayout.EndHorizontal();

    // seq3_1
    GUILayout.BeginHorizontal();
    float seq3_1 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq3_1);
    float newSeq3_1 = EditorGUILayout.Slider("seq3_1", seq3_1, 0.0f, 11.0f);
    if (seq3_1 != newSeq3_1) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq3_1, newSeq3_1);
    }
    GUILayout.EndHorizontal();

    // seq3_2
    GUILayout.BeginHorizontal();
    float seq3_2 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq3_2);
    float newSeq3_2 = EditorGUILayout.Slider("seq3_2", seq3_2, 0.0f, 11.0f);
    if (seq3_2 != newSeq3_2) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq3_2, newSeq3_2);
    }
    GUILayout.EndHorizontal();

    // seq3_3
    GUILayout.BeginHorizontal();
    float seq3_3 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq3_3);
    float newSeq3_3 = EditorGUILayout.Slider("seq3_3", seq3_3, 0.0f, 11.0f);
    if (seq3_3 != newSeq3_3) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq3_3, newSeq3_3);
    }
    GUILayout.EndHorizontal();

    // seq3_4
    GUILayout.BeginHorizontal();
    float seq3_4 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq3_4);
    float newSeq3_4 = EditorGUILayout.Slider("seq3_4", seq3_4, 0.0f, 11.0f);
    if (seq3_4 != newSeq3_4) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq3_4, newSeq3_4);
    }
    GUILayout.EndHorizontal();

    // seq3_5
    GUILayout.BeginHorizontal();
    float seq3_5 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq3_5);
    float newSeq3_5 = EditorGUILayout.Slider("seq3_5", seq3_5, 0.0f, 11.0f);
    if (seq3_5 != newSeq3_5) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq3_5, newSeq3_5);
    }
    GUILayout.EndHorizontal();

    // seq3_6
    GUILayout.BeginHorizontal();
    float seq3_6 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq3_6);
    float newSeq3_6 = EditorGUILayout.Slider("seq3_6", seq3_6, 0.0f, 11.0f);
    if (seq3_6 != newSeq3_6) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq3_6, newSeq3_6);
    }
    GUILayout.EndHorizontal();

    // seq3_7
    GUILayout.BeginHorizontal();
    float seq3_7 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq3_7);
    float newSeq3_7 = EditorGUILayout.Slider("seq3_7", seq3_7, 0.0f, 11.0f);
    if (seq3_7 != newSeq3_7) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq3_7, newSeq3_7);
    }
    GUILayout.EndHorizontal();

    // seq4_0
    GUILayout.BeginHorizontal();
    float seq4_0 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq4_0);
    float newSeq4_0 = EditorGUILayout.Slider("seq4_0", seq4_0, 0.0f, 11.0f);
    if (seq4_0 != newSeq4_0) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq4_0, newSeq4_0);
    }
    GUILayout.EndHorizontal();

    // seq4_1
    GUILayout.BeginHorizontal();
    float seq4_1 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq4_1);
    float newSeq4_1 = EditorGUILayout.Slider("seq4_1", seq4_1, 0.0f, 11.0f);
    if (seq4_1 != newSeq4_1) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq4_1, newSeq4_1);
    }
    GUILayout.EndHorizontal();

    // seq4_2
    GUILayout.BeginHorizontal();
    float seq4_2 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq4_2);
    float newSeq4_2 = EditorGUILayout.Slider("seq4_2", seq4_2, 0.0f, 11.0f);
    if (seq4_2 != newSeq4_2) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq4_2, newSeq4_2);
    }
    GUILayout.EndHorizontal();

    // seq4_3
    GUILayout.BeginHorizontal();
    float seq4_3 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq4_3);
    float newSeq4_3 = EditorGUILayout.Slider("seq4_3", seq4_3, 0.0f, 11.0f);
    if (seq4_3 != newSeq4_3) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq4_3, newSeq4_3);
    }
    GUILayout.EndHorizontal();

    // seq4_4
    GUILayout.BeginHorizontal();
    float seq4_4 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq4_4);
    float newSeq4_4 = EditorGUILayout.Slider("seq4_4", seq4_4, 0.0f, 11.0f);
    if (seq4_4 != newSeq4_4) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq4_4, newSeq4_4);
    }
    GUILayout.EndHorizontal();

    // seq4_5
    GUILayout.BeginHorizontal();
    float seq4_5 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq4_5);
    float newSeq4_5 = EditorGUILayout.Slider("seq4_5", seq4_5, 0.0f, 11.0f);
    if (seq4_5 != newSeq4_5) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq4_5, newSeq4_5);
    }
    GUILayout.EndHorizontal();

    // seq4_6
    GUILayout.BeginHorizontal();
    float seq4_6 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq4_6);
    float newSeq4_6 = EditorGUILayout.Slider("seq4_6", seq4_6, 0.0f, 11.0f);
    if (seq4_6 != newSeq4_6) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq4_6, newSeq4_6);
    }
    GUILayout.EndHorizontal();

    // seq4_7
    GUILayout.BeginHorizontal();
    float seq4_7 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq4_7);
    float newSeq4_7 = EditorGUILayout.Slider("seq4_7", seq4_7, 0.0f, 11.0f);
    if (seq4_7 != newSeq4_7) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Seq4_7, newSeq4_7);
    }
    GUILayout.EndHorizontal();

    // squareMix1
    GUILayout.BeginHorizontal();
    float squareMix1 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Squaremix1);
    float newSquaremix1 = EditorGUILayout.Slider("squareMix1", squareMix1, 0.0f, 1.0f);
    if (squareMix1 != newSquaremix1) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Squaremix1, newSquaremix1);
    }
    GUILayout.EndHorizontal();

    // squareMix2
    GUILayout.BeginHorizontal();
    float squareMix2 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Squaremix2);
    float newSquaremix2 = EditorGUILayout.Slider("squareMix2", squareMix2, 0.0f, 1.0f);
    if (squareMix2 != newSquaremix2) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Squaremix2, newSquaremix2);
    }
    GUILayout.EndHorizontal();

    // squareMix3
    GUILayout.BeginHorizontal();
    float squareMix3 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Squaremix3);
    float newSquaremix3 = EditorGUILayout.Slider("squareMix3", squareMix3, 0.0f, 1.0f);
    if (squareMix3 != newSquaremix3) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Squaremix3, newSquaremix3);
    }
    GUILayout.EndHorizontal();

    // squareMix4
    GUILayout.BeginHorizontal();
    float squareMix4 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Squaremix4);
    float newSquaremix4 = EditorGUILayout.Slider("squareMix4", squareMix4, 0.0f, 1.0f);
    if (squareMix4 != newSquaremix4) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Squaremix4, newSquaremix4);
    }
    GUILayout.EndHorizontal();

    // sustain1
    GUILayout.BeginHorizontal();
    float sustain1 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Sustain1);
    float newSustain1 = EditorGUILayout.Slider("sustain1", sustain1, 0.0f, 1.0f);
    if (sustain1 != newSustain1) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Sustain1, newSustain1);
    }
    GUILayout.EndHorizontal();

    // sustain2
    GUILayout.BeginHorizontal();
    float sustain2 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Sustain2);
    float newSustain2 = EditorGUILayout.Slider("sustain2", sustain2, 0.0f, 1.0f);
    if (sustain2 != newSustain2) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Sustain2, newSustain2);
    }
    GUILayout.EndHorizontal();

    // sustain3
    GUILayout.BeginHorizontal();
    float sustain3 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Sustain3);
    float newSustain3 = EditorGUILayout.Slider("sustain3", sustain3, 0.0f, 1.0f);
    if (sustain3 != newSustain3) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Sustain3, newSustain3);
    }
    GUILayout.EndHorizontal();

    // sustain4
    GUILayout.BeginHorizontal();
    float sustain4 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Sustain4);
    float newSustain4 = EditorGUILayout.Slider("sustain4", sustain4, 0.0f, 1.0f);
    if (sustain4 != newSustain4) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Sustain4, newSustain4);
    }
    GUILayout.EndHorizontal();

    // vol1
    GUILayout.BeginHorizontal();
    float vol1 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Vol1);
    float newVol1 = EditorGUILayout.Slider("vol1", vol1, 0.0f, 1.0f);
    if (vol1 != newVol1) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Vol1, newVol1);
    }
    GUILayout.EndHorizontal();

    // vol2
    GUILayout.BeginHorizontal();
    float vol2 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Vol2);
    float newVol2 = EditorGUILayout.Slider("vol2", vol2, 0.0f, 1.0f);
    if (vol2 != newVol2) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Vol2, newVol2);
    }
    GUILayout.EndHorizontal();

    // vol3
    GUILayout.BeginHorizontal();
    float vol3 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Vol3);
    float newVol3 = EditorGUILayout.Slider("vol3", vol3, 0.0f, 1.0f);
    if (vol3 != newVol3) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Vol3, newVol3);
    }
    GUILayout.EndHorizontal();

    // vol4
    GUILayout.BeginHorizontal();
    float vol4 = _dsp.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Vol4);
    float newVol4 = EditorGUILayout.Slider("vol4", vol4, 0.0f, 1.0f);
    if (vol4 != newVol4) {
      _dsp.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Vol4, newVol4);
    }
    GUILayout.EndHorizontal();

    EditorGUI.indentLevel--;

    

    GUILayout.EndVertical();
  }
}
#endif // UNITY_EDITOR

[RequireComponent (typeof (AudioSource))]
public class Hv_UnitySynth_AudioLib : MonoBehaviour {
  
  // Parameters are used to send float messages into the patch context (thread-safe).
  // Example usage:
  /*
    void Start () {
        Hv_UnitySynth_AudioLib script = GetComponent<Hv_UnitySynth_AudioLib>();
        // Get and set a parameter
        float attack1 = script.GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Attack1);
        script.SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter.Attack1, attack1 + 0.1f);
    }
  */
  public enum Parameter : uint {
    Attack1 = 0x3730E229,
    Attack2 = 0xF3436A8,
    Attack3 = 0x4FDF3867,
    Attack4 = 0xEFD61BFF,
    Decay1 = 0x24E71758,
    Decay2 = 0x66E0438,
    Decay3 = 0x5F649BDB,
    Decay4 = 0x531ECD44,
    Freqmod1 = 0x369491C8,
    Freqmod2 = 0x738741C9,
    Freqmod3 = 0xCE368D61,
    Freqmod4 = 0x4AEA4D4B,
    Highpass1 = 0xBBF7EC20,
    Highpass2 = 0xA15A2873,
    Highpass3 = 0x183E7505,
    Highpass4 = 0x1BFDDB1D,
    Lowpass1 = 0xEA376D51,
    Lowpass2 = 0xDB8990D5,
    Lowpass3 = 0x12278DB7,
    Lowpass4 = 0x3B1D0479,
    Midioffset1 = 0x4B6BCD0D,
    Midioffset2 = 0x4D9F69BC,
    Midioffset3 = 0x1ED0FCAA,
    Midioffset4 = 0xAE6813E,
    Modfactor1 = 0xD791982D,
    Modfactor2 = 0x9DCECDED,
    Modfactor3 = 0x737DCDA4,
    Modfactor4 = 0x60A3E030,
    Oscmix1 = 0xF1A0BE56,
    Oscmix2 = 0xFF49CCFC,
    Oscmix3 = 0xADDDD41D,
    Oscmix4 = 0x9BB0539E,
    Release1 = 0x9D19E9DF,
    Release2 = 0x9CA5B2E4,
    Release3 = 0xB0D9A93F,
    Release4 = 0x542B0541,
    Seq1_0 = 0xDDDEF495,
    Seq1_1 = 0x2E50A6FB,
    Seq1_2 = 0xF2C23923,
    Seq1_3 = 0xBF99DB39,
    Seq1_4 = 0x4AF05E69,
    Seq1_5 = 0x767A1519,
    Seq1_6 = 0xB346BFB1,
    Seq1_7 = 0x4E6ADD6D,
    Seq2_0 = 0x493A23BA,
    Seq2_1 = 0x4C380B71,
    Seq2_2 = 0x4EAD1D8A,
    Seq2_3 = 0x35F9071F,
    Seq2_4 = 0x3B4BD382,
    Seq2_5 = 0x20CA14C5,
    Seq2_6 = 0x7B509FA2,
    Seq2_7 = 0xCC9ECF0D,
    Seq3_0 = 0xEBA9CA72,
    Seq3_1 = 0x8EDC6D34,
    Seq3_2 = 0x65DD2484,
    Seq3_3 = 0x24824B34,
    Seq3_4 = 0x6F1090BC,
    Seq3_5 = 0x77F588E7,
    Seq3_6 = 0xB6D4E3A5,
    Seq3_7 = 0x8E90C209,
    Seq4_0 = 0xEC014965,
    Seq4_1 = 0x5B9F9D8B,
    Seq4_2 = 0xB32D50A3,
    Seq4_3 = 0xAA09F6A6,
    Seq4_4 = 0xBEE4ECD5,
    Seq4_5 = 0x3167C515,
    Seq4_6 = 0xB9BB34F,
    Seq4_7 = 0xB8D3C63,
    Squaremix1 = 0x74044860,
    Squaremix2 = 0xBCD4BEA5,
    Squaremix3 = 0xF278B3D,
    Squaremix4 = 0xEEA9317B,
    Sustain1 = 0x12388DE0,
    Sustain2 = 0x2A64D1A4,
    Sustain3 = 0x6DC638EA,
    Sustain4 = 0xA768C050,
    Vol1 = 0xB5338AD1,
    Vol2 = 0xD595CC91,
    Vol3 = 0x99516142,
    Vol4 = 0x7BCC8D1D,
  }
  
  // Delegate method for receiving float messages from the patch context (thread-safe).
  // Example usage:
  /*
    void Start () {
        Hv_UnitySynth_AudioLib script = GetComponent<Hv_UnitySynth_AudioLib>();
        script.RegisterSendHook();
        script.FloatReceivedCallback += OnFloatMessage;
    }

    void OnFloatMessage(Hv_UnitySynth_AudioLib.FloatMessage message) {
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
  public float attack1 = 10.0f;
  public float attack2 = 10.0f;
  public float attack3 = 10.0f;
  public float attack4 = 10.0f;
  public float decay1 = 150.0f;
  public float decay2 = 150.0f;
  public float decay3 = 150.0f;
  public float decay4 = 150.0f;
  public float freqMod1 = 0.0f;
  public float freqMod2 = 0.0f;
  public float freqMod3 = 0.0f;
  public float freqMod4 = 0.0f;
  public float highPass1 = 0.0f;
  public float highPass2 = 0.0f;
  public float highPass3 = 0.0f;
  public float highPass4 = 0.0f;
  public float lowPass1 = 100.0f;
  public float lowPass2 = 100.0f;
  public float lowPass3 = 100.0f;
  public float lowPass4 = 100.0f;
  public float midiOffset1 = 50.0f;
  public float midiOffset2 = 50.0f;
  public float midiOffset3 = 50.0f;
  public float midiOffset4 = 50.0f;
  public float modFactor1 = 0.0f;
  public float modFactor2 = 0.0f;
  public float modFactor3 = 0.0f;
  public float modFactor4 = 0.0f;
  public float oscMix1 = 0.0f;
  public float oscMix2 = 0.0f;
  public float oscMix3 = 0.0f;
  public float oscMix4 = 0.0f;
  public float release1 = 150.0f;
  public float release2 = 150.0f;
  public float release3 = 150.0f;
  public float release4 = 150.0f;
  public float seq1_0 = 0.0f;
  public float seq1_1 = 4.0f;
  public float seq1_2 = 7.0f;
  public float seq1_3 = 11.0f;
  public float seq1_4 = 7.0f;
  public float seq1_5 = 4.0f;
  public float seq1_6 = 0.0f;
  public float seq1_7 = 4.0f;
  public float seq2_0 = 0.0f;
  public float seq2_1 = 4.0f;
  public float seq2_2 = 7.0f;
  public float seq2_3 = 11.0f;
  public float seq2_4 = 7.0f;
  public float seq2_5 = 4.0f;
  public float seq2_6 = 0.0f;
  public float seq2_7 = 4.0f;
  public float seq3_0 = 0.0f;
  public float seq3_1 = 4.0f;
  public float seq3_2 = 7.0f;
  public float seq3_3 = 11.0f;
  public float seq3_4 = 7.0f;
  public float seq3_5 = 4.0f;
  public float seq3_6 = 0.0f;
  public float seq3_7 = 4.0f;
  public float seq4_0 = 0.0f;
  public float seq4_1 = 4.0f;
  public float seq4_2 = 7.0f;
  public float seq4_3 = 11.0f;
  public float seq4_4 = 7.0f;
  public float seq4_5 = 4.0f;
  public float seq4_6 = 0.0f;
  public float seq4_7 = 4.0f;
  public float squareMix1 = 1.0f;
  public float squareMix2 = 1.0f;
  public float squareMix3 = 1.0f;
  public float squareMix4 = 1.0f;
  public float sustain1 = 0.5f;
  public float sustain2 = 0.5f;
  public float sustain3 = 0.5f;
  public float sustain4 = 0.5f;
  public float vol1 = 0.1f;
  public float vol2 = 0.1f;
  public float vol3 = 0.1f;
  public float vol4 = 0.1f;

  // internal state
  private Hv_UnitySynth_Context _context;

  public bool IsInstantiated() {
    return (_context != null);
  }

  public void RegisterSendHook() {
    _context.RegisterSendHook();
  }
  
  // see Hv_UnitySynth_AudioLib.Parameter for definitions
  public float GetFloatParameter(Hv_UnitySynth_AudioLib.Parameter param) {
    switch (param) {
      case Parameter.Attack1: return attack1;
      case Parameter.Attack2: return attack2;
      case Parameter.Attack3: return attack3;
      case Parameter.Attack4: return attack4;
      case Parameter.Decay1: return decay1;
      case Parameter.Decay2: return decay2;
      case Parameter.Decay3: return decay3;
      case Parameter.Decay4: return decay4;
      case Parameter.Freqmod1: return freqMod1;
      case Parameter.Freqmod2: return freqMod2;
      case Parameter.Freqmod3: return freqMod3;
      case Parameter.Freqmod4: return freqMod4;
      case Parameter.Highpass1: return highPass1;
      case Parameter.Highpass2: return highPass2;
      case Parameter.Highpass3: return highPass3;
      case Parameter.Highpass4: return highPass4;
      case Parameter.Lowpass1: return lowPass1;
      case Parameter.Lowpass2: return lowPass2;
      case Parameter.Lowpass3: return lowPass3;
      case Parameter.Lowpass4: return lowPass4;
      case Parameter.Midioffset1: return midiOffset1;
      case Parameter.Midioffset2: return midiOffset2;
      case Parameter.Midioffset3: return midiOffset3;
      case Parameter.Midioffset4: return midiOffset4;
      case Parameter.Modfactor1: return modFactor1;
      case Parameter.Modfactor2: return modFactor2;
      case Parameter.Modfactor3: return modFactor3;
      case Parameter.Modfactor4: return modFactor4;
      case Parameter.Oscmix1: return oscMix1;
      case Parameter.Oscmix2: return oscMix2;
      case Parameter.Oscmix3: return oscMix3;
      case Parameter.Oscmix4: return oscMix4;
      case Parameter.Release1: return release1;
      case Parameter.Release2: return release2;
      case Parameter.Release3: return release3;
      case Parameter.Release4: return release4;
      case Parameter.Seq1_0: return seq1_0;
      case Parameter.Seq1_1: return seq1_1;
      case Parameter.Seq1_2: return seq1_2;
      case Parameter.Seq1_3: return seq1_3;
      case Parameter.Seq1_4: return seq1_4;
      case Parameter.Seq1_5: return seq1_5;
      case Parameter.Seq1_6: return seq1_6;
      case Parameter.Seq1_7: return seq1_7;
      case Parameter.Seq2_0: return seq2_0;
      case Parameter.Seq2_1: return seq2_1;
      case Parameter.Seq2_2: return seq2_2;
      case Parameter.Seq2_3: return seq2_3;
      case Parameter.Seq2_4: return seq2_4;
      case Parameter.Seq2_5: return seq2_5;
      case Parameter.Seq2_6: return seq2_6;
      case Parameter.Seq2_7: return seq2_7;
      case Parameter.Seq3_0: return seq3_0;
      case Parameter.Seq3_1: return seq3_1;
      case Parameter.Seq3_2: return seq3_2;
      case Parameter.Seq3_3: return seq3_3;
      case Parameter.Seq3_4: return seq3_4;
      case Parameter.Seq3_5: return seq3_5;
      case Parameter.Seq3_6: return seq3_6;
      case Parameter.Seq3_7: return seq3_7;
      case Parameter.Seq4_0: return seq4_0;
      case Parameter.Seq4_1: return seq4_1;
      case Parameter.Seq4_2: return seq4_2;
      case Parameter.Seq4_3: return seq4_3;
      case Parameter.Seq4_4: return seq4_4;
      case Parameter.Seq4_5: return seq4_5;
      case Parameter.Seq4_6: return seq4_6;
      case Parameter.Seq4_7: return seq4_7;
      case Parameter.Squaremix1: return squareMix1;
      case Parameter.Squaremix2: return squareMix2;
      case Parameter.Squaremix3: return squareMix3;
      case Parameter.Squaremix4: return squareMix4;
      case Parameter.Sustain1: return sustain1;
      case Parameter.Sustain2: return sustain2;
      case Parameter.Sustain3: return sustain3;
      case Parameter.Sustain4: return sustain4;
      case Parameter.Vol1: return vol1;
      case Parameter.Vol2: return vol2;
      case Parameter.Vol3: return vol3;
      case Parameter.Vol4: return vol4;
      default: return 0.0f;
    }
  }

  public void SetFloatParameter(Hv_UnitySynth_AudioLib.Parameter param, float x) {
    switch (param) {
      case Parameter.Attack1: {
        x = Mathf.Clamp(x, 10.0f, 1000.0f);
        attack1 = x;
        break;
      }
      case Parameter.Attack2: {
        x = Mathf.Clamp(x, 10.0f, 1000.0f);
        attack2 = x;
        break;
      }
      case Parameter.Attack3: {
        x = Mathf.Clamp(x, 10.0f, 1000.0f);
        attack3 = x;
        break;
      }
      case Parameter.Attack4: {
        x = Mathf.Clamp(x, 10.0f, 1000.0f);
        attack4 = x;
        break;
      }
      case Parameter.Decay1: {
        x = Mathf.Clamp(x, 10.0f, 1000.0f);
        decay1 = x;
        break;
      }
      case Parameter.Decay2: {
        x = Mathf.Clamp(x, 10.0f, 1000.0f);
        decay2 = x;
        break;
      }
      case Parameter.Decay3: {
        x = Mathf.Clamp(x, 10.0f, 1000.0f);
        decay3 = x;
        break;
      }
      case Parameter.Decay4: {
        x = Mathf.Clamp(x, 10.0f, 1000.0f);
        decay4 = x;
        break;
      }
      case Parameter.Freqmod1: {
        x = Mathf.Clamp(x, 0.0f, 1000.0f);
        freqMod1 = x;
        break;
      }
      case Parameter.Freqmod2: {
        x = Mathf.Clamp(x, 0.0f, 1000.0f);
        freqMod2 = x;
        break;
      }
      case Parameter.Freqmod3: {
        x = Mathf.Clamp(x, 0.0f, 1000.0f);
        freqMod3 = x;
        break;
      }
      case Parameter.Freqmod4: {
        x = Mathf.Clamp(x, 0.0f, 1000.0f);
        freqMod4 = x;
        break;
      }
      case Parameter.Highpass1: {
        x = Mathf.Clamp(x, 0.0f, 2000.0f);
        highPass1 = x;
        break;
      }
      case Parameter.Highpass2: {
        x = Mathf.Clamp(x, 0.0f, 2000.0f);
        highPass2 = x;
        break;
      }
      case Parameter.Highpass3: {
        x = Mathf.Clamp(x, 0.0f, 2000.0f);
        highPass3 = x;
        break;
      }
      case Parameter.Highpass4: {
        x = Mathf.Clamp(x, 0.0f, 2000.0f);
        highPass4 = x;
        break;
      }
      case Parameter.Lowpass1: {
        x = Mathf.Clamp(x, 0.0f, 100.0f);
        lowPass1 = x;
        break;
      }
      case Parameter.Lowpass2: {
        x = Mathf.Clamp(x, 0.0f, 100.0f);
        lowPass2 = x;
        break;
      }
      case Parameter.Lowpass3: {
        x = Mathf.Clamp(x, 0.0f, 100.0f);
        lowPass3 = x;
        break;
      }
      case Parameter.Lowpass4: {
        x = Mathf.Clamp(x, 0.0f, 100.0f);
        lowPass4 = x;
        break;
      }
      case Parameter.Midioffset1: {
        x = Mathf.Clamp(x, 40.0f, 69.0f);
        midiOffset1 = x;
        break;
      }
      case Parameter.Midioffset2: {
        x = Mathf.Clamp(x, 40.0f, 69.0f);
        midiOffset2 = x;
        break;
      }
      case Parameter.Midioffset3: {
        x = Mathf.Clamp(x, 40.0f, 69.0f);
        midiOffset3 = x;
        break;
      }
      case Parameter.Midioffset4: {
        x = Mathf.Clamp(x, 40.0f, 69.0f);
        midiOffset4 = x;
        break;
      }
      case Parameter.Modfactor1: {
        x = Mathf.Clamp(x, 0.0f, 1000.0f);
        modFactor1 = x;
        break;
      }
      case Parameter.Modfactor2: {
        x = Mathf.Clamp(x, 0.0f, 1000.0f);
        modFactor2 = x;
        break;
      }
      case Parameter.Modfactor3: {
        x = Mathf.Clamp(x, 0.0f, 1000.0f);
        modFactor3 = x;
        break;
      }
      case Parameter.Modfactor4: {
        x = Mathf.Clamp(x, 0.0f, 1000.0f);
        modFactor4 = x;
        break;
      }
      case Parameter.Oscmix1: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        oscMix1 = x;
        break;
      }
      case Parameter.Oscmix2: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        oscMix2 = x;
        break;
      }
      case Parameter.Oscmix3: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        oscMix3 = x;
        break;
      }
      case Parameter.Oscmix4: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        oscMix4 = x;
        break;
      }
      case Parameter.Release1: {
        x = Mathf.Clamp(x, 10.0f, 1000.0f);
        release1 = x;
        break;
      }
      case Parameter.Release2: {
        x = Mathf.Clamp(x, 10.0f, 1000.0f);
        release2 = x;
        break;
      }
      case Parameter.Release3: {
        x = Mathf.Clamp(x, 10.0f, 1000.0f);
        release3 = x;
        break;
      }
      case Parameter.Release4: {
        x = Mathf.Clamp(x, 10.0f, 1000.0f);
        release4 = x;
        break;
      }
      case Parameter.Seq1_0: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq1_0 = x;
        break;
      }
      case Parameter.Seq1_1: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq1_1 = x;
        break;
      }
      case Parameter.Seq1_2: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq1_2 = x;
        break;
      }
      case Parameter.Seq1_3: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq1_3 = x;
        break;
      }
      case Parameter.Seq1_4: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq1_4 = x;
        break;
      }
      case Parameter.Seq1_5: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq1_5 = x;
        break;
      }
      case Parameter.Seq1_6: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq1_6 = x;
        break;
      }
      case Parameter.Seq1_7: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq1_7 = x;
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
      case Parameter.Seq3_0: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq3_0 = x;
        break;
      }
      case Parameter.Seq3_1: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq3_1 = x;
        break;
      }
      case Parameter.Seq3_2: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq3_2 = x;
        break;
      }
      case Parameter.Seq3_3: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq3_3 = x;
        break;
      }
      case Parameter.Seq3_4: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq3_4 = x;
        break;
      }
      case Parameter.Seq3_5: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq3_5 = x;
        break;
      }
      case Parameter.Seq3_6: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq3_6 = x;
        break;
      }
      case Parameter.Seq3_7: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq3_7 = x;
        break;
      }
      case Parameter.Seq4_0: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq4_0 = x;
        break;
      }
      case Parameter.Seq4_1: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq4_1 = x;
        break;
      }
      case Parameter.Seq4_2: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq4_2 = x;
        break;
      }
      case Parameter.Seq4_3: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq4_3 = x;
        break;
      }
      case Parameter.Seq4_4: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq4_4 = x;
        break;
      }
      case Parameter.Seq4_5: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq4_5 = x;
        break;
      }
      case Parameter.Seq4_6: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq4_6 = x;
        break;
      }
      case Parameter.Seq4_7: {
        x = Mathf.Clamp(x, 0.0f, 11.0f);
        seq4_7 = x;
        break;
      }
      case Parameter.Squaremix1: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        squareMix1 = x;
        break;
      }
      case Parameter.Squaremix2: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        squareMix2 = x;
        break;
      }
      case Parameter.Squaremix3: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        squareMix3 = x;
        break;
      }
      case Parameter.Squaremix4: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        squareMix4 = x;
        break;
      }
      case Parameter.Sustain1: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        sustain1 = x;
        break;
      }
      case Parameter.Sustain2: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        sustain2 = x;
        break;
      }
      case Parameter.Sustain3: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        sustain3 = x;
        break;
      }
      case Parameter.Sustain4: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        sustain4 = x;
        break;
      }
      case Parameter.Vol1: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        vol1 = x;
        break;
      }
      case Parameter.Vol2: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        vol2 = x;
        break;
      }
      case Parameter.Vol3: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        vol3 = x;
        break;
      }
      case Parameter.Vol4: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        vol4 = x;
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
      Debug.LogWarning("Hv_UnitySynth_AudioLib: Only loading first channel of '" +
          clip.name + "' into table '" +
          tableName + "'. Multi-channel files are not supported.");
    }
    float[] buffer = new float[clip.samples]; // copy only the 1st channel
    clip.GetData(buffer, 0);
    _context.FillTableWithFloatBuffer(StringToHash(tableName), buffer);
  }

  public void FillTableWithMonoAudioClip(uint tableHash, AudioClip clip) {
    if (clip.channels > 1) {
      Debug.LogWarning("Hv_UnitySynth_AudioLib: Only loading first channel of '" +
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
    _context = new Hv_UnitySynth_Context((double) AudioSettings.outputSampleRate);
    
  }
  
  private void Start() {
    _context.SendFloatToReceiver((uint) Parameter.Attack1, attack1);
    _context.SendFloatToReceiver((uint) Parameter.Attack2, attack2);
    _context.SendFloatToReceiver((uint) Parameter.Attack3, attack3);
    _context.SendFloatToReceiver((uint) Parameter.Attack4, attack4);
    _context.SendFloatToReceiver((uint) Parameter.Decay1, decay1);
    _context.SendFloatToReceiver((uint) Parameter.Decay2, decay2);
    _context.SendFloatToReceiver((uint) Parameter.Decay3, decay3);
    _context.SendFloatToReceiver((uint) Parameter.Decay4, decay4);
    _context.SendFloatToReceiver((uint) Parameter.Freqmod1, freqMod1);
    _context.SendFloatToReceiver((uint) Parameter.Freqmod2, freqMod2);
    _context.SendFloatToReceiver((uint) Parameter.Freqmod3, freqMod3);
    _context.SendFloatToReceiver((uint) Parameter.Freqmod4, freqMod4);
    _context.SendFloatToReceiver((uint) Parameter.Highpass1, highPass1);
    _context.SendFloatToReceiver((uint) Parameter.Highpass2, highPass2);
    _context.SendFloatToReceiver((uint) Parameter.Highpass3, highPass3);
    _context.SendFloatToReceiver((uint) Parameter.Highpass4, highPass4);
    _context.SendFloatToReceiver((uint) Parameter.Lowpass1, lowPass1);
    _context.SendFloatToReceiver((uint) Parameter.Lowpass2, lowPass2);
    _context.SendFloatToReceiver((uint) Parameter.Lowpass3, lowPass3);
    _context.SendFloatToReceiver((uint) Parameter.Lowpass4, lowPass4);
    _context.SendFloatToReceiver((uint) Parameter.Midioffset1, midiOffset1);
    _context.SendFloatToReceiver((uint) Parameter.Midioffset2, midiOffset2);
    _context.SendFloatToReceiver((uint) Parameter.Midioffset3, midiOffset3);
    _context.SendFloatToReceiver((uint) Parameter.Midioffset4, midiOffset4);
    _context.SendFloatToReceiver((uint) Parameter.Modfactor1, modFactor1);
    _context.SendFloatToReceiver((uint) Parameter.Modfactor2, modFactor2);
    _context.SendFloatToReceiver((uint) Parameter.Modfactor3, modFactor3);
    _context.SendFloatToReceiver((uint) Parameter.Modfactor4, modFactor4);
    _context.SendFloatToReceiver((uint) Parameter.Oscmix1, oscMix1);
    _context.SendFloatToReceiver((uint) Parameter.Oscmix2, oscMix2);
    _context.SendFloatToReceiver((uint) Parameter.Oscmix3, oscMix3);
    _context.SendFloatToReceiver((uint) Parameter.Oscmix4, oscMix4);
    _context.SendFloatToReceiver((uint) Parameter.Release1, release1);
    _context.SendFloatToReceiver((uint) Parameter.Release2, release2);
    _context.SendFloatToReceiver((uint) Parameter.Release3, release3);
    _context.SendFloatToReceiver((uint) Parameter.Release4, release4);
    _context.SendFloatToReceiver((uint) Parameter.Seq1_0, seq1_0);
    _context.SendFloatToReceiver((uint) Parameter.Seq1_1, seq1_1);
    _context.SendFloatToReceiver((uint) Parameter.Seq1_2, seq1_2);
    _context.SendFloatToReceiver((uint) Parameter.Seq1_3, seq1_3);
    _context.SendFloatToReceiver((uint) Parameter.Seq1_4, seq1_4);
    _context.SendFloatToReceiver((uint) Parameter.Seq1_5, seq1_5);
    _context.SendFloatToReceiver((uint) Parameter.Seq1_6, seq1_6);
    _context.SendFloatToReceiver((uint) Parameter.Seq1_7, seq1_7);
    _context.SendFloatToReceiver((uint) Parameter.Seq2_0, seq2_0);
    _context.SendFloatToReceiver((uint) Parameter.Seq2_1, seq2_1);
    _context.SendFloatToReceiver((uint) Parameter.Seq2_2, seq2_2);
    _context.SendFloatToReceiver((uint) Parameter.Seq2_3, seq2_3);
    _context.SendFloatToReceiver((uint) Parameter.Seq2_4, seq2_4);
    _context.SendFloatToReceiver((uint) Parameter.Seq2_5, seq2_5);
    _context.SendFloatToReceiver((uint) Parameter.Seq2_6, seq2_6);
    _context.SendFloatToReceiver((uint) Parameter.Seq2_7, seq2_7);
    _context.SendFloatToReceiver((uint) Parameter.Seq3_0, seq3_0);
    _context.SendFloatToReceiver((uint) Parameter.Seq3_1, seq3_1);
    _context.SendFloatToReceiver((uint) Parameter.Seq3_2, seq3_2);
    _context.SendFloatToReceiver((uint) Parameter.Seq3_3, seq3_3);
    _context.SendFloatToReceiver((uint) Parameter.Seq3_4, seq3_4);
    _context.SendFloatToReceiver((uint) Parameter.Seq3_5, seq3_5);
    _context.SendFloatToReceiver((uint) Parameter.Seq3_6, seq3_6);
    _context.SendFloatToReceiver((uint) Parameter.Seq3_7, seq3_7);
    _context.SendFloatToReceiver((uint) Parameter.Seq4_0, seq4_0);
    _context.SendFloatToReceiver((uint) Parameter.Seq4_1, seq4_1);
    _context.SendFloatToReceiver((uint) Parameter.Seq4_2, seq4_2);
    _context.SendFloatToReceiver((uint) Parameter.Seq4_3, seq4_3);
    _context.SendFloatToReceiver((uint) Parameter.Seq4_4, seq4_4);
    _context.SendFloatToReceiver((uint) Parameter.Seq4_5, seq4_5);
    _context.SendFloatToReceiver((uint) Parameter.Seq4_6, seq4_6);
    _context.SendFloatToReceiver((uint) Parameter.Seq4_7, seq4_7);
    _context.SendFloatToReceiver((uint) Parameter.Squaremix1, squareMix1);
    _context.SendFloatToReceiver((uint) Parameter.Squaremix2, squareMix2);
    _context.SendFloatToReceiver((uint) Parameter.Squaremix3, squareMix3);
    _context.SendFloatToReceiver((uint) Parameter.Squaremix4, squareMix4);
    _context.SendFloatToReceiver((uint) Parameter.Sustain1, sustain1);
    _context.SendFloatToReceiver((uint) Parameter.Sustain2, sustain2);
    _context.SendFloatToReceiver((uint) Parameter.Sustain3, sustain3);
    _context.SendFloatToReceiver((uint) Parameter.Sustain4, sustain4);
    _context.SendFloatToReceiver((uint) Parameter.Vol1, vol1);
    _context.SendFloatToReceiver((uint) Parameter.Vol2, vol2);
    _context.SendFloatToReceiver((uint) Parameter.Vol3, vol3);
    _context.SendFloatToReceiver((uint) Parameter.Vol4, vol4);
  }
  
  private void Update() {
    // retreive sent messages
    if (_context.IsSendHookRegistered()) {
      Hv_UnitySynth_AudioLib.FloatMessage tempMessage;
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

class Hv_UnitySynth_Context {

#if UNITY_IOS && !UNITY_EDITOR
  private const string _dllName = "__Internal";
#else
  private const string _dllName = "Hv_UnitySynth_AudioLib";
#endif

  // Thread-safe message queue
  public class SendMessageQueue {
    private readonly object _msgQueueSync = new object();
    private readonly Queue<Hv_UnitySynth_AudioLib.FloatMessage> _msgQueue = new Queue<Hv_UnitySynth_AudioLib.FloatMessage>();

    public Hv_UnitySynth_AudioLib.FloatMessage GetNextMessage() {
      lock (_msgQueueSync) {
        return (_msgQueue.Count != 0) ? _msgQueue.Dequeue() : null;
      }
    }

    public void AddMessage(string receiverName, float value) {
      Hv_UnitySynth_AudioLib.FloatMessage msg = new Hv_UnitySynth_AudioLib.FloatMessage(receiverName, value);
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
  private static extern IntPtr hv_UnitySynth_new_with_options(double sampleRate, int poolKb, int inQueueKb, int outQueueKb);

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

  public Hv_UnitySynth_Context(double sampleRate, int poolKb=10, int inQueueKb=80, int outQueueKb=2) {
    gch = GCHandle.Alloc(msgQueue);
    _context = hv_UnitySynth_new_with_options(sampleRate, poolKb, inQueueKb, outQueueKb);
    hv_setPrintHook(_context, new PrintHook(OnPrint));
    hv_setUserData(_context, GCHandle.ToIntPtr(gch));
  }

  ~Hv_UnitySynth_Context() {
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
