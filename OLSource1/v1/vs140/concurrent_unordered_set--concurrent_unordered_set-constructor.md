---
title: "concurrent_unordered_set::concurrent_unordered_set Constructor"
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
  - "concurrent_unordered_set/concurrency::concurrent_unordered_set::concurrent_unordered_set"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "concurrent_unordered_set, constructor"
ms.assetid: ae86d264-8e7a-4ae1-ac7b-b2abe25863de
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_set::concurrent_unordered_set Constructor
Constructs a concurrent unordered set.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The type of the input iterator.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The initial number of buckets for this unordered set.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The hash function for this unordered set.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The equality comparison function for this unordered set.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The allocator for this unordered set.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The source <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object to copy or move elements from.  
  
## Remarks  
 All constructors store an allocator object <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and initialize the unordered set.  
  
 The first constructor specifies an empty initial set and explicitly specifies the number of buckets, hash function, equality function and allocator type to be used.  
  
 The second constructor specifies an allocator for the unordered set.  
  
 The third constructor specifies values supplied by the iterator range [<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>).  
  
 The fourth and fifth constructors specify a copy of the concurrent unordered set <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 The last constructor specifies a move of the concurrent unordered set <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** concurrent_unordered_set.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_set Class](../vs140/concurrent_unordered_set-class.md)