---
title: "concurrent_vector::crend Method"
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
  - "concurrent_vector/concurrency::concurrent_vector::crend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crend method"
ms.assetid: d5eca002-82fd-4d2b-9e80-b5d2416aeefc
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_vector::crend Method
Returns an iterator of type `const_reverse_iterator` to the end of the concurrent vector. This method is concurrency-safe.  
  
## Syntax  
  
```  
const_reverse_iterator crend() const;  
```  
  
## Return Value  
 An iterator of type `const_reverse_iterator` to the end of the concurrent vector.  
  
## Requirements  
 **Header:** concurrent_vector.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_vector Class](../vs140/concurrent_vector-class.md)