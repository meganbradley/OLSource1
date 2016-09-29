---
title: "network_link_registry::remove Method"
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
  - "agents/concurrency::network_link_registry::remove"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "remove method"
ms.assetid: b212dafa-a2b0-4e4c-95d4-a08ac1a4965c
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# network_link_registry::remove Method
When overridden in a derived class, removes a specified block from the `network_link_registry` object.  
  
## Syntax  
  
```  
virtual bool remove(  
   _EType _Link  
) = 0;  
```  
  
#### Parameters  
 `_Link`  
 A pointer to a block to be removed, if found.  
  
## Return Value  
 `true` if the link was found and removed, `false` otherwise.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [network_link_registry Class](../vs140/network_link_registry-class.md)