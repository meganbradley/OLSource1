---
title: "Context::GetId Method"
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
  - concrt/concurrency::Context::GetId
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetId method
ms.assetid: 0158adbb-35ca-4e86-b756-87684b0cd1f2
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Context::GetId Method
Returns an identifier for the context that is unique within the scheduler to which the context belongs.  
  
## Syntax  
  
```  
virtual unsigned int GetId() const =0;  
```  
  
## Return Value  
 An identifier for the context that is unique within the scheduler to which the context belongs.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [Context Class](../vs140/context-class.md)