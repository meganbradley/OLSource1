---
title: "Control Events"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "debugging [Debugging SDK], events"
ms.assetid: 0fc63484-5fb6-4887-9ea4-1905b459ca9d
caps.latest.revision: 11
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Control Events
You must send events during the controlled execution of your program. All of the events are sent using the [IDebugEvent2](../VS_csharp/idebugevent2.md) interface and have attributes that require you to implement the [IDebugEvent2::GetAttributes](../VS_csharp/idebugevent2--getattributes.md) method.  
  
## Additional Methods  
 Some events require implementation of additional methods, as follows:  
  
-   Sending the [IDebugEngineCreateEvent2](../VS_csharp/idebugenginecreateevent2.md) interface when the debug engine (DE) is initialized requires you to implement the [IDebugEngineCreateEvent2::GetEngine](../VS_csharp/idebugenginecreateevent2--getengine.md) method.  
  
-   Execution control requires implementation of such control events as the [IDebugBreakEvent2](../VS_csharp/idebugbreakevent2.md) and[IDebugStepCompleteEvent2](../VS_csharp/idebugstepcompleteevent2.md) interfaces. **IDebugBreakEvent2** is required only for asynchronous breaks.  
  
-   Stepping into functions requires implementation of the [IDebugStepCompleteEvent2](../VS_csharp/idebugstepcompleteevent2.md) interface and its methods.  
  
 Events deriving from breakpoints require implementation of the [IDebugBreakpointErrorEvent2](../VS_csharp/idebugbreakpointerrorevent2.md), [IDebugBreakpointEvent2](../VS_csharp/idebugbreakpointevent2.md), and [IDebugBreakpointBoundEvent2](../VS_csharp/idebugbreakpointboundevent2.md) interfaces, as well as the [IDebugBreakpointBoundEvent2::GetPendingBreakpoint](../VS_csharp/idebugbreakpointboundevent2--getpendingbreakpoint.md) and [EnumBoundBreakpoints](../VS_csharp/idebugbreakpointboundevent2--enumboundbreakpoints.md) methods.  
  
 Asynchronous expression evaluation requires you to implement the [IDebugExpressionEvaluationCompleteEvent2](../VS_csharp/idebugexpressionevaluationcompleteevent2.md) interface and its [IDebugExpressionEvaluationCompleteEvent2::GetExpression](../VS_csharp/idebugexpressionevaluationcompleteevent2--getexpression.md)[and GetResult](../VS_csharp/idebugexpressionevaluationcompleteevent2--getresult.md) methods.  
  
 Synchronous events require implementing the [IDebugEngine2::ContinueFromSynchronousEvent](../VS_csharp/idebugengine2--continuefromsynchronousevent.md) method.  
  
 For your engine to write string-style output, you must implement the [IDebugOutputStringEvent2::GetString](../VS_csharp/idebugoutputstringevent2--getstring.md) method.  
  
## See Also  
 [Execution Control and State Evaluation](../VS_csharp/execution-control-and-state-evaluation.md)