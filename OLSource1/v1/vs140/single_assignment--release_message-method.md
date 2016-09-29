---
title: "single_assignment::release_message Method"
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
  - "agents/concurrency::single_assignment::release_message"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "release_message method"
ms.assetid: 7900102b-ad4b-4539-b8dc-41e116b8310e
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# single_assignment::release_message Method
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
 [single_assignment Class](../vs140/single_assignment-class.md)