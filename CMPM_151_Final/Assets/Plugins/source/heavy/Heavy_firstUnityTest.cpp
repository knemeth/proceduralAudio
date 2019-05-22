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

#include "Heavy_firstUnityTest.hpp"

#define Context(_c) reinterpret_cast<Heavy_firstUnityTest *>(_c)



/*
 * C Functions
 */

extern "C" {
  HV_EXPORT HeavyContextInterface *hv_firstUnityTest_new(double sampleRate) {
    return new Heavy_firstUnityTest(sampleRate);
  }

  HV_EXPORT HeavyContextInterface *hv_firstUnityTest_new_with_options(double sampleRate,
      int poolKb, int inQueueKb, int outQueueKb) {
    return new Heavy_firstUnityTest(sampleRate, poolKb, inQueueKb, outQueueKb);
  }
} // extern "C"







/*
 * Class Functions
 */

Heavy_firstUnityTest::Heavy_firstUnityTest(double sampleRate, int poolKb, int inQueueKb, int outQueueKb)
    : HeavyContext(sampleRate, poolKb, inQueueKb, outQueueKb) {
  numBytes += sPhasor_k_init(&sPhasor_kTGHArvD, 0.0f, sampleRate);
  numBytes += sPhasor_k_init(&sPhasor_NTGZDcv0, 0.0f, sampleRate);
  numBytes += sPhasor_k_init(&sPhasor_elNF4uHY, 0.0f, sampleRate);
  numBytes += sPhasor_k_init(&sPhasor_Cj5XfVGG, 0.0f, sampleRate);
  numBytes += cVar_init_f(&cVar_oDOHVbw7, 0.0f);
  numBytes += cVar_init_f(&cVar_PuK0v6B1, 0.0f);
  numBytes += cBinop_init(&cBinop_DZPslG4r, 0.0f); // __add
  numBytes += cVar_init_f(&cVar_POyOSaLz, 0.0f);
  numBytes += cVar_init_f(&cVar_xIAHKWC3, 0.0f);
  numBytes += cVar_init_f(&cVar_hWiX7t63, 0.0f);
  numBytes += cVar_init_f(&cVar_twHHx5pZ, 0.0f);
  numBytes += cVar_init_f(&cVar_R6DRBMMo, 0.0f);
  numBytes += cVar_init_f(&cVar_wSpeoLbu, 0.0f);
  numBytes += cVar_init_f(&cVar_uJEuU6en, 0.0f);
  numBytes += cVar_init_f(&cVar_i2ksNyDM, 0.0f);
  numBytes += cBinop_init(&cBinop_mNaMbzf2, 0.0f); // __add
  numBytes += cVar_init_f(&cVar_rmevzvc4, 0.0f);
  numBytes += cVar_init_f(&cVar_Co0mumuz, 0.0f);
  numBytes += cVar_init_f(&cVar_m2IGRE3K, 0.0f);
  numBytes += cBinop_init(&cBinop_KPop9bOd, 0.0f); // __add
  numBytes += cVar_init_f(&cVar_XWRagM7V, 0.0f);
  numBytes += cVar_init_f(&cVar_LcYcn7Fy, 0.0f);
  numBytes += cBinop_init(&cBinop_TEC7AI29, 0.0f); // __add
  
  // schedule a message to trigger all loadbangs via the __hv_init receiver
  scheduleMessageForReceiver(0xCE5CC65B, msg_initWithBang(HV_MESSAGE_ON_STACK(1), 0));
}

Heavy_firstUnityTest::~Heavy_firstUnityTest() {
  // nothing to free
}

HvTable *Heavy_firstUnityTest::getTableForHash(hv_uint32_t tableHash) {
  return nullptr;
}

