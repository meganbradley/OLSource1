---
title: "CDebugReportHook::CDebugReportHookProc"
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
  - "CDebugReportHook.CDebugReportHookProc"
  - "CDebugReportHook::CDebugReportHookProc"
  - "CDebugReportHookProc"
  - "ATL::CDebugReportHook::CDebugReportHookProc"
  - "ATL.CDebugReportHook.CDebugReportHookProc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDebugReportHookProc function"
ms.assetid: d0b34a97-8d00-458b-a975-ed20c45a7a46
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDebugReportHook::CDebugReportHookProc
The custom reporting function that is hooked into the C run-time debug reporting process.  
  
## Syntax  
  
```  
  
      static int __cdecl CDebugReportHookProc(  
   int reportType,  
   char* message,  
   int* returnValue   
) throw( );  
```  
  
#### Parameters  
 `reportType`  
 The type of the report (_CRT_WARN, _CRT_ERROR, or _CRT_ASSERT).  
  
 `message`  
 The message string.  
  
 *returnValue*  
 The value that should be returned by [_CrtDbgReport](../vs140/_crtdbgreport--_crtdbgreportw.md).  
  
## Return Value  
 Returns FALSE if the hook handles the message in question completely so that no further reporting is required. Returns TRUE if `_CrtDbgReport` should report the message in the normal way.  
  
## Remarks  
 The reporting function attempts to open the named pipe and communicate with the process at the other end. If the pipe is busy, the reporting function will wait until the pipe is free or the timeout expires. The timeout can be set by the constructor or a call to [CDebugReportHook::SetTimeout](../vs140/cdebugreporthook--settimeout.md).  
  
 The code in this function is executed in the underlying security context of the calling thread, that is, impersonation is disabled for the duration of this function.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CDebugReportHook Class](../vs140/cdebugreporthook-class.md)   
 [_CrtDbgReport, _CrtDbgReportW](../vs140/_crtdbgreport--_crtdbgreportw.md)