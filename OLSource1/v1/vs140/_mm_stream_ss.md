---
title: "_mm_stream_ss"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "_mm_stream_ss"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "movntss instruction"
  - "_mm_stream_ss intrinsic"
ms.assetid: c53dffe9-0dfe-4063-85d3-e8987b870fce
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mm_stream_ss
**Microsoft Specific**  
  
 Writes 32-bit data to a memory location without polluting the caches.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the location where the source data is written.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A 128-bit number that contains the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> value to be written in its bottom 32 bits..  
  
## Return Value  
 None.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|SSE4a|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 This intrinsic generates the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> instruction. To determine hardware support for this instruction, call the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> intrinsic with <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>and check bit 6 of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. This bit is 1 when the instruction is supported, and 0 otherwise.  
  
 If you run code that uses the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> intrinsic on hardware that does not support the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> instruction, the results are unpredictable.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **f[0] = -1, f[1] = -2**  
**f[2] = -3, f[3] = 3**   
## END Microsoft Specific  
 Copyright 2007 by Advanced Micro Devices, Inc. All rights reserved. Reproduced with permission from Advanced Micro Devices, Inc.  
  
## See Also  
 [_mm_stream_sd](../vs140/_mm_stream_sd.md)   
 [_mm_stream_ps](assetId:///f7af2f19-c0d4-43c6-b5f6-a658d2b1d869)   
 [_mm_store_ss](assetId:///dfeeea35-8faf-4f54-8a9e-6723e226fb08)   
 [_mm_sfence](assetId:///b6c0d18e-3628-4318-826b-45f66782e870)   
 [Streaming SIMD Extensions that Support the Cache](assetId:///8f03493a-d5f5-4457-892e-0b6540494872)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)