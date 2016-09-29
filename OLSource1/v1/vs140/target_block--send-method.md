---
title: "target_block::send Method"
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
  - "agents/concurrency::target_block::send"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "send method"
ms.assetid: a28a7868-d492-4a5a-8c3b-1e908d239a5a
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# target_block::send Method
Synchronously passes a message from a source block to this target block.  
  
## Syntax  
  
```  
virtual message_status send(  
   _Inout_ message<_Source_type> * _PMessage,  
   _Inout_ ISource<_Source_type> * _PSource  
);  
```  
  
#### Parameters  
 `_PMessage`  
 A pointer to the `message` object.  
  
 `_PSource`  
 A pointer to the source block offering the message.  
  
## Return Value  
 A [message_status](../vs140/message_status-enumeration.md) indication of what the target decided to do with the message.  
  
## Remarks  
 The method throws an [invalid_argument](../vs140/invalid_argument-class.md) exception if either the `_PMessage` or `_PSource` parameter is `NULL`.  
  
 Using the `send` method outside of message initiation and to propagate messages within a network is dangerous and can lead to deadlock.  
  
 When `send` returns, the message has either already been accepted, and transferred into the target block, or it has been declined by the target.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [target_block Class](../vs140/target_block-class.md)