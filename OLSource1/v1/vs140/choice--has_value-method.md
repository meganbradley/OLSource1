---
title: "choice::has_value Method"
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
  - "agents/concurrency::choice::has_value"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "has_value method"
ms.assetid: 50695001-826a-4a8b-b5b8-86d80370cadc
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# choice::has_value Method
Checks whether this `choice` messaging block has been initialized with a value yet.  
  
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
 [choice Class](../vs140/choice-class.md)