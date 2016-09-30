---
title: "concurrent_unordered_multimap::concurrent_unordered_multimap Constructor"
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
  - "concurrent_unordered_map/concurrency::concurrent_unordered_multimap::concurrent_unordered_multimap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "concurrent_unordered_multimap, constructor"
ms.assetid: 259a5724-a83d-44aa-b6e2-98de0f24609c
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_multimap::concurrent_unordered_multimap Constructor
Constructs a concurrent unordered multimap.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The type of the input iterator.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The initial number of buckets for this unordered multimap.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The hash function for this unordered multimap.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The equality comparison function for this unordered multimap.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The allocator for this unordered multimap.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The position of the first element in the range of elements to be copied.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The position of the first element beyond the range of elements to be copied.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The source <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object to copy elements from.  
  
## Remarks  
 All constructors store an allocator object <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and initialize the unordered multimap.  
  
 The first constructor specifies an empty initial multimap and explicitly specifies the number of buckets, hash function, equality function and allocator type to be used.  
  
 The second constructor specifies an allocator for the unordered multimap.  
  
 The third constructor specifies values supplied by the iterator range [<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>).  
  
 The fourth and fifth constructors specify a copy of the concurrent unordered multimap <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 The last constructor specifies a move of the concurrent unordered multimap <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** concurrent_unordered_map.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_multimap Class](../vs140/concurrent_unordered_multimap-class.md)