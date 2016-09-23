---
title: "propagator_block::register_filter Method"
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
  - agents/concurrency::propagator_block::register_filter
dev_langs: 
  - C++
helpviewer_keywords: 
  - register_filter method
ms.assetid: 2db61f4a-7504-430d-97f9-2bda130b0c2f
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# propagator_block::register_filter Method
Registers a filter method that will be invoked on every received message.  
  
## Syntax  
  
```  
void register_filter(  
   filter_method const& _Filter  
);  
```  
  
#### Parameters  
 `_Filter`  
 The filter method.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [propagator_block Class](../vs140/propagator_block-class.md)