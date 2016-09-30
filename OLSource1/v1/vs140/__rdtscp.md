---
title: "__rdtscp"
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
  - "__rdtscp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rdtscp intrinsic"
  - "__rdtscp intrinsic"
  - "rdtscp instruction"
ms.assetid: f17d9a9c-88bb-44e0-b69d-d516bc1c93ee
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __rdtscp
**Microsoft Specific**  
  
 Generates the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> instruction, writes <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>] to memory, and returns the 64-bit Time Stamp Counter (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> result.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to a location that will contain the contents of the machine-specific register <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Return Value  
 A 64-bit unsigned integer tick count.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|AMD NPT Family 0Fh or later versions|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 This intrinsic generates the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> instruction. To determine hardware support for this instruction, call the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> intrinsic with <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and check bit 27 of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. This bit is 1 if the instruction is supported, and 0 otherwise.  If you run code that uses this intrinsic on hardware that does not support the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> instruction, the results are unpredictable.  
  
> [!CAUTION]
>  Unlike <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is a serializing instruction; nevertheless, the compiler can move code around this intrinsic.  
  
 The interpretation of the TSC value in this generation of hardware differs from that in earlier versions of [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)].  See hardware manuals for more information.  
  
 The meaning of the value in <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> depends on the operating system.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **3363423610155519 ticks**  
**TSC_AUX was 0**   
## END Microsoft Specific  
 Copyright 2007 by Advanced Micro Devices, Inc. All rights reserved. Reproduced with permission from Advanced Micro Devices, Inc.  
  
## See Also  
 [__rdtsc](../vs140/__rdtsc.md)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)