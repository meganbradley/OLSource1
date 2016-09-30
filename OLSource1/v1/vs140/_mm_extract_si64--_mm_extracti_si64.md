---
title: "_mm_extract_si64, _mm_extracti_si64"
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
  - "_mm_extracti_si64"
  - "_mm_extract_si64"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "extrq instruction"
  - "_mm_extracti_si64 intrinsic"
  - "_mm_extract_si64 intrinsic"
ms.assetid: 459fdd72-cc54-4ee5-bbd5-d2c6067a88e7
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mm_extract_si64, _mm_extracti_si64
**Microsoft Specific**  
  
 Generates the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> instruction to extract specified bits from the low 64 bits of its first argument.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A 128-bit field with input data in its lower 64 bits.  
  
 [in]  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A 128-bit field that describes the bit field to extract.  
  
 [in]  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An integer that specifies the length of the field to extract.  
  
 [in]  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 An integer that specifies the index of the field to extract  
  
## Return Value  
 A 128-bit field with the extracted field in its least significant bits.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|SSE4a|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|SSE4a|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 This intrinsic generates the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> instruction to extract bits from <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.There are two versions of this intrinsic: <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is the immediate version, and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is the non-immediate one.  Each version extracts from <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> a bit field defined by its length and the index of its least significant bit. The values of the length and index are taken mod 64, thus both -1 and 127 are interpreted as 63. If the sum of the (reduced) index and (reduced) field length is greater than 64, the results are undefined. A value of zero for field length is interpreted as 64. If the field length and bit index are both zero, bits 63:0 of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> are extracted. If the field length is zero but the bit index is non-zero, the results are undefined.  
  
 In a call to _mm_extract_si64, the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> contains the index in bits 13:8 and the field length of the data to be extracted in bits 5:0..  
  
 If you call <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> with arguments that the compiler cannot determine to be integer constants the compiler generates code to pack those values into an XMM register (<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>) and to call <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 To determine hardware support for the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> instruction, call the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> intrinsic with <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and check bit 6 of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. This bit will be 1 if the instruction is supported, and 0 otherwise. If you run code that uses this intrinsic hardware that does not support the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> instruction, the results are unpredictable.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **result1 = 0x30eca86**  
**result2 = 0x30eca86**  
**result3 = 0x30eca86**   
## END Microsoft Specific  
 Copyright 2007 by Advanced Micro Devices, Inc. All rights reserved. Reproduced with permission from Advanced Micro Devices, Inc.  
  
## See Also  
 [_mm_insert_si64, _mm_inserti_si64](../vs140/_mm_insert_si64--_mm_inserti_si64.md)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)