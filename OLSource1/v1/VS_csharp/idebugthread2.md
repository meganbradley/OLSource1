---
title: "IDebugThread2"
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
  - "IDebugThread2"
helpviewer_keywords: 
  - "IDebugThread2 interface"
ms.assetid: 221b4b1b-4a26-466e-bc29-5eff800fab13
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugThread2
This interface represents a thread running in a program.  
  
## Syntax  
  
```  
IDebugThread2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface to represent a thread of execution in a single program.  
  
## Notes for Callers  
 Call [IDebugStackFrame2::GetThread](../VS_csharp/idebugstackframe2--getthread.md) to obtain this interface representing the currently active thread.  
  
 This interface is also used in creating a breakpoint request (see [BP_REQUEST_INFO](../VS_csharp/bp_request_info.md)).  
  
 This interface is also returned when resolving a bound or error breakpoint (see [BP_RESOLUTION_INFO](../VS_csharp/bp_resolution_info.md) and [BP_ERROR_RESOLUTION_INFO](../VS_csharp/bp_error_resolution_info.md)).  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugThread2`.  
  
|Method|Description|  
|------------|-----------------|  
|[EnumFrameInfo](../VS_csharp/idebugthread2--enumframeinfo.md)|Retrieves a list of the stack frames for this thread.|  
|[GetName](../VS_csharp/idebugthread2--getname.md)|Gets the name of the thread.|  
|[SetThreadName](../VS_csharp/idebugthread2--setthreadname.md)|Sets the name of the thread.|  
|[GetProgram](../VS_csharp/idebugthread2--getprogram.md)|Gets the program in which a thread is running.|  
|[CanSetNextStatement](../VS_csharp/idebugthread2--cansetnextstatement.md)|Determines whether the next statement can be set to the given stack frame and code context.|  
|[SetNextStatement](../VS_csharp/idebugthread2--setnextstatement.md)|Sets the next statement to the given stack frame and code context.|  
|[GetThreadId](../VS_csharp/idebugthread2--getthreadid.md)|Gets the system thread identifier.|  
|[Suspend](../VS_csharp/idebugthread2--suspend.md)|Suspends a thread.|  
|[Resume](../VS_csharp/idebugthread2--resume.md)|Resumes a thread.|  
|[GetThreadProperties](../VS_csharp/idebugthread2--getthreadproperties.md)|Gets properties that describe a thread.|  
|[GetLogicalThread](../VS_csharp/idebugthread2--getlogicalthread.md)|Gets the logical thread associated with this physical thread.|  
  
## Remarks  
 Because a single physical thread can run in multiple programs, more than one `IDebugThread2` from more than one program can represent the same physical thread.  
  
 When a breakpoint or exception occurs, an event is sent by calling [IDebugEventCallback2::Event](../VS_csharp/idebugeventcallback2--event.md). One of the arguments to this method is an `IDebugThread2` interface representing the current thread. [IDebugThread2::EnumFrameInfo](../VS_csharp/idebugthread2--enumframeinfo.md) is used to obtain the [IDebugStackFrame2](../VS_csharp/idebugstackframe2.md) interface for the current stack frame.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../VS_csharp/core-interfaces.md)   
 [Event](../VS_csharp/idebugeventcallback2--event.md)   
 [GetThread](../VS_csharp/idebugstackframe2--getthread.md)   
 [BP_REQUEST_INFO](../VS_csharp/bp_request_info.md)   
 [BP_RESOLUTION_INFO](../VS_csharp/bp_resolution_info.md)   
 [BP_ERROR_RESOLUTION_INFO](../VS_csharp/bp_error_resolution_info.md)