---
title: "CDebugReportHook::SetHook"
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
  - "CDebugReportHook::SetHook"
  - "ATL.CDebugReportHook.SetHook"
  - "SetHook"
  - "CDebugReportHook.SetHook"
  - "ATL::CDebugReportHook::SetHook"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetHook method"
ms.assetid: 8a13d625-ba7f-43b3-944d-e9cc9feecaae
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDebugReportHook::SetHook
Call this method to start sending debug reports to the named pipe.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Calls [_CrtSetReportHook2](../vs140/_crtsetreporthook2--_crtsetreporthookw2.md) to have debug reports routed through [CDebugReportHookProc](../vs140/cdebugreporthook--cdebugreporthookproc.md) to the named pipe. This class keeps track of the previous report hook so that it can be restored when [RemoveHook](../vs140/cdebugreporthook--removehook.md) is called.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CDebugReportHook Class](../vs140/cdebugreporthook-class.md)