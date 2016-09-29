---
title: "CDebugReportHook::RemoveHook"
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
  - "CDebugReportHook.RemoveHook"
  - "CDebugReportHook::RemoveHook"
  - "ATL.CDebugReportHook.RemoveHook"
  - "RemoveHook"
  - "ATL::CDebugReportHook::RemoveHook"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveHook method"
ms.assetid: 0cff2557-f154-4525-b87d-8a61bcf7bd74
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDebugReportHook::RemoveHook
Call this method to stop sending debug reports to the named pipe and restore the previous report hook.  
  
## Syntax  
  
```  
  
void RemoveHook( ) throw( );  
  
```  
  
## Remarks  
 Calls [_CrtSetReportHook2](../vs140/_crtsetreporthook2--_crtsetreporthookw2.md) to restore the previous report hook.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CDebugReportHook Class](../vs140/cdebugreporthook-class.md)   
 [CDebugReportHook::SetHook](../vs140/cdebugreporthook--sethook.md)