---
title: "extent::operator-= Operator2"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
H1: extent::operator-= Operator
f1_keywords: 
  - amp/Concurrency::extent::operator-=
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator-=
ms.assetid: c5fe649b-fdbc-41a0-9c6f-7834fb28b4cf
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# extent::operator-= Operator2
Subtracts the specified number from each element of the [extent](../vs140/extent-class--c---amp-.md) object.  
  
## Syntax  
  
```  
extent<_Rank>& operator-=(  
   const extent<_Rank>& _Rhs  
) restrict(amp,cpu);  
  
extent<_Rank>& operator-=(  
   const index<_Rank>& _Rhs  
) restrict(amp,cpu);  
  
extent<_Rank>& operator-=(  
   int _Rhs  
) restrict(amp,cpu);  
```  
  
#### Parameters  
 `_Rhs`  
 The number to subtract.  
  
## Return Value  
 The resulting `extent` object.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [extent Structure](../vs140/extent-class--c---amp-.md)