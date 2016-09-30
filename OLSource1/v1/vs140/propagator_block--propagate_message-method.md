---
title: "propagator_block::propagate_message Method"
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
  - "agents/concurrency::propagator_block::propagate_message"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "propagate_message method"
ms.assetid: 9e868729-9235-481f-84c9-589b5befd2ce
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# propagator_block::propagate_message Method
When overridden in a derived class, this method asynchronously passes a message from an `ISource` block to this `propagator_block` object. It is invoked by the `propagate` method, when called by a source block.  
  
## Syntax  
  
```  
virtual message_status propagate_message(  
   _Inout_ message<_Source_type> * _PMessage,  
   _Inout_ ISource<_Source_type> * _PSource  
) = 0;  
```  
  
#### Parameters  
 `_PMessage`  
 A pointer to the `message` object.  
  
 `_PSource`  
 A pointer to the source block offering the message.  
  
## Return Value  
 A [message_status](../vs140/message_status-enumeration.md) indication of what the target decided to do with the message.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [propagator_block Class](../vs140/propagator_block-class.md)