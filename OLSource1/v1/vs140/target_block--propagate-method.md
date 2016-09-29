---
title: "target_block::propagate Method"
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
  - "agents/concurrency::target_block::propagate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "propagate method"
ms.assetid: a835077b-02d2-41cf-9ce3-406cf8560816
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# target_block::propagate Method
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
 The method throws an [invalid_argument](../vs140/invalid_argument-class.md) exception if either the `_PMessage` or `_PSource` parameter is `NULL`.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [target_block Class](../vs140/target_block-class.md)