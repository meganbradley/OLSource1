---
title: "index::operator-= Operator2"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "index::operator/= Operator"
f1_keywords: 
  - "amp/Concurrency::index::operator/="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator/="
ms.assetid: 48191629-07ee-45cc-b4de-ba48acacbe9a
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# index::operator-= Operator2
Divides each element in the [index](../vs140/index-class.md) object by the specified number.  
  
## Syntax  
  
```  
index<_Rank>& operator/=(  
   int _Rhs  
) restrict(amp,cpu);  
```  
  
#### Parameters  
 `_Rhs`  
 The number to divide by.  
  
## Return Value  
 The `index` object.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [index Structure](../vs140/index-class.md)