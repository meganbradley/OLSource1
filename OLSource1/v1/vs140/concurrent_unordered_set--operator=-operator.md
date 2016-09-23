---
title: "concurrent_unordered_set::operator= Operator"
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
  - concurrent_unordered_set/concurrency::concurrent_unordered_set::operator=
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator= operator
ms.assetid: 04651c0d-70bd-49a9-84df-03944ff6b175
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# concurrent_unordered_set::operator= Operator
Assigns the contents of another `concurrent_unordered_set` object to this one. This method is not concurrency-safe.  
  
## Syntax  
  
```  
concurrent_unordered_set& operator=(  
   const concurrent_unordered_set& _Uset  
);  
  
concurrent_unordered_set& operator=(  
   concurrent_unordered_set&& _Uset  
);  
```  
  
#### Parameters  
 `_Uset`  
 The source `concurrent_unordered_set` object.  
  
## Return Value  
 A reference to this `concurrent_unordered_set` object.  
  
## Remarks  
 After erasing any existing elements in a concurrent unordered set, `operator=` either copies or moves the contents of `_Uset` into the concurrent unordered set.  
  
## Requirements  
 **Header:** concurrent_unordered_set.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_set Class](../vs140/concurrent_unordered_set-class.md)