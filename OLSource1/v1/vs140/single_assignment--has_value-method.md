---
title: "single_assignment::has_value Method"
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
  - "agents/concurrency::single_assignment::has_value"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "has_value method"
ms.assetid: 6b50c2be-58d4-4717-870e-6925be91319b
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# single_assignment::has_value Method
Checks whether this `single_assignment` messaging block has been initialized with a value yet.  
  
## Syntax  
  
```  
bool has_value() const;  
```  
  
## Return Value  
 `true` if the block has received a value, `false` otherwise.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [single_assignment Class](../vs140/single_assignment-class.md)