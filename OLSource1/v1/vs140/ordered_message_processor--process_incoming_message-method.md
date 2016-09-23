---
title: "ordered_message_processor::process_incoming_message Method"
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
  - agents/concurrency::ordered_message_processor::process_incoming_message
dev_langs: 
  - C++
helpviewer_keywords: 
  - process_incoming_message method
ms.assetid: d5dcf035-0dd5-48fa-a678-ec2631fa2380
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ordered_message_processor::process_incoming_message Method
The processing function that is called asynchronously. It dequeues messages and begins processing them.  
  
## Syntax  
  
```  
virtual void process_incoming_message();  
```  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ordered_message_processor Class](../vs140/ordered_message_processor-class.md)