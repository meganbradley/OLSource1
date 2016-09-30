---
title: "concurrent_queue::concurrent_queue Constructor"
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
  - "concurrent_queue/concurrency::concurrent_queue::concurrent_queue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "concurrent_queue, constructor"
ms.assetid: d582509e-e49e-48e2-a1bc-0a2fb1940beb
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_queue::concurrent_queue Constructor
Constructs a concurrent queue.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The type of the input iterator that specifies a range of values.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The allocator class to use with this object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The source <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object to copy or move elements from.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Position of the first element in the range of elements to be copied.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Position of the first element beyond the range of elements to be copied.  
  
## Remarks  
 All constructors store an allocator object <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and initialize the queue.  
  
 The first constructor specifies an empty initial queue and explicitly specifies the allocator type to be used.  
  
 The second constructor specifies a copy of the concurrent queue <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 The third constructor specifies a move of the concurrent queue <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 The fourth constructor specifies values supplied by the iterator range [<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>).  
  
## Requirements  
 **Header:** concurrent_queue.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_queue Class](../vs140/concurrent_queue-class.md)