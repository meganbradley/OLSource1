---
title: "operator+ Operator (C++ AMP)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator+ operator"
ms.assetid: 0e2c3f7f-6788-4f42-ac53-68b50fe252df
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator+ Operator (C++ AMP)
Computes the component-wise sum of the specified arguments.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The rank of the tuple arguments.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 One of the arguments to add.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 One of the arguments to add.  
  
## Return Value  
 The component-wise sum of the specified arguments.  
  
## Remarks  
 The arguments to this operator are either tuples of the same rank and value type, or one tuple of a given rank and value type together with a scalar argument of the same value type. In both cases, the return type is a tuple of the same rank and value type as the tuple argument. When one of the arguments is a scalar, it is treated as a tuple of the same rank and value type as the other argument in which each element has the same value as the scalar argument.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [Concurrency Namespace (C++ Accelerated Massive Parallelism)](../vs140/concurrency-namespace--c---amp-.md)