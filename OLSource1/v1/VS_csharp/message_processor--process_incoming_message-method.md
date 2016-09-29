---
title: "message_processor::process_incoming_message Method"
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
  - "agents/concurrency::message_processor::process_incoming_message"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "process_incoming_message method"
ms.assetid: a274a10e-58ac-4aab-9742-db75a62d3f3e
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# message_processor::process_incoming_message Method
When overridden in a derived class, performs the forward processing of messages into the block. Called once every time a new message is added and the queue is found to be empty.  
  
## Syntax  
  
```  
virtual void process_incoming_message() = 0;  
```  
  
## Remarks  
 Message block implementations should override this method.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [message_processor Class](../VS_csharp/message_processor-class.md)