---
title: "__lzcnt16, __lzcnt, __lzcnt64"
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
  - "__lzcnt64"
  - "__lzcnt16"
  - "__lzcnt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__lzcnt intrinsic"
  - "lzcnt instruction"
  - "lzcnt16 intrinsic"
  - "lzcnt intrinsic"
  - "__lzcnt16 intrinsic"
  - "lzcnt64 intrinsic"
  - "__lzcnt64 intrinsic"
ms.assetid: 412113e7-052e-46e5-8bfa-d5ad72abc10e
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __lzcnt16, __lzcnt, __lzcnt64
**Microsoft Specific**  
  
 Counts the number of leading zeros in a 16-, 32-, or 64-byte integer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The 16-, 32-, or 64-bit unsigned integer to scan for leading zeros.  
  
## Return Value  
 The number of leading zero bits in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is zero, the return value is the size of the input operand (16, 32, or 64). If the most significant bit of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is one, the return value is zero.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|AMD: Advanced Bit Manipulation (ABM)\<br />\<br /> Intel: Haswell|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|AMD: Advanced Bit Manipulation (ABM)\<br />\<br /> Intel: Haswell|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|AMD: Advanced Bit Manipulation (ABM) in 64-bit mode.\<br />\<br /> Intel: Haswell|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 Each of these intrinsics generates the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> instruction.  The size of the value that the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> instruction returns is the same as the size of its argument.  In 32-bit mode there are no 64-bit general-purpose registers, hence no 64-bit <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 To determine hardware support for the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> instruction call the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> intrinsic with <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and check bit 5 of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. This bit will be 1 if the instruction is supported, and 0 otherwise. If you run code that uses this intrinsic on hardware that does not support the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> instruction, the results are unpredictable.  
  
 On Intel processors that do not support the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> instruction, the instruction byte encoding is executed as <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> (bit scan reverse). If code portability is a concern, consider use of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> intrinsic instead. For more information, see [_BitScanReverse, _BitScanReverse64](../vs140/_bitscanreverse--_bitscanreverse64.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **__lzcnt16(0x0) = 16**  
 **__lzcnt16(0xff) = 8**  
 **__lzcnt16(0xffff) = 0**  
 **__lzcnt(0x0) = 32**  
 **__lzcnt(0xff) = 24**  
 **__lzcnt(0xffff) = 16**  
 **__lzcnt(0xffffffff) = 0**   
## END Microsoft Specific  
 Portions of this content are Copyright 2007 by Advanced Micro Devices, Inc. All rights reserved. Reproduced with permission from Advanced Micro Devices, Inc.  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)