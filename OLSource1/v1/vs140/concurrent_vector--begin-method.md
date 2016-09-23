---
title: "concurrent_vector::begin Method"
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
  - concurrent_vector/concurrency::concurrent_vector::begin
dev_langs: 
  - C++
helpviewer_keywords: 
  - begin method
ms.assetid: fd3a7972-420e-4622-928c-60d97da55953
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# concurrent_vector::begin Method
Returns an iterator of type `iterator` or `const_iterator` to the beginning of the concurrent vector. This method is concurrency-safe.  
  
## Syntax  
  
```  
iterator begin();  
  
const_iterator begin() const;  
```  
  
## Return Value  
 An iterator of type `iterator` or `const_iterator` to the beginning of the concurrent vector.  
  
## Requirements  
 **Header:** concurrent_vector.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_vector Class](../vs140/concurrent_vector-class.md)