---
title: "concurrent_vector::end Method"
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
  - "concurrent_vector/concurrency::concurrent_vector::end"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "end method"
ms.assetid: a8e71845-f5a4-4333-9598-8a1732cb8724
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_vector::end Method
Returns an iterator of type `iterator` or `const_iterator` to the end of the concurrent vector. This method is concurrency-safe.  
  
## Syntax  
  
```  
iterator end();  
  
const_iterator end() const;  
```  
  
## Return Value  
 An iterator of type `iterator` or `const_iterator` to the end of the concurrent vector.  
  
## Requirements  
 **Header:** concurrent_vector.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_vector Class](../vs140/concurrent_vector-class.md)