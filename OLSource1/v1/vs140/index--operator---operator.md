---
title: "index::operator++ Operator"
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
  - "amp/Concurrency::index::operator++"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator++"
ms.assetid: 6ea31225-fecc-4bcf-a497-aad2a4a861f9
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# index::operator++ Operator
Increments each element of the [index](../vs140/index-class.md) object.  
  
## Syntax  
  
```  
index<_Rank>& operator++() restrict(amp,cpu);  
  
index<_Rank> operator++(  
   int  
) restrict(amp,cpu);  
```  
  
## Return Value  
 For the prefix operator, the `index` object `(*this)`. For the suffix operator, a new `index` object.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [index Structure](../vs140/index-class.md)