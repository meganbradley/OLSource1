---
title: "Context::VirtualProcessorId Method"
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
  - concrt/concurrency::Context::VirtualProcessorId
dev_langs: 
  - C++
helpviewer_keywords: 
  - VirtualProcessorId method
ms.assetid: ed3d22e5-6bdf-4bff-9a92-d045f702f4fc
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Context::VirtualProcessorId Method
Returns an identifier for the virtual processor that the current context is executing on.  
  
## Syntax  
  
```  
static unsigned int __cdecl VirtualProcessorId();  
```  
  
## Return Value  
 If the current context is attached to a scheduler, an identifier for the virtual processor that the current context is executing on; otherwise, the value `-1`.  
  
## Remarks  
 The return value from this method is an instantaneous sampling of the virtual processor that the current context is executing on. This value can be stale the moment it is returned and cannot be relied upon. Typically, this method is used for debugging or tracing purposes only.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [Context Class](../vs140/context-class.md)