void Heavy_firstUnityTest::scheduleMessageForReceiver(hv_uint32_t receiverHash, HvMessage *m) {
  switch (receiverHash) {
    case 0xC440C54F: { // Channel-A
      mq_addMessageByTimestamp(&mq, m, 0, &cReceive_QSyrzFJo_sendMessage);
      break;
    }
    case 0xB762BB42: { // Channel-B
      mq_addMessageByTimestamp(&mq, m, 0, &cReceive_7npFE2ux_sendMessage);
      break;
    }
    case 0x27D89CD5: { // Channel-C
      mq_addMessageByTimestamp(&mq, m, 0, &cReceive_o4zhv35l_sendMessage);
      break;
    }
    case 0x217D22F5: { // Channel-D
      mq_addMessageByTimestamp(&mq, m, 0, &cReceive_GfdcG9uP_sendMessage);
      break;
    }
    case 0x7746DB0A: { // Channel-E
      mq_addMessageByTimestamp(&mq, m, 0, &cReceive_zLMU2qMG_sendMessage);
      break;
    }
    case 0xCE5CC65B: { // __hv_init
      mq_addMessageByTimestamp(&mq, m, 0, &cReceive_UtkyK7wv_sendMessage);
      break;
    }
    default: return;
  }
}

int Heavy_firstUnityTest::getParameterInfo(int index, HvParameterInfo *info) {
  if (info != nullptr) {
    switch (index) {
      default: {
        info->name = "invalid parameter index";
        info->hash = 0;
        info->type = HvParameterType::HV_PARAM_TYPE_PARAMETER_IN;
        info->minVal = 0.0f;
        info->maxVal = 0.0f;
        info->defaultVal = 0.0f;
        break;
      }
    }
  }
  return 0;
}



/*
 * Send Function Implementations
 */


void Heavy_firstUnityTest::cVar_oDOHVbw7_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cCast_onMessage(_c, HV_CAST_FLOAT, 0, m, &cCast_BuC9XeS8_sendMessage);
  cCast_onMessage(_c, HV_CAST_BANG, 0, m, &cCast_jLZrApT6_sendMessage);
}

void Heavy_firstUnityTest::cReceive_o4zhv35l_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cBinop_k_onMessage(_c, NULL, HV_BINOP_MULTIPLY, 200.0f, 0, m, &cBinop_A09qIQV0_sendMessage);
}

void Heavy_firstUnityTest::cCast_EIDhDU6A_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cBinop_onMessage(_c, &Context(_c)->cBinop_mNaMbzf2, HV_BINOP_ADD, 1, m, &cBinop_mNaMbzf2_sendMessage);
}

void Heavy_firstUnityTest::cCast_nlhHHRe6_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cBinop_onMessage(_c, &Context(_c)->cBinop_TEC7AI29, HV_BINOP_ADD, 1, m, &cBinop_TEC7AI29_sendMessage);
}

void Heavy_firstUnityTest::cCast_DBq8rNO7_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cBinop_onMessage(_c, &Context(_c)->cBinop_DZPslG4r, HV_BINOP_ADD, 1, m, &cBinop_DZPslG4r_sendMessage);
}

void Heavy_firstUnityTest::cReceive_7npFE2ux_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cBinop_k_onMessage(_c, NULL, HV_BINOP_MULTIPLY, 200.0f, 0, m, &cBinop_HZPT5Ck5_sendMessage);
}

void Heavy_firstUnityTest::cVar_PuK0v6B1_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
}

void Heavy_firstUnityTest::cBinop_DZPslG4r_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  sPhasor_k_onMessage(_c, &Context(_c)->sPhasor_kTGHArvD, 0, m);
  cVar_onMessage(_c, &Context(_c)->cVar_m2IGRE3K, 0, m, &cVar_m2IGRE3K_sendMessage);
}

void Heavy_firstUnityTest::cVar_POyOSaLz_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
}

void Heavy_firstUnityTest::cVar_xIAHKWC3_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  sPhasor_k_onMessage(_c, &Context(_c)->sPhasor_elNF4uHY, 0, m);
  cVar_onMessage(_c, &Context(_c)->cVar_twHHx5pZ, 0, m, &cVar_twHHx5pZ_sendMessage);
  cBinop_onMessage(_c, &Context(_c)->cBinop_TEC7AI29, HV_BINOP_ADD, 0, m, &cBinop_TEC7AI29_sendMessage);
}

void Heavy_firstUnityTest::cBinop_33ybKADp_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cVar_onMessage(_c, &Context(_c)->cVar_LcYcn7Fy, 0, m, &cVar_LcYcn7Fy_sendMessage);
}

