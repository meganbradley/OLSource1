---
title: "__ll_lshift"
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
  - "__ll_lshift_cpp"
  - "__ll_lshift"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ll_lshift intrinsic"
  - "__ll_lshift intrinsic"
ms.assetid: fe98f733-426d-44b3-8f24-5d0d6d44bd94
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __ll_lshift
**Microsoft Specific**  
  
 Shifts the supplied 64-bit value to the left by the specified number of bits.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The 64-bit integer value to shift left.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The number of bits to shift.  
  
## Return Value  
 The mask shifted left by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> bits.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 If you compile your program using the 64 bit architecture and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is larger than 63, the number of bits to shift is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> modulo 64. If you compile your program using the 32 bit architecture and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is larger than 31, the number of bits to shift is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> modulo 32.  
  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> in the name indicates that this is an operation on <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Note** There is no unsigned version of the left shift operation. This is because <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> already uses an unsigned input parameter. Unlike the right shift, there is no sign dependence for the left shift, because the least significant bit in the result is always set to zero regardless of the sign of the value shifted.  
  
### END Microsoft Specific  
  
## See Also  
 [__ll_rshift](../vs140/__ll_rshift.md)   
 [__ull_rshift](../vs140/__ull_rshift.md)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)