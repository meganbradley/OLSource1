---
title: "overwrite_buffer::send_message Method"
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
  - agents/concurrency::overwrite_buffer::send_message
dev_langs: 
  - C++
helpviewer_keywords: 
  - send_message method
ms.assetid: 650d7274-b740-4fdd-91de-4d5b6b40c04e
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# overwrite_buffer::send_message Method
Synchronously passes a message from an `ISource` block to this `overwrite_buffer` messaging block. It is invoked by the `send` method, when called by a source block.  
  
## Syntax  
  
```  
virtual message_status send_message(  
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
 [overwrite_buffer Class](../vs140/overwrite_buffer-class.md)