void Heavy_firstUnityTest::cVar_hWiX7t63_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cBinop_k_onMessage(_c, NULL, HV_BINOP_MULTIPLY, 1000.0f, 0, m, &cBinop_EFefcmK6_sendMessage);
}

void Heavy_firstUnityTest::cBinop_yxCt4ko5_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cVar_onMessage(_c, &Context(_c)->cVar_xIAHKWC3, 0, m, &cVar_xIAHKWC3_sendMessage);
}

void Heavy_firstUnityTest::cVar_twHHx5pZ_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
}

void Heavy_firstUnityTest::cVar_R6DRBMMo_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cCast_onMessage(_c, HV_CAST_FLOAT, 0, m, &cCast_EIDhDU6A_sendMessage);
  cCast_onMessage(_c, HV_CAST_BANG, 0, m, &cCast_n5FUhQUo_sendMessage);
}

void Heavy_firstUnityTest::cVar_wSpeoLbu_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cCast_onMessage(_c, HV_CAST_FLOAT, 0, m, &cCast_DBq8rNO7_sendMessage);
  cCast_onMessage(_c, HV_CAST_BANG, 0, m, &cCast_VAA1UJZN_sendMessage);
}

void Heavy_firstUnityTest::cCast_jLZrApT6_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cBinop_onMessage(_c, &Context(_c)->cBinop_KPop9bOd, HV_BINOP_ADD, 0, m, &cBinop_KPop9bOd_sendMessage);
}

void Heavy_firstUnityTest::cBinop_EFefcmK6_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cBinop_k_onMessage(_c, NULL, HV_BINOP_ADD, 0.0f, 0, m, &cBinop_yxCt4ko5_sendMessage);
}

void Heavy_firstUnityTest::cReceive_QSyrzFJo_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cBinop_k_onMessage(_c, NULL, HV_BINOP_MULTIPLY, 20.0f, 0, m, &cBinop_9RjrsrtN_sendMessage);
}

void Heavy_firstUnityTest::cBinop_8kfGVYuN_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cVar_onMessage(_c, &Context(_c)->cVar_R6DRBMMo, 0, m, &cVar_R6DRBMMo_sendMessage);
}

void Heavy_firstUnityTest::cVar_uJEuU6en_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cBinop_k_onMessage(_c, NULL, HV_BINOP_MULTIPLY, 200.0f, 0, m, &cBinop_A09qIQV0_sendMessage);
}

void Heavy_firstUnityTest::cMsg_23r8hDHg_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *const n) {
  HvMessage *m = nullptr;
  m = HV_MESSAGE_ON_STACK(1);
  msg_init(m, 1, msg_getTimestamp(n));
  msg_setFloat(m, 0, 0.0f);
  cVar_onMessage(_c, &Context(_c)->cVar_wSpeoLbu, 0, m, &cVar_wSpeoLbu_sendMessage);
  cVar_onMessage(_c, &Context(_c)->cVar_R6DRBMMo, 0, m, &cVar_R6DRBMMo_sendMessage);
  cVar_onMessage(_c, &Context(_c)->cVar_oDOHVbw7, 0, m, &cVar_oDOHVbw7_sendMessage);
  cVar_onMessage(_c, &Context(_c)->cVar_LcYcn7Fy, 0, m, &cVar_LcYcn7Fy_sendMessage);
}

void Heavy_firstUnityTest::cVar_i2ksNyDM_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cBinop_k_onMessage(_c, NULL, HV_BINOP_MULTIPLY, 20.0f, 0, m, &cBinop_9RjrsrtN_sendMessage);
}

void Heavy_firstUnityTest::cBinop_xCwhRsq4_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cVar_onMessage(_c, &Context(_c)->cVar_wSpeoLbu, 0, m, &cVar_wSpeoLbu_sendMessage);
}

void Heavy_firstUnityTest::cBinop_CA1zrU5t_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cBinop_k_onMessage(_c, NULL, HV_BINOP_SUBTRACT, 100.0f, 0, m, &cBinop_OB3BC1Vq_sendMessage);
}

void Heavy_firstUnityTest::cBinop_mNaMbzf2_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  sPhasor_k_onMessage(_c, &Context(_c)->sPhasor_Cj5XfVGG, 0, m);
  cVar_onMessage(_c, &Context(_c)->cVar_PuK0v6B1, 0, m, &cVar_PuK0v6B1_sendMessage);
}

