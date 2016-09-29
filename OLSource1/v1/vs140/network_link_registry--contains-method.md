---
title: "network_link_registry::contains Method"
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
  - "agents/concurrency::network_link_registry::contains"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "contains method"
ms.assetid: 83ab745d-68a1-448f-99ff-cab59989c8e3
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# network_link_registry::contains Method
When overridden in a derived class, searches the `network_link_registry` object for a specified block.  
  
## Syntax  
  
```  
virtual bool contains(  
   _EType _Link  
) = 0;  
```  
  
#### Parameters  
 `_Link`  
 A pointer to a block that is being searched for in the `network_link_registry` object.  
  
## Return Value  
 `true` if the block was found, `false` otherwise.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [network_link_registry Class](../vs140/network_link_registry-class.md)