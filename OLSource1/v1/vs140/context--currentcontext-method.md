---
title: "Context::CurrentContext Method"
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
  - "concrt/concurrency::Context::CurrentContext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CurrentContext method"
ms.assetid: d57bf982-3fcf-48aa-ae01-89885f7dd8f0
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Context::CurrentContext Method
Returns a pointer to the current context.  
  
## Syntax  
  
```  
static Context * __cdecl CurrentContext();  
```  
  
## Return Value  
 A pointer to the current context.  
  
## Remarks  
 This method will result in the process' default scheduler being created and/or attached to the calling context if there is no scheduler currently associated with the calling context.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [Context Class](../vs140/context-class.md)