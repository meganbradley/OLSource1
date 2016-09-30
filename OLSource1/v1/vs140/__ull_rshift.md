---
title: "__ull_rshift"
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
  - "__ull_rshift"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ull_rshift intrinsic"
  - "__ull_rshift intrinsic"
ms.assetid: b7ff5254-3540-4e6e-b57c-a6c4beb7dca2
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __ull_rshift
**Microsoft Specific**  
  
 on x64, shifts a 64-bit value specified by the first parameter to the right by a number of bits specified by the second parameter.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The 64-bit integer value to shift right.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The number of bits to shift, modulo 32 on x86, and modulo 64 on x64.  
  
## Return Value  
 The mask shifted by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> bits.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 If the second parameter is greater than 31 on x86 (63 on x64), that number is taken modulo 32 (64 on x64) to determine the number of bits to shift. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in the name indicates <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### END Microsoft Specific  
  
## See Also  
 [__ll_lshift](../vs140/__ll_lshift.md)   
 [__ll_rshift](../vs140/__ll_rshift.md)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)