---
title: "choice::release Method"
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
  - agents/concurrency::choice::release
dev_langs: 
  - C++
helpviewer_keywords: 
  - release method
ms.assetid: 88edceed-4a0f-48a7-9f5a-e3932d90685a
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# choice::release Method
Releases a previous successful message reservation.  
  
## Syntax  
  
```  
virtual void release(  
   runtime_object_identity _MsgId,  
   _Inout_ ITarget<size_t> * _PTarget  
);  
```  
  
#### Parameters  
 `_MsgId`  
 The `runtime_object_identity` of the `message` object being released.  
  
 `_PTarget`  
 A pointer to the target block that is calling the `release` method.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [choice Class](../vs140/choice-class.md)