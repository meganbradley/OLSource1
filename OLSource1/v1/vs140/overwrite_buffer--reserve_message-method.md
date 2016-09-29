---
title: "overwrite_buffer::reserve_message Method"
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
  - "agents/concurrency::overwrite_buffer::reserve_message"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reserve_message method"
ms.assetid: 0909e565-cb64-45ee-b409-9b45b31bf395
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# overwrite_buffer::reserve_message Method
Reserves a message previously offered by this `overwrite_buffer` messaging block.  
  
## Syntax  
  
```  
virtual bool reserve_message(  
   runtime_object_identity _MsgId  
);  
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
 [overwrite_buffer Class](../vs140/overwrite_buffer-class.md)