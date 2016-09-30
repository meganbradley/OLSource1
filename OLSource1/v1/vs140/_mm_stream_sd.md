---
title: "_mm_stream_sd"
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
  - "_mm_stream_sd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_mm_stream_sd intrinsic"
  - "movntsd instruction"
ms.assetid: 2b4bea5e-e64e-45fa-9afc-88a2e4b82cfc
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mm_stream_sd
**Microsoft Specific**  
  
 Writes 64-bit data to a memory location without polluting the caches.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the location where the source data will be written.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A 128-bit value containing the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> value to be written in its bottom 64 bits..  
  
## Return Value  
 None.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|SSE4a|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 This intrinsic generates the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> instruction. To determine hardware support for this instruction, call the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> intrinsic with <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and check bit 6 of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. This bit is 1 if the hardware supports this instruction, and 0 otherwise.  
  
 If you run code that uses the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> intrinsic on hardware that does not support the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> instruction, the results are unpredictable.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **d[0] = -1, d[1] = 1**   
## END Microsoft Specific  
 Copyright 2007 by Advanced Micro Devices, Inc. All rights reserved. Reproduced with permission from Advanced Micro Devices, Inc.  
  
## See Also  
 [_mm_stream_ss](../vs140/_mm_stream_ss.md)   
 [_mm_store_sd](assetId:///8e672d0d-0a96-45b9-a783-392a2457de42)   
 [_mm_sfence](assetId:///b6c0d18e-3628-4318-826b-45f66782e870)   
 [Streaming SIMD Extensions that Support the Cache](assetId:///8f03493a-d5f5-4457-892e-0b6540494872)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)