void Heavy_firstUnityTest::cBinop_9RjrsrtN_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cBinop_k_onMessage(_c, NULL, HV_BINOP_SUBTRACT, 10.0f, 0, m, &cBinop_33ybKADp_sendMessage);
}

void Heavy_firstUnityTest::cReceive_UtkyK7wv_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cMsg_23r8hDHg_sendMessage(_c, 0, m);
}

void Heavy_firstUnityTest::cVar_rmevzvc4_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
}

void Heavy_firstUnityTest::cVar_Co0mumuz_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cBinop_k_onMessage(_c, NULL, HV_BINOP_MULTIPLY, 200.0f, 0, m, &cBinop_CA1zrU5t_sendMessage);
}

void Heavy_firstUnityTest::cReceive_zLMU2qMG_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cBinop_k_onMessage(_c, NULL, HV_BINOP_MULTIPLY, 1000.0f, 0, m, &cBinop_EFefcmK6_sendMessage);
}

void Heavy_firstUnityTest::cReceive_GfdcG9uP_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cBinop_k_onMessage(_c, NULL, HV_BINOP_MULTIPLY, 200.0f, 0, m, &cBinop_CA1zrU5t_sendMessage);
}

void Heavy_firstUnityTest::cVar_m2IGRE3K_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
}

void Heavy_firstUnityTest::cBinop_HZPT5Ck5_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cBinop_k_onMessage(_c, NULL, HV_BINOP_SUBTRACT, 100.0f, 0, m, &cBinop_xCwhRsq4_sendMessage);
}

void Heavy_firstUnityTest::cBinop_KPop9bOd_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  sPhasor_k_onMessage(_c, &Context(_c)->sPhasor_NTGZDcv0, 0, m);
  cVar_onMessage(_c, &Context(_c)->cVar_POyOSaLz, 0, m, &cVar_POyOSaLz_sendMessage);
}

void Heavy_firstUnityTest::cVar_XWRagM7V_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cBinop_k_onMessage(_c, NULL, HV_BINOP_MULTIPLY, 200.0f, 0, m, &cBinop_HZPT5Ck5_sendMessage);
}

void Heavy_firstUnityTest::cVar_LcYcn7Fy_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cBinop_k_onMessage(_c, NULL, HV_BINOP_DIVIDE, 1.0f, 0, m, &cBinop_xd4Zbdob_sendMessage);
}

void Heavy_firstUnityTest::cBinop_A09qIQV0_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cBinop_k_onMessage(_c, NULL, HV_BINOP_SUBTRACT, 100.0f, 0, m, &cBinop_8kfGVYuN_sendMessage);
}

void Heavy_firstUnityTest::cCast_6meqi8Bw_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cBinop_onMessage(_c, &Context(_c)->cBinop_TEC7AI29, HV_BINOP_ADD, 0, m, &cBinop_TEC7AI29_sendMessage);
}

void Heavy_firstUnityTest::cCast_VAA1UJZN_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cBinop_onMessage(_c, &Context(_c)->cBinop_DZPslG4r, HV_BINOP_ADD, 0, m, &cBinop_DZPslG4r_sendMessage);
}

void Heavy_firstUnityTest::cBinop_TEC7AI29_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cVar_onMessage(_c, &Context(_c)->cVar_rmevzvc4, 0, m, &cVar_rmevzvc4_sendMessage);
  cBinop_onMessage(_c, &Context(_c)->cBinop_DZPslG4r, HV_BINOP_ADD, 0, m, &cBinop_DZPslG4r_sendMessage);
  cBinop_onMessage(_c, &Context(_c)->cBinop_mNaMbzf2, HV_BINOP_ADD, 0, m, &cBinop_mNaMbzf2_sendMessage);
  cBinop_onMessage(_c, &Context(_c)->cBinop_KPop9bOd, HV_BINOP_ADD, 0, m, &cBinop_KPop9bOd_sendMessage);
}

void Heavy_firstUnityTest::cBinop_xd4Zbdob_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cCast_onMessage(_c, HV_CAST_FLOAT, 0, m, &cCast_nlhHHRe6_sendMessage);
  cCast_onMessage(_c, HV_CAST_BANG, 0, m, &cCast_6meqi8Bw_sendMessage);
}

