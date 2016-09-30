---
title: "queue::queue"
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
  - "queue::queue"
  - "queue.queue"
  - "std::queue::queue"
  - "std.queue.queue"
  - "queue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "queue class, constructor"
  - "queue method"
ms.assetid: 86e62476-c2ca-4460-abdc-f9fc5f61e83b
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# queue::queue
Constructs a queue that is empty or that is a copy of a base container object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The **const** container of which the constructed queue is to be a copy.  
  
## Remarks  
 The default base container for queue is deque. You can also specify list as a base container, but you cannot specify vector, because it lacks the required <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member function.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The element at the front of queue q5 is 1.**  
**The element at the back of queue q5 is 2.**   
## Requirements  
 **Header:** \<queue>  
  
 **Namespace:** std  
  
## See Also  
 [queue Class](../vs140/queue-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)