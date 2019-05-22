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

#ifndef _HEAVY_CONTEXT_FIRSTUNITYTEST_HPP_
#define _HEAVY_CONTEXT_FIRSTUNITYTEST_HPP_

// object includes
#include "HeavyContext.hpp"
#include "HvControlBinop.h"
#include "HvControlVar.h"
#include "HvSignalVar.h"
#include "HvSignalPhasor.h"
#include "HvMath.h"
#include "HvControlCast.h"

class Heavy_firstUnityTest : public HeavyContext {

 public:
  Heavy_firstUnityTest(double sampleRate, int poolKb=10, int inQueueKb=2, int outQueueKb=0);
  ~Heavy_firstUnityTest();

  const char *getName() override { return "firstUnityTest"; }
  int getNumInputChannels() override { return 0; }
  int getNumOutputChannels() override { return 2; }

  int process(float **inputBuffers, float **outputBuffer, int n) override;
  int processInline(float *inputBuffers, float *outputBuffer, int n) override;
  int processInlineInterleaved(float *inputBuffers, float *outputBuffer, int n) override;

  int getParameterInfo(int index, HvParameterInfo *info) override;

 private:
  HvTable *getTableForHash(hv_uint32_t tableHash) override;
  void scheduleMessageForReceiver(hv_uint32_t receiverHash, HvMessage *m) override;

  // static sendMessage functions
  static void cVar_oDOHVbw7_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cReceive_o4zhv35l_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cCast_EIDhDU6A_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cCast_nlhHHRe6_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cCast_DBq8rNO7_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cReceive_7npFE2ux_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cVar_PuK0v6B1_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cBinop_DZPslG4r_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cVar_POyOSaLz_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cVar_xIAHKWC3_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cBinop_33ybKADp_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cVar_hWiX7t63_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cBinop_yxCt4ko5_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cVar_twHHx5pZ_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cVar_R6DRBMMo_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cVar_wSpeoLbu_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cCast_jLZrApT6_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cBinop_EFefcmK6_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cReceive_QSyrzFJo_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cBinop_8kfGVYuN_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cVar_uJEuU6en_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cMsg_23r8hDHg_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cVar_i2ksNyDM_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cBinop_xCwhRsq4_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cBinop_CA1zrU5t_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cBinop_mNaMbzf2_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cBinop_9RjrsrtN_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cReceive_UtkyK7wv_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cVar_rmevzvc4_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cVar_Co0mumuz_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cReceive_zLMU2qMG_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cReceive_GfdcG9uP_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cVar_m2IGRE3K_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cBinop_HZPT5Ck5_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cBinop_KPop9bOd_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cVar_XWRagM7V_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cVar_LcYcn7Fy_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cBinop_A09qIQV0_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cCast_6meqi8Bw_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cCast_VAA1UJZN_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cBinop_TEC7AI29_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cBinop_xd4Zbdob_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cCast_BuC9XeS8_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cCast_n5FUhQUo_sendMessage(HeavyContextInterface *, int, const HvMessage *);
  static void cBinop_OB3BC1Vq_sendMessage(HeavyContextInterface *, int, const HvMessage *);

  // objects
  SignalPhasor sPhasor_kTGHArvD;
  SignalPhasor sPhasor_NTGZDcv0;
  SignalPhasor sPhasor_elNF4uHY;
  SignalPhasor sPhasor_Cj5XfVGG;
  ControlVar cVar_oDOHVbw7;
  ControlVar cVar_PuK0v6B1;
  ControlBinop cBinop_DZPslG4r;
  ControlVar cVar_POyOSaLz;
  ControlVar cVar_xIAHKWC3;
  ControlBinop cBinop_33ybKADp;
  ControlVar cVar_hWiX7t63;
  ControlBinop cBinop_yxCt4ko5;
  ControlVar cVar_twHHx5pZ;
  ControlVar cVar_R6DRBMMo;
  ControlVar cVar_wSpeoLbu;
  ControlBinop cBinop_EFefcmK6;
  ControlBinop cBinop_8kfGVYuN;
  ControlVar cVar_uJEuU6en;
  ControlVar cVar_i2ksNyDM;
  ControlBinop cBinop_xCwhRsq4;
  ControlBinop cBinop_CA1zrU5t;
  ControlBinop cBinop_mNaMbzf2;
  ControlBinop cBinop_9RjrsrtN;
  ControlVar cVar_rmevzvc4;
  ControlVar cVar_Co0mumuz;
  ControlVar cVar_m2IGRE3K;
  ControlBinop cBinop_HZPT5Ck5;
  ControlBinop cBinop_KPop9bOd;
  ControlVar cVar_XWRagM7V;
  ControlVar cVar_LcYcn7Fy;
  ControlBinop cBinop_A09qIQV0;
  ControlBinop cBinop_TEC7AI29;
  ControlBinop cBinop_xd4Zbdob;
  ControlBinop cBinop_OB3BC1Vq;
};

#endif // _HEAVY_CONTEXT_FIRSTUNITYTEST_HPP_