void Heavy_firstUnityTest::cCast_BuC9XeS8_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cBinop_onMessage(_c, &Context(_c)->cBinop_KPop9bOd, HV_BINOP_ADD, 1, m, &cBinop_KPop9bOd_sendMessage);
}

void Heavy_firstUnityTest::cCast_n5FUhQUo_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cBinop_onMessage(_c, &Context(_c)->cBinop_mNaMbzf2, HV_BINOP_ADD, 0, m, &cBinop_mNaMbzf2_sendMessage);
}

void Heavy_firstUnityTest::cBinop_OB3BC1Vq_sendMessage(HeavyContextInterface *_c, int letIn, const HvMessage *m) {
  cVar_onMessage(_c, &Context(_c)->cVar_oDOHVbw7, 0, m, &cVar_oDOHVbw7_sendMessage);
}




/*
 * Context Process Implementation
 */

int Heavy_firstUnityTest::process(float **inputBuffers, float **outputBuffers, int n) {
  while (hLp_hasData(&inQueue)) {
    hv_uint32_t numBytes = 0;
    ReceiverMessagePair *p = reinterpret_cast<ReceiverMessagePair *>(hLp_getReadBuffer(&inQueue, &numBytes));
    hv_assert(numBytes >= sizeof(ReceiverMessagePair));
    scheduleMessageForReceiver(p->receiverHash, &p->msg);
    hLp_consume(&inQueue);
  }
  const int n4 = n & ~HV_N_SIMD_MASK; // ensure that the block size is a multiple of HV_N_SIMD

  // temporary signal vars
  hv_bufferf_t Bf0, Bf1, Bf2, Bf3;

  // input and output vars
  hv_bufferf_t O0, O1;

  // declare and init the zero buffer
  hv_bufferf_t ZERO; __hv_zero_f(VOf(ZERO));

  hv_uint32_t nextBlock = blockStartTimestamp;
  for (int n = 0; n < n4; n += HV_N_SIMD) {

    // process all of the messages for this block
    nextBlock += HV_N_SIMD;
    while (mq_hasMessageBefore(&mq, nextBlock)) {
      MessageNode *const node = mq_peek(&mq);
      node->sendMessage(this, node->let, node->m);
      mq_pop(&mq);
    }

    

    // zero output buffers
    __hv_zero_f(VOf(O0));
    __hv_zero_f(VOf(O1));

    // process all signal functions
    __hv_phasor_k_f(&sPhasor_kTGHArvD, VOf(Bf0));
    __hv_var_k_f(VOf(Bf1), 2.0f, 2.0f, 2.0f, 2.0f, 2.0f, 2.0f, 2.0f, 2.0f);
    __hv_var_k_f(VOf(Bf2), 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f);
    __hv_fms_f(VIf(Bf0), VIf(Bf1), VIf(Bf2), VOf(Bf2));
    __hv_phasor_k_f(&sPhasor_NTGZDcv0, VOf(Bf1));
    __hv_var_k_f(VOf(Bf0), 2.0f, 2.0f, 2.0f, 2.0f, 2.0f, 2.0f, 2.0f, 2.0f);
    __hv_var_k_f(VOf(Bf3), 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f);
    __hv_fms_f(VIf(Bf1), VIf(Bf0), VIf(Bf3), VOf(Bf3));
    __hv_add_f(VIf(Bf2), VIf(Bf3), VOf(Bf3));
    __hv_phasor_k_f(&sPhasor_elNF4uHY, VOf(Bf2));
    __hv_var_k_f(VOf(Bf0), 2.0f, 2.0f, 2.0f, 2.0f, 2.0f, 2.0f, 2.0f, 2.0f);
    __hv_var_k_f(VOf(Bf1), 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f);
    __hv_fms_f(VIf(Bf2), VIf(Bf0), VIf(Bf1), VOf(Bf1));
    __hv_add_f(VIf(Bf3), VIf(Bf1), VOf(Bf1));
    __hv_phasor_k_f(&sPhasor_Cj5XfVGG, VOf(Bf3));
    __hv_var_k_f(VOf(Bf0), 2.0f, 2.0f, 2.0f, 2.0f, 2.0f, 2.0f, 2.0f, 2.0f);
    __hv_var_k_f(VOf(Bf2), 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f);
    __hv_fms_f(VIf(Bf3), VIf(Bf0), VIf(Bf2), VOf(Bf2));
    __hv_add_f(VIf(Bf1), VIf(Bf2), VOf(Bf2));
    __hv_var_k_f(VOf(Bf1), 0.75f, 0.75f, 0.75f, 0.75f, 0.75f, 0.75f, 0.75f, 0.75f);
    __hv_mul_f(VIf(Bf2), VIf(Bf1), VOf(Bf1));
    __hv_add_f(VIf(Bf1), VIf(O0), VOf(O0));
    __hv_add_f(VIf(Bf1), VIf(O1), VOf(O1));

    // save output vars to output buffer
    __hv_store_f(outputBuffers[0]+n, VIf(O0));
    __hv_store_f(outputBuffers[1]+n, VIf(O1));
  }

  blockStartTimestamp = nextBlock;

  return n4; // return the number of frames processed
}

