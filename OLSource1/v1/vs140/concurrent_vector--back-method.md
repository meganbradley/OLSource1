---
title: "concurrent_vector::back Method"
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
  - "concurrent_vector/concurrency::concurrent_vector::back"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "back method"
ms.assetid: fa42a458-b358-4037-b65b-e48b21a1609d
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_vector::back Method
Returns a reference or a `const` reference to the last element in the concurrent vector. If the concurrent vector is empty, the return value is undefined. This method is concurrency-safe.  
  
## Syntax  
  
```  
reference back();  
  
const_reference back() const;  
```  
  
## Return Value  
 A reference or a `const` reference to the last element in the concurrent vector.  
  
## Requirements  
 **Header:** concurrent_vector.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_vector Class](../vs140/concurrent_vector-class.md)