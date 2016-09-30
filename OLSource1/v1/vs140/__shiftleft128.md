---
title: "__shiftleft128"
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
  - "__shiftleft128"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__shiftleft128 intrinsic"
ms.assetid: 557b846a-8fb0-469d-91ac-1b1fad80dc2a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __shiftleft128
**Microsoft Specific**  
  
 Shifts a 128-bit quantity, represented as two 64-bit quantities <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, to the left by a number of bits specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and returns the high 64 bits of the result.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The low 64 bits of the 128-bit quantity to shift.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The high 64 bits of the 128-bit quantity to shift.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The number of bits to shift.  
  
## Return Value  
 The high 64 bits of the result.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> value is always modulo 64 so that, for example, if you call <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the function will shift the low part <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> bits left and return a high part of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and not <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> as might otherwise be expected.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **0x100000000000000001 <\< 1 = 0x200000000000000002**  
**0x100000000000000001 >> 1 = 0x080000000000000000**   
## END Microsoft Specific  
  
## See Also  
 [__shiftright128](../vs140/__shiftright128.md)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)