---
title: "DispatchState::m_fIsPreviousContextAsynchronouslyBlocked Data Member"
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
  - "concrtrm/concurrency::DispatchState::m_fIsPreviousContextAsynchronouslyBlocked"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_fIsPreviousContextAsynchronouslyBlocked data member"
ms.assetid: 386ec117-c630-4278-ba30-be4b39e13a79
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DispatchState::m_fIsPreviousContextAsynchronouslyBlocked Data Member
Tells whether this context has entered the `Dispatch` method because the previous context asynchronously blocked. This is used only on the UMS scheduling context, and is set to the value `0` for all other execution contexts.  
  
## Syntax  
  
```  
unsigned int m_fIsPreviousContextAsynchronouslyBlocked : 1;  
```  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [DispatchState Structure](../VS_csharp/dispatchstate-structure.md)   
 [IExecutionContext::Dispatch Method](../VS_csharp/iexecutioncontext--dispatch-method.md)