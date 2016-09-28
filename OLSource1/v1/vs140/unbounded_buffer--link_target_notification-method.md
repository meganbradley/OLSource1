---
title: "unbounded_buffer::link_target_notification Method"
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
  - "agents/concurrency::unbounded_buffer::link_target_notification"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "link_target_notification method"
ms.assetid: e9ceb9ba-f84a-4d93-b17e-71dd29152d7c
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unbounded_buffer::link_target_notification Method
A callback that notifies that a new target has been linked to this `unbounded_buffer` messaging block.  
  
## Syntax  
  
```  
virtual void link_target_notification(  
   _Inout_ ITarget<_Type> * _PTarget  
);  
```  
  
#### Parameters  
 `_PTarget`  
 A pointer to the newly linked target.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [unbounded_buffer Class](../vs140/unbounded_buffer-class.md)