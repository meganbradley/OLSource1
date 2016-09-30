---
title: "__shiftright128"
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
  - "__shiftright128"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__shiftright128 intrinsic"
ms.assetid: 5419a6c4-0de1-43fb-b314-4faa5b2d051f
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __shiftright128
**Microsoft Specific**  
  
 Shifts a 128-bit quantity, represented as two 64-bit quantities <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, to the right by a number of bits specified by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and returns the low 64 bits of the result.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The low 64 bits of the 128-bit quantity to shift.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The high 64 bits of the 128-bit quantity to shift.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The number of bits to shift.  
  
## Return Value  
 The low 64 bits of the result.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> value is always modulo 64 so that, for example, if you call <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, the function will shift the high part <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> bits right and return a low part of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and not <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> as might otherwise be expected.  
  
## Example  
 For an example, see [__shiftleft128](../vs140/__shiftleft128.md).  
  
## END Microsoft Specific  
  
## See Also  
 [__shiftleft128](../vs140/__shiftleft128.md)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)