---
title: "ordered_message_processor::ordered_message_processor Constructor"
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
  - agents/concurrency::ordered_message_processor::ordered_message_processor
dev_langs: 
  - C++
helpviewer_keywords: 
  - ordered_message_processor, constructor
ms.assetid: 13aa611f-6d30-4d5e-9f93-3ea80205e782
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ordered_message_processor::ordered_message_processor Constructor
Constructs an `ordered_message_processor` object.  
  
## Syntax  
  
```  
ordered_message_processor();  
```  
  
## Remarks  
 This `ordered_message_processor` will not schedule asynchronous or synchronous handlers until the `initialize` function is called.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ordered_message_processor Class](../vs140/ordered_message_processor-class.md)