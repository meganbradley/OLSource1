---
title: "single_assignment::consume_message Method"
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
  - "agents/concurrency::single_assignment::consume_message"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "consume_message method"
ms.assetid: bf9627df-5044-4d6c-bb4c-4a227fb00a03
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# single_assignment::consume_message Method
Consumes a message previously offered by the `single_assignment` and reserved by the target, returning a copy of the message to the caller.  
  
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
 [single_assignment Class](../vs140/single_assignment-class.md)