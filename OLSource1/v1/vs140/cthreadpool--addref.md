---
title: "CThreadPool::AddRef"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CThreadPool.AddRef
  - ATL::CThreadPool::AddRef
  - ATL.CThreadPool.AddRef
  - AddRef
  - CThreadPool::AddRef
dev_langs: 
  - C++
helpviewer_keywords: 
  - AddRef method [ATL Server]
  - AddRef method [C++], object syntax
ms.assetid: b3f164cb-f3c6-4cdd-98c0-195da2011dfb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CThreadPool::AddRef
Implementation of `IUnknown::AddRef`.  
  
## Syntax  
  
```  
  
ULONG STDMETHODCALLTYPE AddRef( ) throw( );  
  
```  
  
## Return Value  
 Always returns 1.  
  
## Remarks  
 This class does not implement lifetime control using reference counting.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CThreadPool Class](../vs140/cthreadpool-class.md)   
 [CThreadPool::Release](../vs140/cthreadpool--release.md)