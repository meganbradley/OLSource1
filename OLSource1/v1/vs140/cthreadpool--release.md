---
title: "CThreadPool::Release"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL::CThreadPool::Release"
  - "CThreadPool.Release"
  - "ATL.CThreadPool.Release"
  - "CThreadPool::Release"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Release method"
ms.assetid: aaae7f19-4ed8-417a-bd8e-07651316430b
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CThreadPool::Release
Implementation of `IUnknown::Release`.  
  
## Syntax  
  
```  
  
ULONG STDMETHODCALLTYPE Release( ) throw( );  
  
```  
  
## Return Value  
 Always returns 1.  
  
## Remarks  
 This class does not implement lifetime control using reference counting.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CThreadPool Class](../vs140/cthreadpool-class.md)   
 [CThreadPool::AddRef](../vs140/cthreadpool--addref.md)