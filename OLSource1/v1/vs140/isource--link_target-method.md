---
title: "ISource::link_target Method"
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
  - "agents/concurrency::ISource::link_target"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "link_target method"
ms.assetid: fb860692-47a3-45aa-9fe4-cbffc131f839
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ISource::link_target Method
When overridden in a derived class, links a target block to this `ISource` block.  
  
## Syntax  
  
```  
virtual void link_target(  
   _Inout_ ITarget<_Type> * _PTarget  
) = 0;  
```  
  
#### Parameters  
 `_PTarget`  
 A pointer to the target block being linked to this `ISource` block.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ISource Class](../vs140/isource-class.md)