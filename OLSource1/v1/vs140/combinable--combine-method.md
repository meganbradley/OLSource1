---
title: "combinable::combine Method"
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
  - "ppl/concurrency::combinable::combine"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "combine method"
ms.assetid: 492e55cc-c1f8-4e0e-8356-2636f25563de
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# combinable::combine Method
Computes a final value from the set of thread-local sub-computations by calling the supplied combine functor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The type of the function object that will be invoked to combine two thread-local sub-computations.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The functor that is used to combine the sub-computations. Its signature is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and it must be associative and commutative.  
  
## Return Value  
 The final result of combining all the thread-private sub-computations.  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [combinable Class](../vs140/combinable-class.md)   
 [Parallel Containers and Objects](../vs140/parallel-containers-and-objects.md)