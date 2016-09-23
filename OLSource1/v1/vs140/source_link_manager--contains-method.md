---
title: "source_link_manager::contains Method"
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
  - agents/concurrency::source_link_manager::contains
dev_langs: 
  - C++
helpviewer_keywords: 
  - contains method
ms.assetid: fe5ddfe9-69dc-4443-b27c-b245be8391f0
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# source_link_manager::contains Method
Searches the `network_link_registry` within this `source_link_manager` object for a specified block.  
  
## Syntax  
  
```  
bool contains(  
   _EType _Link  
);  
```  
  
#### Parameters  
 `_Link`  
 A pointer to a block that is to be searched for in the `source_link_manager` object.  
  
## Return Value  
 `true` if the specified block was found, `false` otherwise.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [source_link_manager Class](../vs140/source_link_manager-class.md)