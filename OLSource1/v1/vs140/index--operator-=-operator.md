---
title: "index::operator+= Operator"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - amp/Concurrency::index::operator+=
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator+=
ms.assetid: 08c6c3a4-7d65-4870-8213-4cda9132895c
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# index::operator+= Operator
Adds the specified number to each element of the [index](../vs140/index-class.md) object.  
  
## Syntax  
  
```  
index<_Rank>& operator+=(  
   const index<_Rank>& _Rhs  
) restrict(amp,cpu);  
  
index<_Rank>& operator+=(  
   int _Rhs  
) restrict(amp,cpu);  
```  
  
#### Parameters  
 `_Rhs`  
 The number to add.  
  
## Return Value  
 The `index` object.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [index Structure](../vs140/index-class.md)