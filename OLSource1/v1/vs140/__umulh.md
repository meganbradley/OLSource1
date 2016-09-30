---
title: "__umulh"
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
  - "__umulh"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__umulh intrinsic"
ms.assetid: d241b53a-e6f7-4af1-9f6e-84e149158f03
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __umulh
**Microsoft Specific**  
  
 Return the high 64 bits of the product of two 64-bit unsigned integers.  
  
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
 These routines are only available as intrinsics.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **0x10 \* 0xfedcba9876543210 = 0xfedcba98765432100**    
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)