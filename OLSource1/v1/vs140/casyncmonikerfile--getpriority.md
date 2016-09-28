---
title: "CAsyncMonikerFile::GetPriority"
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
  - "CAsyncMonikerFile.GetPriority"
  - "GetPriority"
  - "CAsyncMonikerFile::GetPriority"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPriority method"
ms.assetid: 06b27912-53da-45e5-94a1-fe5f98eff1cf
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncMonikerFile::GetPriority
Called from the client of an asynchronous moniker as the binding process starts to receive the priority given to the thread for the binding operation.  
  
## Syntax  
  
```  
  
virtual LONG GetPriority( ) const;  
  
```  
  
## Return Value  
 The priority at which the asynchronous transfer will take place. One of the standard thread priority flags: **THREAD_PRIORITY_ABOVE_NORMAL**, **THREAD_PRIORITY_BELOW_NORMAL**, **THREAD_PRIORITY_HIGHEST**, **THREAD_PRIORITY_IDLE**, **THREAD_PRIORITY_LOWEST**, **THREAD_PRIORITY_NORMAL**, and **THREAD_PRIORITY_TIME_CRITICAL**. See the Windows function [SetThreadPriority](http://msdn.microsoft.com/library/windows/desktop/ms686277) for a description of these values.  
  
## Remarks  
 `GetPriority` should not be called directly. **THREAD_PRIORITY_NORMAL** is returned by the default implementation.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [CAsyncMonikerFile Class](../vs140/casyncmonikerfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)