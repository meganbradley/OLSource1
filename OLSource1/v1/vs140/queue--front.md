---
title: "queue::front"
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
  - "queue::front"
  - "queue.front"
  - "std.queue.front"
  - "std::queue::front"
  - "front"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "front method, queue"
ms.assetid: a3b00050-afc0-4768-8af8-f24550de13a5
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# queue::front
Returns a reference to the first element at the front of the queue.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The first element of the queue. If the queue is empty, the return value is undefined.  
  
## Remarks  
 If the return value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the queue object cannot be modified. If the return value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is assigned to a **reference**, the queue object can be modified.  
  
 The member function returns a **reference** to the first element of the controlled sequence, which must be nonempty.  
  
 When compiling with _SECURE_SCL 1, a runtime error will occur if you attempt to access an element in an empty queue.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<queue>  
  
 **Namespace:** std  
  
## See Also  
 [queue Class](../vs140/queue-class.md)   
 [queue Functions](../vs140/queue-functions.md)   
 [Standard Template Library](../vs140/standard-template-library.md)