int Heavy_firstUnityTest::processInline(float *inputBuffers, float *outputBuffers, int n4) {
  hv_assert(!(n4 & HV_N_SIMD_MASK)); // ensure that n4 is a multiple of HV_N_SIMD

  // define the heavy input buffer for 0 channel(s)
  float **const bIn = NULL;

  // define the heavy output buffer for 2 channel(s)
  float **const bOut = reinterpret_cast<float **>(hv_alloca(2*sizeof(float *)));
  bOut[0] = outputBuffers+(0*n4);
  bOut[1] = outputBuffers+(1*n4);

  int n = process(bIn, bOut, n4);
  return n;
}

int Heavy_firstUnityTest::processInlineInterleaved(float *inputBuffers, float *outputBuffers, int n4) {
  hv_assert(n4 & ~HV_N_SIMD_MASK); // ensure that n4 is a multiple of HV_N_SIMD

  // define the heavy input buffer for 0 channel(s), uninterleave
  float *const bIn = NULL;

  // define the heavy output buffer for 2 channel(s)
  float *const bOut = reinterpret_cast<float *>(hv_alloca(2*n4*sizeof(float)));

  int n = processInline(bIn, bOut, n4);

  // interleave the heavy output into the output buffer
  #if HV_SIMD_AVX
  for (int i = 0, j = 0; j < n4; j += 8, i += 16) {
    __m256 x = _mm256_load_ps(bOut+j);    // LLLLLLLL
    __m256 y = _mm256_load_ps(bOut+n4+j); // RRRRRRRR
    __m256 a = _mm256_unpacklo_ps(x, y);  // LRLRLRLR
    __m256 b = _mm256_unpackhi_ps(x, y);  // LRLRLRLR
    _mm256_store_ps(outputBuffers+i, a);
    _mm256_store_ps(outputBuffers+8+i, b);
  }
  #elif HV_SIMD_SSE
  for (int i = 0, j = 0; j < n4; j += 4, i += 8) {
    __m128 x = _mm_load_ps(bOut+j);    // LLLL
    __m128 y = _mm_load_ps(bOut+n4+j); // RRRR
    __m128 a = _mm_unpacklo_ps(x, y);  // LRLR
    __m128 b = _mm_unpackhi_ps(x, y);  // LRLR
    _mm_store_ps(outputBuffers+i, a);
    _mm_store_ps(outputBuffers+4+i, b);
  }
  #elif HV_SIMD_NEON
  // https://community.arm.com/groups/processors/blog/2012/03/13/coding-for-neon--part-5-rearranging-vectors
  for (int i = 0, j = 0; j < n4; j += 4, i += 8) {
    float32x4_t x = vld1q_f32(bOut+j);
    float32x4_t y = vld1q_f32(bOut+n4+j);
    float32x4x2_t z = {x, y};
    vst2q_f32(outputBuffers+i, z); // interleave and store
  }
  #else // HV_SIMD_NONE
  for (int i = 0; i < 2; ++i) {
    for (int j = 0; j < n4; ++j) {
      outputBuffers[i+2*j] = bOut[i*n4+j];
    }
  }
  #endif

  return n;
}
