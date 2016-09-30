---
title: "concurrent_vector::at Method"
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
  - "concurrent_vector/concurrency::concurrent_vector::at"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "at method"
ms.assetid: c3663c3a-1342-4f56-86ef-3f33d19af211
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_vector::at Method
Provides access to the element at the given index in the concurrent vector. This method is concurrency-safe for read operations, and also while growing the vector, as long as you have ensured that the value <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is less than the size of the concurrent vector.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The index of the element to be retrieved.  
  
## Return Value  
 A reference to the item at the given index.  
  
## Remarks  
 The version of the function <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> that returns a non-<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> reference cannot be used to concurrently write to the element from different threads. A different synchronization object should be used to synchronize concurrent read and write operations to the same data element.  
  
 The method throws <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is greater than or equal to the size of the concurrent vector, and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the index is for a broken portion of the vector. For details on how a vector can become broken, see [Parallel Containers and Objects](../vs140/parallel-containers-and-objects.md).  
  
## Requirements  
 **Header:** concurrent_vector.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_vector Class](../vs140/concurrent_vector-class.md)