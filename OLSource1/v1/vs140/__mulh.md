---
title: "__mulh"
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
  - "__mulh"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__mulh intrinsic"
ms.assetid: cd2ab093-9ef6-404d-ac34-0bee033882f3
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __mulh
**Microsoft Specific**  
  
 Returns the high 64 bits of the product of two 64-bit signed integers.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The first number to multiply.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The second number to multiply.  
  
## Return Value  
 The high 64 bits of the 128-bit result of the multiplication.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 This routine is only available as an intrinsic.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **0xfffffffffffffff \* 0xf0000000 = 0xeffffffffffffff10000000**   
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)