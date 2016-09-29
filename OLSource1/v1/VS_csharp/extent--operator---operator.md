---
title: "extent::operator++ Operator"
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
  - "amp/Concurrency::extent::operator++"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator++"
ms.assetid: 1abab27d-c57a-4a8e-b6ba-f624a9eb6512
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# extent::operator++ Operator
Increments each element of the [extent](../VS_csharp/extent-class--c---amp-.md) object.  
  
## Syntax  
  
```  
extent<_Rank>& operator++() restrict(amp,cpu);  
  
extent<_Rank> operator++(  
   int  
) restrict(amp,cpu);  
```  
  
## Return Value  
 For the prefix operator, the `extent` object (`*this`). For the suffix operator, a new `extent` object.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [extent Structure](../VS_csharp/extent-class--c---amp-.md)