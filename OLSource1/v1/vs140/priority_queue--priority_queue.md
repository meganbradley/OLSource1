---
title: "priority_queue::priority_queue"
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
  - "priority_queue.priority_queue"
  - "std.priority_queue.priority_queue"
  - "priority_queue"
  - "std::priority_queue::priority_queue"
  - "priority_queue::priority_queue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "priority_queue class, constructor"
  - "priority_queue method"
ms.assetid: 1761ee2e-4e18-4f39-bf9f-910404d46a2c
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# priority_queue::priority_queue
Constructs a priority_queue that is empty or that is a copy of a range of a base container object or of another priority_queue.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *__Comp*  
 The comparison function of type **constTraits** used to order the elements in the priority_queue, which defaults to compare function of the base container.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The base container of which the constructed priority_queue is to be a copy.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The priority_queue of which the constructed set is to be a copy.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The position of the first element in the range of elements to be copied.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The position of the first element beyond the range of elements to be copied.  
  
## Remarks  
 Each of the first three constructors specifies an empty initial priority_queue, the second also specifying the type of comparison function (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) to be used in establishing the order of the elements and the third explicitly specifying the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>) to be used. The keyword **explicit** suppresses certain kinds of automatic type conversion.  
  
 The fourth constructor specifies a copy of the priority_queue <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 The last three constructors copy the range [*_First, _Last*) of some container and use the values to initialize a priority_queue with increasing explicitness in specifying the type of comparison function of class **Traits** and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<queue>  
  
 **Namespace:** std  
  
## See Also  
 [priority_queue Class](../vs140/priority_queue-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)