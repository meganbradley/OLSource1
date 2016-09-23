---
title: "CDebugReportHook::SetTimeout"
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
  - CDebugReportHook.SetTimeout
  - ATL::CDebugReportHook::SetTimeout
  - CDebugReportHook::SetTimeout
  - SetTimeout
  - ATL.CDebugReportHook.SetTimeout
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetTimeout method
ms.assetid: c787e1e1-0479-4f12-b54f-578a10585b9f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDebugReportHook::SetTimeout
Call this method to set the time in milliseconds that this class will wait for the named pipe to become available.  
  
## Syntax  
  
```  
  
      void SetTimeout(  
   DWORD dwTimeout   
);  
```  
  
#### Parameters  
 `dwTimeout`  
 The time in milliseconds that this class will wait for the named pipe to become available.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CDebugReportHook Class](../vs140/cdebugreporthook-class.md)