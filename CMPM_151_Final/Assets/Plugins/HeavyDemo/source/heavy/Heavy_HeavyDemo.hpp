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

#ifndef _HEAVY_CONTEXT_HEAVYDEMO_HPP_
#define _HEAVY_CONTEXT_HEAVYDEMO_HPP_

// object includes
#include "HeavyContext.hpp"
#include "HvControlBinop.h"
#include "HvControlVar.h"
#include "HvSignalVar.h"
#include "HvSignalPhasor.h"
#include "HvMath.h"
#include "HvControlCast.h"

class Heavy_HeavyDemo : public HeavyContext {

 public:
  Heavy_HeavyDemo(double sampleRate, int poolKb=10, int inQueueKb=2, int outQueueKb=0);
  ~Heavy_HeavyDemo();

  const char *getName() override { return "HeavyDemo"; }
  int getNumInputChannels() override { return 0; }
  int getNumOutputChannels() override { return 2; }

  int process(float **inputBuffers, float **outputBuffer, int n) override;
  int processInline(float *inputBuffers, float *outputBuffer, int n) override;
  int processInlineInterleaved(float *inputBuffers, float *outputBuffer, int n) override;

  int getParameterInfo(int index, HvParameterInfo *info) override;
  struct Parameter {
    struct In {
      enum ParameterIn : hv_uint32_t {
        FREQ = 0x345FC008, // freq
        WAVETOGGLE = 0x9B5289D6, // waveToggle
      };
    };
  };

 private:
  HvTable *getTableForHash(hv_uint32_t tableHash) override;
  void scheduleMessageForReceiver(hv_uint32_t receiverHash, HvMessage *m) override;

  // static sendMessage functions
  static void cMsg_KdAdVvUq_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cReceive_RTpDFNZk_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cCast_nrjY8vCl_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cSwitchcase_oPqXmGB4_onMessage(HeavyContextInterface *, void *, int letIn, const HvMessage *const, void *);
  static void cMsg_fxATBt9S_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cReceive_kJkTJBq5_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cMsg_DDG6zHaH_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cReceive_G8WetJf8_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cMsg_RCir9fbt_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cMsg_eetbjbjF_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cMsg_0UpWrGHU_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cCast_tZI5JUNC_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cSwitchcase_jgkoReEJ_onMessage(HeavyContextInterface *, void *, int letIn, const HvMessage *const, void *);
  static void cVar_0DPys9rX_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cBinop_tRyVKPjQ_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cVar_DVhyPHPV_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cMsg_sPFRLW8J_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cVar_Xwd78hG9_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cBinop_8zVPEyKM_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cBinop_NBZztNKp_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cReceive_LMghZorb_sendMessage(HeavyContextInterface *, int, const HvMessage *);

  // objects
  SignalPhasor sPhasor_xHBJyTvh;
  SignalPhasor sPhasor_EbKFVEC6;
  SignalVarf sVarf_dMbnnMG6;
  ControlVar cVar_0DPys9rX;
  ControlBinop cBinop_tRyVKPjQ;
  ControlVar cVar_DVhyPHPV;
  SignalVarf sVarf_7Z200XNy;
  SignalVarf sVarf_w6qqLw16;
  ControlVar cVar_Xwd78hG9;
  ControlBinop cBinop_8zVPEyKM;
  ControlBinop cBinop_NBZztNKp;
};

#endif // _HEAVY_CONTEXT_HEAVYDEMO_HPP_
