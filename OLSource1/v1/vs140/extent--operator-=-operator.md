---
title: "extent::operator*= Operator"
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
  - "amp/Concurrency::extent::operator*="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator*="
ms.assetid: 1d6c9274-c384-4bbb-ac3c-a68187dcff60
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# extent::operator*= Operator
Multiplies each element in the [extent](../vs140/extent-class--c---amp-.md) object by the specified number.  
  
## Syntax  
  
```  
extent<_Rank>& operator*=(  
   int _Rhs  
) restrict(amp,cpu);  
```  
  
#### Parameters  
 `_Rhs`  
 The number to multiply.  
  
## Return Value  
 The `extent` object.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [extent Structure](../vs140/extent-class--c---amp-.md)