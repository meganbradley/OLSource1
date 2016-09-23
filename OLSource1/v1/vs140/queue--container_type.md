---
title: "queue::container_type"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - std::queue::container_type
  - container_type
  - queue::container_type
  - queue.container_type
  - std.queue.container_type
dev_langs: 
  - C++
helpviewer_keywords: 
  - container_type typedef
ms.assetid: 3f1f1c34-a2d1-4406-9b6e-ba26db902f9e
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# queue::container_type
A type that provides the base container to be adapted.  
  
## Syntax  
  
```  
  
typedef Container container_type;  
```  
  
## Remarks  
 The type is a synonym for the template parameter `Container`. Two STL sequence container classes — the list class and the default deque class — meet the requirements to be used as the base container for a queue object. User-defined types satisfying the requirements may also be used.  
  
 For more information on `Container`, see the Remarks section of the [queue Class](../vs140/queue-class.md) topic.  
  
## Example  
 See the example for [queue](../vs140/queue--queue.md) for an example of how to declare and use `container_type`.  
  
## Requirements  
 **Header:** <queue\>  
  
 **Namespace:** std  
  
## See Also  
 [queue Class](../vs140/queue-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)