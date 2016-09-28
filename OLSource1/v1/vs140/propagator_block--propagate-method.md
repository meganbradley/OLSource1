---
title: "propagator_block::propagate Method"
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
  - "agents/concurrency::propagator_block::propagate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "propagate method"
ms.assetid: 9b549165-4306-4b39-92d5-cb4c4d600d82
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# propagator_block::propagate Method
Asynchronously passes a message from a source block to this target block.  
  
## Syntax  
  
```  
virtual message_status propagate(  
   _Inout_opt_ message<_Source_type> * _PMessage,  
   _Inout_opt_ ISource<_Source_type> * _PSource  
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
 The `propagate` method is invoked on a target block by a linked source block. It queues up an asynchronous task to handle the message, if one is not already queued or executing.  
  
 The method throws an [invalid_argument](../vs140/invalid_argument-class.md) exception if either the `_PMessage` or `_PSource` parameter is `NULL`.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [propagator_block Class](../vs140/propagator_block-class.md)