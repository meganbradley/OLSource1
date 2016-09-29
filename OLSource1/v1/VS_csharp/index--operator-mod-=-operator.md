---
title: "index::operator(mod)= Operator"
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
  - "amp/Concurrency::index::operator(mod)="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator%="
ms.assetid: f36dd4b7-0815-4e70-b5a9-7f8d81995b8a
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# index::operator(mod)= Operator
Calculates the modulus (remainder) of each element in the [index](../VS_csharp/index-class.md) object when that element is divided by the specified number.  
  
## Syntax  
  
```  
index<_Rank>& operator%=(  
   int _Rhs  
) restrict(cpu, amp);  
```  
  
#### Parameters  
 `_Rhs`  
 The number to divide by to find the modulus.  
  
## Return Value  
 The [index](../VS_csharp/index-class.md) object.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [index Structure](../VS_csharp/index-class.md)