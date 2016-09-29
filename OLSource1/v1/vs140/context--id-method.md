---
title: "Context::Id Method"
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
  - "concrt/concurrency::Context::Id"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Id method"
ms.assetid: 1860d19c-97f9-49a2-bb70-0783ef479e8f
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Context::Id Method
Returns an identifier for the current context that is unique within the scheduler to which the current context belongs.  
  
## Syntax  
  
```  
static unsigned int __cdecl Id();  
```  
  
## Return Value  
 If the current context is attached to a scheduler, an identifier for the current context that is unique within the scheduler to which the current context belongs; otherwise, the value `-1`.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [Context Class](../vs140/context-class.md)