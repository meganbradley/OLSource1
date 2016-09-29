---
title: "concurrent_vector::push_back Method"
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
  - "concurrent_vector/concurrency::concurrent_vector::push_back"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "push_back method"
ms.assetid: d85745f0-7e1a-4000-8a99-5710d4f05103
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_vector::push_back Method
Appends the given item to the end of the concurrent vector. This method is concurrency-safe.  
  
## Syntax  
  
```  
iterator push_back(  
   const_reference _Item  
);  
  
iterator push_back(  
   _Ty &&_Item  
);  
```  
  
#### Parameters  
 `_Item`  
 The value to be appended.  
  
## Return Value  
 An iterator to item appended.  
  
## Requirements  
 **Header:** concurrent_vector.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_vector Class](../vs140/concurrent_vector-class.md)