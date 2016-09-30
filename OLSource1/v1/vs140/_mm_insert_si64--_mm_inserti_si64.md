---
title: "_mm_insert_si64, _mm_inserti_si64"
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
  - "_mm_inserti_si64"
  - "_mm_insert_si64"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insertq instruction"
  - "_mm_insert_si64 intrinsic"
  - "_mm_inserti_si64 intrinsic"
ms.assetid: 897a4b36-8b08-4b00-a18f-7850f5732d7d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mm_insert_si64, _mm_inserti_si64
**Microsoft Specific**  
  
 Generates the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> instruction to insert bits from its second operand into its first operand.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A 128-bit field with input data in its lower 64 bits into which a field will be inserted.  
  
 [in]  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A 128-bit field with the data to insert in its low bits.  For <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, also contains a field descriptor in its high bits.  
  
 [in]  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 An integer constant that specifies the length of the field to insert.  
  
 [in]  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 An integer constant that specifies the index of the least significant bit of the field into which data will be inserted.  
  
## Return Value  
 A 128-bit field whose lower 64 bits contain the original low 64 bits of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> with the specified bit field replaced by the low bits of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The upper 64 bits of the return value are undefined.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|SSE4a|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|SSE4a|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 This intrinsic generates the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> instruction to insert bits from <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> into <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. There are two versions of this intrinsic: <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, is the immediate version, and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is the non-immediate one.  Each version extracts a bit field of a given length from Source2 and inserts it into Source1.  The extracted bits are the least significant bits of Source2.  The field Source1 into which these bits will be inserted is defined by the length and the index of its least significant bit.  The values of the length and index are taken mod 64, thus both -1 and 127 are interpreted as 63. If the sum of the (reduced) bit index and (reduced) field length is larger than 64, the results are undefined. A value of zero for field length is interpreted as 64.  If the field length and bit index are both zero, bits 63:0 of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> are inserted into <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  If the field length is zero but the bit index is non-zero, the results are undefined.  
  
 In a call to _mm_insert_si64, the field length is contained in bits 77:72 of Source2 and the index in bits 69:64.  
  
 If you call <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>with arguments that the compiler cannot determine to be integer constants, the compiler generates code to pack those values into an XMM register and to call <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 To determine hardware support for the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> instruction call the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> intrinsic with <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and check bit 6 of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. This bit will be 1 if the instruction is supported, and 0 otherwise. If you run code that uses this intrinsic on hardware that does not support the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> instruction, the results are unpredictable.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **result1 = 0xfffffffff3210fff**  
**result2 = 0xfffffffff3210fff**  
**result3 = 0xfffffffff3210fff**   
## END Microsoft Specific  
 Copyright 2007 by Advanced Micro Devices, Inc. All rights reserved. Reproduced with permission from Advanced Micro Devices, Inc.  
  
## See Also  
 [_mm_extract_si64, _mm_extracti_si64](../vs140/_mm_extract_si64--_mm_extracti_si64.md)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)