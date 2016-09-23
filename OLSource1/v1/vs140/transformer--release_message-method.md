---
title: "transformer::release_message Method"
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
  - agents/concurrency::transformer::release_message
dev_langs: 
  - C++
helpviewer_keywords: 
  - release_message method
ms.assetid: c9c91c35-3c8f-4046-be26-de8f1a252ada
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# transformer::release_message Method
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
 [transformer Class](../vs140/transformer-class.md)