---
title: "overwrite_buffer::release_message Method"
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
  - agents/concurrency::overwrite_buffer::release_message
dev_langs: 
  - C++
helpviewer_keywords: 
  - release_message method
ms.assetid: d349490a-1f14-4287-b12e-62e582bf3100
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# overwrite_buffer::release_message Method
Releases a previous message reservation.  
  
## Syntax  
  
```  
virtual void release_message(  
   runtime_object_identity _MsgId  
);  
```  
  
#### Parameters  
 `_MsgId`  
 The `runtime_object_identity` of the `message` object being released.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [overwrite_buffer Class](../vs140/overwrite_buffer-class.md)