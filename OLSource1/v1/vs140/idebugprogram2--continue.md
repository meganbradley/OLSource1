---
title: "IDebugProgram2::Continue"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - IDebugProgram2::Continue
helpviewer_keywords: 
  - IDebugProgram2::Continue
ms.assetid: e5a6e02a-d21b-4a03-a034-e8de1f71ce2e
caps.latest.revision: 16
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugProgram2::Continue
Continues running this program from a stopped state. Any previous execution state (such as a step) is preserved, and the program starts executing again.  
  
> [!NOTE]
>  This method is deprecated. Use the [IDebugProcess3::Continue](../vs140/idebugprocess3--continue.md) method instead.  
  
## Syntax  
  
```cpp#  
HRESULT Continue(   
   IDebugThread2* pThread  
);  
```  
  
```c#  
int Continue(   
   IDebugThread2 pThread  
);  
```  
  
#### Parameters  
 `pThread`  
 [in] An [IDebugThread2](../vs140/idebugthread2.md) object that represents the thread.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method is called on this program regardless of how many programs are being debugged, or which program generated the stopping event. The implementation must retain the previous execution state (such as a step) and continue execution as though it had never stopped before completing its prior execution. That is, if a thread in this program was doing a step-over operation and was stopped because some other program stopped, and then this method was called, the program must complete the original step-over operation.  
  
> [!WARNING]
>  Do not send a stopping event or an immediate (synchronous) event to [IDebugEventCallback2::Event](../vs140/idebugeventcallback2--event.md) while handling this call; otherwise the debugger may hang.  
  
## See Also  
 [IDebugEngineProgram2](../vs140/idebugengineprogram2.md)   
 [IDebugEventCallback2::Event](../vs140/idebugeventcallback2--event.md)