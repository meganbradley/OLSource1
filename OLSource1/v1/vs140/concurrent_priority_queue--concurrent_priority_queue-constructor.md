---
title: "concurrent_priority_queue::concurrent_priority_queue Constructor"
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
  - "concurrent_priority_queue/concurrency::concurrent_priority_queue::concurrent_priority_queue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "concurrent_priority_queue, constructor"
ms.assetid: 6b56ec2d-94c6-43c6-b588-2c5b12315098
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_priority_queue::concurrent_priority_queue Constructor
Constructs a concurrent priority queue.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The type of the input iterator.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The allocator class to use with this object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The initial capacity of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The position of the first element in the range of elements to be copied.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The position of the first element beyond the range of elements to be copied.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The source <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object to copy or move elements from.  
  
## Remarks  
 All constructors store an allocator object <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and initialize the priority queue.  
  
 The first constructor specifies an empty initial priority queue and optionally specifies an allocator.  
  
 The second constructor specifies a priority queue with an initial capacity <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and optionally specifies an allocator.  
  
 The third constructor specifies values supplied by the iterator range [<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>) and optionally specifies an allocator.  
  
 The fourth and fifth constructors specify a copy of the priority queue <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 The sixth and seventh constructors specify a move of the priority queue <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** concurrent_priority_queue.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_priority_queue Class](../vs140/concurrent_priority_queue-class.md)