---
title: "single_link_registry::add Method"
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
  - "agents/concurrency::single_link_registry::add"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "add method"
ms.assetid: ccafd9a9-1cf3-4754-b357-6e2ee4d14f40
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# single_link_registry::add Method
Adds a link to the `single_link_registry` object.  
  
## Syntax  
  
```  
virtual void add(  
   _EType _Link  
);  
```  
  
#### Parameters  
 `_Link`  
 A pointer to a block to be added.  
  
## Remarks  
 The method throws an [invalid_link_target](../VS_csharp/invalid_link_target-class.md) exception if there is already a link in this registry.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [single_link_registry Class](../VS_csharp/single_link_registry-class.md)