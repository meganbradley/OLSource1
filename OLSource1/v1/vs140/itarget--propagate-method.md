---
title: "ITarget::propagate Method"
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
  - agents/concurrency::ITarget::propagate
dev_langs: 
  - C++
helpviewer_keywords: 
  - propagate method
ms.assetid: 77fc1942-253b-4662-ab8e-c6732ab7fffb
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ITarget::propagate Method
When overridden in a derived class, asynchronously passes a message from a source block to this target block.  
  
## Syntax  
  
```  
virtual message_status propagate(  
   _Inout_opt_ message<_Type> * _PMessage,  
   _Inout_opt_ ISource<_Type> * _PSource  
) = 0;  
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
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ITarget Class](../vs140/itarget-class.md)