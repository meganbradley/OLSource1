---
title: "operator!= Operator (C++ AMP)"
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
ms.assetid: 747a979c-6ac2-49c6-a5f1-3a82080367f8
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator!= Operator (C++ AMP)
Determines whether the specified arguments are not equal.  
  
## Syntax  
  
```  
template <  
   int _Rank,  
   template <int> class _Tuple_type  
>  
bool operator!=(  
   const _Tuple_type<_Rank>& _Lhs,  
   const _Tuple_type<_Rank>& _Rhs  
) restrict(amp);  
```  
  
#### Parameters  
 `_Rank`  
 The rank of the tuple arguments.  
  
 `_Lhs`  
 One of the tuples to compare.  
  
 `_Rhs`  
 One of the tuples to compare.  
  
## Return Value  
 `true` if the tuples are not equal; otherwise, `false`.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace (C++ AMP)](../vs140/concurrency-namespace--c---amp-.md)