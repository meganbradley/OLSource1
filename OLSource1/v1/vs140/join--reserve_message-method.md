---
title: "join::reserve_message Method"
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
  - agents/concurrency::join::reserve_message
dev_langs: 
  - C++
helpviewer_keywords: 
  - reserve_message method
ms.assetid: 21d6e3d0-0e43-4a69-8381-e284c8d23a1b
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# join::reserve_message Method
Reserves a message previously offered by this `join` messaging block.  
  
## Syntax  
  
```  
virtual bool reserve_message(  
   runtime_object_identity _MsgId  
);  
```  
  
#### Parameters  
 `_MsgId`  
 The `runtime_object_identity` of the offered `message` object.  
  
## Return Value  
 `true` if the message was successfully reserved, `false` otherwise.  
  
## Remarks  
 After `reserve` is called, if it returns `true`, either `consume` or `release` must be called to either take or release ownership of the message.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [join Class](../vs140/join-class.md)