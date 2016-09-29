---
title: "operator- Operator (C++ AMP)2"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "operator/ Operator (C++ AMP)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator/ operator"
ms.assetid: 1920286a-5de6-416e-8021-52adb0b5ea90
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator- Operator (C++ AMP)2
Computes the component-wise quotient of the specified arguments.  
  
## Syntax  
  
```  
template <  
   int _Rank,  
   template <int> class _Tuple_type  
>  
_Tuple_type<_Rank> operator/(  
   const _Tuple_type<_Rank>& _Lhs,  
   typename _Tuple_type<_Rank>::value_type _Rhs  
) restrict(amp,cpu);  
  
template <  
   int _Rank,  
   template <int> class _Tuple_type  
>  
_Tuple_type<_Rank> operator/(  
   typename _Tuple_type<_Rank>::value_type _Lhs,  
   const _Tuple_type<_Rank>& _Rhs  
) restrict(amp,cpu);  
```  
  
#### Parameters  
 `_Rank`  
 The rank of the tuple arguments.  
  
 `_Lhs`  
 The tuple to be divided.  
  
 `_Rhs`  
 The tuple to divide by.  
  
## Return Value  
 The component-wise quotient of the specified arguments.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [Concurrency Namespace (C++ Accelerated Massive Parallelism)](../vs140/concurrency-namespace--c---amp-.md)