---
title: "DEBUG_REASON"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "DEBUG_REASON"
helpviewer_keywords: 
  - "DEBUG_REASON enumeration"
ms.assetid: ad2ee898-8648-4671-9078-d32873862346
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# DEBUG_REASON
Specifies why the process was launched for debugging.  
  
## Syntax  
  
```cpp#  
enum enum_DEBUG_REASON {  
   DEBUG_REASON_ERROR         = 0,  
   DEBUG_REASON_USER_LAUNCHED = 1,  
   DEBUG_REASON_USER_ATTACHED = 2,  
   DEBUG_REASON_AUTO_ATTACHED = 3,  
   DEBUG_REASON_CAUSALITY     = 4  
};  
typedef DWORD DEBUG_REASON;  
```  
  
```c#  
public enum enum_DEBUG_REASON {  
   DEBUG_REASON_ERROR         = 0,  
   DEBUG_REASON_USER_LAUNCHED = 1,  
   DEBUG_REASON_USER_ATTACHED = 2,  
   DEBUG_REASON_AUTO_ATTACHED = 3,  
   DEBUG_REASON_CAUSALITY     = 4  
};  
```  
  
#### Parameters  
 DEBUG_REASON_ERROR  
 A non-specific error occurred (this is used as a default condition when none of the other reasons fit).  
  
 DEBUG_REASON_USER_LAUNCHED  
 The process was launched at the user's request.  
  
 DEBUG_REASON_USER_ATTACHED  
 The already-running process was attached to by the user.  
  
 DEBUG_REASON_AUTO_ATTACHED  
 The process was automatically attached to when it was launched.  
  
 DEBUG_REASON_CAUSALITY  
 The process was launched due to a *Just-In-Time* (JIT) debugging event.  
  
## Remarks  
 Returned from the [IDebugProcess3::GetDebugReason](../VS_csharp/idebugprocess3--getdebugreason.md) method.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../VS_csharp/enumerations--visual-studio-debugging-.md)   
 [IDebugProcess3::GetDebugReason](../VS_csharp/idebugprocess3--getdebugreason.md)