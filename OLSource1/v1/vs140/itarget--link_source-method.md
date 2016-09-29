---
title: "ITarget::link_source Method"
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
  - "agents/concurrency::ITarget::link_source"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "link_source method"
ms.assetid: 290d6373-a589-4211-a571-3d576b47642d
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ITarget::link_source Method
When overridden in a derived class, links a specified source block to this `ITarget` block.  
  
## Syntax  
  
```  
virtual void link_source(  
   _Inout_ ISource<_Type> * _PSource  
) = 0;  
```  
  
#### Parameters  
 `_PSource`  
 The `ISource` block being linked to this `ITarget` block.  
  
## Remarks  
 This function should not be called directly on an `ITarget` block. Blocks should be connected together using the `link_target` method on `ISource` blocks, which will invoke the `link_source` method on the corresponding target.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ITarget Class](../vs140/itarget-class.md)