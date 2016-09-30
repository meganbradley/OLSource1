---
title: "concurrent_unordered_map::concurrent_unordered_map Constructor"
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
  - "concurrent_unordered_map/concurrency::concurrent_unordered_map::concurrent_unordered_map"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "concurrent_unordered_map, constructor"
ms.assetid: 871fb66a-31a2-47d8-acfd-8e39aedf1529
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_map::concurrent_unordered_map Constructor
Constructs a concurrent unordered map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The type of the input iterator.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The initial number of buckets for this unordered map.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The hash function for this unordered map.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The equality comparison function for this unordered map.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The allocator for this unordered map.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The position of the first element in the range of elements to be copied.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The position of the first element beyond the range of elements to be copied.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The source <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object to copy or move elements from.  
  
## Remarks  
 All constructors store an allocator object <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and initialize the unordered map.  
  
 The first constructor specifies an empty initial map and explicitly specifies the number of buckets, hash function, equality function and allocator type to be used.  
  
 The second constructor specifies an allocator for the unordered map.  
  
 The third constructor specifies values supplied by the iterator range [<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>).  
  
 The fourth and fifth constructors specify a copy of the concurrent unordered map <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 The last constructor specifies a move of the concurrent unordered map <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** concurrent_unordered_map.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_map Class](../vs140/concurrent_unordered_map-class.md)