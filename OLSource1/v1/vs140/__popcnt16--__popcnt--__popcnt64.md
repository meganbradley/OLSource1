---
title: "__popcnt16, __popcnt, __popcnt64"
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
  - "__popcnt64"
  - "__popcnt"
  - "__popcnt16"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "popcnt instruction"
  - "__popcnt16"
  - "__popcnt64"
  - "__popcnt"
ms.assetid: e525b236-adc8-42df-9b9b-8b7d8c245d3b
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __popcnt16, __popcnt, __popcnt64
**Microsoft Specific**  
  
 Counts the number of one bits (population count) in a 16-, 32-, or 64-byte unsigned integer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The 16-, 32-, or 64-bit unsigned integer for which we want the population count.  
  
## Return Value  
 The number of one bits in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Advanced Bit Manipulation|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Advanced Bit Manipulation|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Advanced Bit Manipulation in 64-bit mode.|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 Each of these intrinsics generates the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> instruction.  The size of the value that the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> instruction returns is the same as the size of its argument.  In 32-bit mode there are no 64-bit general-purpose registers, hence no 64-bit <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 To determine hardware support for the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> instruction, call the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> intrinsic with <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and check bit 23 of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. This bit is 1 if the instruction is supported, and 0 otherwise. If you run code that uses this intrinsic on hardware that does not support the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> instruction, the results are unpredictable.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **__popcnt16(0x0) = 0**  
 **__popcnt16(0xff) = 8**  
 **__popcnt16(0xffff) = 16**  
 **__popcnt(0x0) = 0**  
 **__popcnt(0xff) = 8**  
 **__oopcnt(0xffff) = 16**  
 **__popcnt(0xffffffff) = 32**   
## END Microsoft Specific  
 Copyright 2007 by Advanced Micro Devices, Inc. All rights reserved. Reproduced with permission from Advanced Micro Devices, Inc.  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)