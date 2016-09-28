---
title: "transformer::link_target_notification Method"
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
  - "agents/concurrency::transformer::link_target_notification"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "link_target_notification method"
ms.assetid: 418227fb-f395-47cb-a297-9e030670d235
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# transformer::link_target_notification Method
A callback that notifies that a new target has been linked to this `transformer` messaging block.  
  
## Syntax  
  
```  
virtual void link_target_notification(  
   _Inout_ ITarget<_Output> *  
);  
```  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [transformer Class](../vs140/transformer-class.md)