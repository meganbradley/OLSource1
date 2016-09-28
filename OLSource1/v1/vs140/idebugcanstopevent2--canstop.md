---
title: "IDebugCanStopEvent2::CanStop"
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
  - "IDebugCanStopEvent2::CanStop"
helpviewer_keywords: 
  - "IDebugCanStopEvent2::CanStop"
ms.assetid: 7d61adbe-6b3d-41f3-86a1-45d9cc01a7f8
caps.latest.revision: 14
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugCanStopEvent2::CanStop
Notifies the debug engine (DE) whether or not to stop at the current code location or just continue execution.  
  
## Syntax  
  
```cpp#  
HRESULT CanStop (   
   BOOL fCanStop  
);  
```  
  
```c#  
int CanStop (   
   int fCanStop  
);  
```  
  
#### Parameters  
 `fCanStop`  
 [in] Non-zero (`TRUE`) if the DE should stop at the current code location; otherwise, zero (`FALSE`).  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The receiver of this event typically calls the [IDebugCanStopEvent2::GetReason](../vs140/idebugcanstopevent2--getreason.md) method to determine the reason the DE wants to stop, and then calls the `IDebugCanStopEvent2::CanStop` method with the appropriate response.  
  
 If the DE stops, it sends an event that describes the reason for stopping. There are typically two events that are sent, a user or signal break represented by the [IDebugBreakEvent2](../vs140/idebugbreakevent2.md) interface, and a breakpoint event represented by the [IDebugBreakpointEvent2](../vs140/idebugbreakpointevent2.md) interface.  
  
## See Also  
 [IDebugCanStopEvent2](../vs140/idebugcanstopevent2.md)   
 [IDebugBreakEvent2](../vs140/idebugbreakevent2.md)   
 [IDebugBreakpointEvent2](../vs140/idebugbreakpointevent2.md)   
 [IDebugCanStopEvent2::GetReason](../vs140/idebugcanstopevent2--getreason.md)