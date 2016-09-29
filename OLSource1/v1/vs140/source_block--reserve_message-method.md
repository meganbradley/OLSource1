---
title: "source_block::reserve_message Method"
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
  - "agents/concurrency::source_block::reserve_message"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reserve_message method"
ms.assetid: 94c8348f-3bc0-4a30-8608-b1d48a90e789
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# source_block::reserve_message Method
When overridden in a derived class, reserves a message previously offered by this `source_block` object.  
  
## Syntax  
  
```  
virtual bool reserve_message(  
   runtime_object_identity _MsgId  
) = 0;  
```  
  
#### Parameters  
 `_MsgId`  
 The `runtime_object_identity` of the `message` object being reserved.  
  
## Return Value  
 `true` if the message was successfully reserved, `false` otherwise.  
  
## Remarks  
 After `reserve` is called, if it returns `true`, either `consume` or `release` must be called to either take or release ownership of the message.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [source_block Class](../vs140/source_block-class.md)