---
title: "ordered_message_processor::async_send Method"
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
  - "agents/concurrency::ordered_message_processor::async_send"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "async_send method"
ms.assetid: e91b867d-4343-4828-839d-50b37f315a00
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ordered_message_processor::async_send Method
Asynchronously queues up messages and starts a processing task, if this has not been done already.  
  
## Syntax  
  
```  
virtual void async_send(  
   _Inout_opt_ message<_Type> * _Msg  
);  
```  
  
#### Parameters  
 `_Msg`  
 A pointer to a message.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ordered_message_processor Class](../vs140/ordered_message_processor-class.md)