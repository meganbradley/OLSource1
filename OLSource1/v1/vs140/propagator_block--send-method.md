---
title: "propagator_block::send Method"
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
  - "agents/concurrency::propagator_block::send"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "send method"
ms.assetid: 6302db23-08d1-4310-8706-a062b862490e
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# propagator_block::send Method
Synchronously initiates a message to this block. Called by an `ISource` block. When this function completes, the message will already have propagated into the block.  
  
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
 This method throws an [invalid_argument](../vs140/invalid_argument-class.md) exception if either the `_PMessage` or `_PSource` parameter is `NULL`.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [propagator_block Class](../vs140/propagator_block-class.md)