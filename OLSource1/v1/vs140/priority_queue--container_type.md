---
title: "priority_queue::container_type"
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
  - "std.priority_queue.container_type"
  - "container_type"
  - "std::priority_queue::container_type"
  - "priority_queue::container_type"
  - "priority_queue.container_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "container_type typedef"
ms.assetid: 025e3488-24cd-4e9c-930d-a546c9e912c2
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# priority_queue::container_type
A type that provides the base container to be adapted.  
  
## Syntax  
  
```  
  
typedef Container container_type;  
```  
  
## Remarks  
 The type is a synonym for the template parameter `Container`. The STL sequence container class deque and the default class vector meet the requirements to be used as the base container for a priority_queue object. User-defined types satisfying the requirements may also be used.  
  
 For more information on `Container`, see the Remarks section of the [priority_queue Class](../vs140/priority_queue-class.md) topic.  
  
## Example  
 See the example for [priority_queue](../vs140/priority_queue--priority_queue.md) for an example of how to declare and use `container_type`.  
  
## Requirements  
 **Header:** <queue\>  
  
 **Namespace:** std  
  
## See Also  
 [priority_queue Class](../vs140/priority_queue-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)