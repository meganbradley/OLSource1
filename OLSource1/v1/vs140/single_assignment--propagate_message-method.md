---
title: "single_assignment::propagate_message Method"
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
  - "agents/concurrency::single_assignment::propagate_message"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "propagate_message method"
ms.assetid: 945e129f-5d30-44bf-814d-e890ae62a9b5
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# single_assignment::propagate_message Method
Asynchronously passes a message from an `ISource` block to this `single_assignment` messaging block. It is invoked by the `propagate` method, when called by a source block.  
  
## Syntax  
  
```  
virtual message_status propagate_message(  
   _Inout_ message<_Type> * _PMessage,  
   _Inout_ ISource<_Type> * _PSource  
);  
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
 [single_assignment Class](../vs140/single_assignment-class.md)