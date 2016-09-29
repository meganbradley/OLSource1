---
title: "timer::link_target_notification Method"
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
  - "agents/concurrency::timer::link_target_notification"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "link_target_notification method"
ms.assetid: edd918b8-e0cb-4eee-8dad-e02e61998bec
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# timer::link_target_notification Method
A callback that notifies that a new target has been linked to this `timer` messaging block.  
  
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
 [timer Class](../vs140/timer-class.md)