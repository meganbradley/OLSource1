---
title: "unbounded_buffer::consume_message Method"
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
  - "agents/concurrency::unbounded_buffer::consume_message"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "consume_message method"
ms.assetid: a36e5117-a80f-4361-8751-6f8758b37ba2
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unbounded_buffer::consume_message Method
Consumes a message previously offered by the `unbounded_buffer` messaging block and reserved by the target, transferring ownership to the caller.  
  
## Syntax  
  
```  
virtual message<_Type> * consume_message(  
   runtime_object_identity _MsgId  
);  
```  
  
#### Parameters  
 `_MsgId`  
 The `runtime_object_identity` of the `message` object being consumed.  
  
## Return Value  
 A pointer to the `message` object that the caller now has ownership of.  
  
## Remarks  
 Similar to `accept`, but is always preceded by a call to `reserve`.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [unbounded_buffer Class](../vs140/unbounded_buffer-class.md)