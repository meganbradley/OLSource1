---
title: "target_block::register_filter Method"
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
  - "agents/concurrency::target_block::register_filter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "register_filter method"
ms.assetid: b28338a9-d834-48d1-a847-2815c76ea6e9
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# target_block::register_filter Method
Registers a filter method that will be invoked on every message received.  
  
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
 [target_block Class](../vs140/target_block-class.md)