---
title: "concurrent_vector::operatorOperator"
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
  - "concurrent_vector/concurrency::concurrent_vector::operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator[] operator"
ms.assetid: 1875880f-643b-4d60-ab59-a27f480313e5
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_vector::operatorOperator
Provides access to the element at the given index in the concurrent vector. This method is concurrency-safe for read operations, and also while growing the vector, as long as the you have ensured that the value <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is less than the size of the concurrent vector.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The index of the element to be retrieved.  
  
## Return Value  
 A reference to the item at the given index.  
  
## Remarks  
 The version of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> that returns a non-<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> reference cannot be used to concurrently write to the element from different threads. A different synchronization object should be used to synchronize concurrent read and write operations to the same data element.  
  
 No bounds checking is performed to ensure that <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is a valid index into the concurrent vector.  
  
## Requirements  
 **Header:** concurrent_vector.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_vector Class](../vs140/concurrent_vector-class.md)