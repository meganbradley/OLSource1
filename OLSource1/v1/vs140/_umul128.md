---
title: "_umul128"
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
  - "__umul128"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__umul128 intrinsic"
ms.assetid: 13684df3-3ac7-467c-b258-a0e93bc490b5
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _umul128
**Microsoft Specific**  
  
 Multiplies two 64-bit unsigned integers passed in as the first two arguments and puts the high 64 bits of the product in the 64-bit unsigned integer pointed to by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and returns the low 64 bits of the product.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The first 64-bit integer to multiply.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The second 64-bit integer to multiply.  
  
 [out] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The high 64 bits of the product.  
  
## Return Value  
 The low 64 bits of the product.  
  
## Requirements  
  
|Intrinsic|Architecture|Header|  
|---------------|------------------|------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|ARM, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|\<intrin.h>|  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **0xfffffffffffffff \* 0xf0000000 = 0xeffffffffffffff10000000**   
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)