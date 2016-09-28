---
title: "call::send_message Method"
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
  - "agents/concurrency::call::send_message"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "send_message method"
ms.assetid: a4962f71-1c8a-4ed1-b9d7-19267ee0ae59
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# call::send_message Method
Synchronously passes a message from an `ISource` block to this `call` messaging block. It is invoked by the `send` method, when called by a source block.  
  
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
 [call Class](../vs140/call-class.md)