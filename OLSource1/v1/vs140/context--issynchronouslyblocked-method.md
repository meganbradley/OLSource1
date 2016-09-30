---
title: "Context::IsSynchronouslyBlocked Method"
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
  - "concrt/concurrency::Context::IsSynchronouslyBlocked"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsSynchronouslyBlocked method"
ms.assetid: c2b6336e-0e36-40be-a03e-1806eafe470a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Context::IsSynchronouslyBlocked Method
Determines whether or not the context is synchronously blocked. A context is considered to be synchronously blocked if it explicitly performed an action which led to blocking.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Whether the context is synchronously blocked.  
  
## Remarks  
 A context is considered to be synchronously blocked if it explicitly performed an action which led to blocking. On the thread scheduler, this would indicate a direct call to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method or a synchronization object which was built using the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method.  
  
 The return value from this method is an instantaneous sample of whether the context is synchronously blocked. This value may be stale the moment it is returned and can only be used under very specific circumstances.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [Context Class](../vs140/context-class.md)   
 [Context::Block Method](../vs140/context--block-method.md)