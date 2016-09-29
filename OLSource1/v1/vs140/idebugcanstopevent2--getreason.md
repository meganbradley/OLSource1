---
title: "IDebugCanStopEvent2::GetReason"
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
  - "IDebugCanStopEvent2::GetReason"
helpviewer_keywords: 
  - "IDebugCanStopEvent2::GetReason"
ms.assetid: f5de31ca-7b8d-4029-9cf9-ba860ac66af6
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugCanStopEvent2::GetReason
Gets the reason why the debug engine (DE) wants to stop.  
  
## Syntax  
  
```cpp#  
HRESULT GetReason(   
   CANSTOP_REASON* pcr  
);  
```  
  
```c#  
int GetReason(   
   out enum_CANSTOP_REASON pcr  
);  
```  
  
#### Parameters  
 `pcr`  
 [out] Returns a value from the [CANSTOP_REASON](../vs140/canstop_reason.md) enumeration that describes the reason for this event.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method is typically called before the [IDebugCanStopEvent2::CanStop](../vs140/idebugcanstopevent2--canstop.md) method so the caller can determine whether to pass non-zero (`TRUE`) to the `IDebugCanStopEvent2::CanStop` method.  
  
 The reason for stopping can be either `CANSTOP_ENTRYPOINT`, which means the DE has reached an entry point, or `CANSTOP_STEPIN`, which means the DE has stepped into a function.  
  
## See Also  
 [IDebugCanStopEvent2](../vs140/idebugcanstopevent2.md)   
 [CANSTOP_REASON](../vs140/canstop_reason.md)   
 [IDebugCanStopEvent2::CanStop](../vs140/idebugcanstopevent2--canstop.md)