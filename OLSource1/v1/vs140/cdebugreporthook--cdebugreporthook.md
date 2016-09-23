---
title: "CDebugReportHook::CDebugReportHook"
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
  - ATL.CDebugReportHook.CDebugReportHook
  - ATL::CDebugReportHook::CDebugReportHook
  - CDebugReportHook.CDebugReportHook
  - CDebugReportHook
  - CDebugReportHook::CDebugReportHook
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDebugReportHook class, constructor
ms.assetid: c08bbebc-2254-405e-adbf-2184fdcdeac7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDebugReportHook::CDebugReportHook
Calls [SetPipeName](../vs140/cdebugreporthook--setpipename.md), [SetTimeout](../vs140/cdebugreporthook--settimeout.md), and [SetHook](../vs140/cdebugreporthook--sethook.md).  
  
## Syntax  
  
```  
  
      CDebugReportHook(  
   LPCSTR szMachineName = ".",  
   LPCSTR szPipeName = "AtlsDbgPipe",  
   DWORD dwTimeout = 20000  
) throw();  
```  
  
#### Parameters  
 `szMachineName`  
 The name of the machine to which the debug output should be sent. Defaults to the local machine.  
  
 `szPipeName`  
 The name of the named pipe to which the debug output should be sent.  
  
 `dwTimeout`  
 The time in milliseconds that this class will wait for the named pipe to become available.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CDebugReportHook Class](../vs140/cdebugreporthook-class.md)