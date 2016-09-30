---
title: "fmaf Function"
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
  - "amp_math/Concurrency::precise_math::fmaf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "fmaf function"
ms.assetid: 3b922de7-2852-4d16-b79f-1bc0f301e5b9
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fmaf Function
Computes the product of the first and second specified arguments, then adds the third specified argument to the result; the entire computation is performed as a single operation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The first floating-point argument.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The second floating-point argument.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The third floating-point argument.  
  
## Return Value  
 The result of the expression (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> * <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) + <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The entire computation is performed as a single operation; that is, the sub-expressions are calculated to infinite precision, and only the final result is rounded.  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency::precise_math  
  
## See Also  
 [Concurrency::precise_math Namespace](../vs140/concurrency--precise_math-namespace.md)