---
title: "IDebugExpressionEvaluationCompleteEvent2"
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
  - "IDebugExpressionEvaluationCompleteEvent2"
helpviewer_keywords: 
  - "IDebugExpressionEvaluationCompleteEvent2"
ms.assetid: d538fc19-55bf-4231-9595-eb01e84fd1d8
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugExpressionEvaluationCompleteEvent2
This interface is sent by the debug engine (DE) to the session debug manager (SDM) when asynchronous expression evaluation is complete.  
  
## Syntax  
  
```  
IDebugExpressionEvaluationCompleteEvent2 : IUnknown  
```  
  
## Notes for Implementers  
 The DE implements this interface to report completion of an expression evaluation started by a call to [IDebugExpression2::EvaluateAsync](../VS_csharp/idebugexpression2--evaluateasync.md). The [IDebugEvent2](../VS_csharp/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](../VS_csharp/queryinterface.md) to access the `IDebugEvent2` interface.  
  
## Notes for Callers  
 The DE creates and sends this event object to report the completion of an expression evaluation. The event is sent by using the [IDebugEventCallback2](../VS_csharp/idebugeventcallback2.md) callback function that is supplied by the SDM when it attached to the program being debugged.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugExpressionEvaluationCompleteEvent2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetExpression](../VS_csharp/idebugexpressionevaluationcompleteevent2--getexpression.md)|Gets the original expression.|  
|[GetResult](../VS_csharp/idebugexpressionevaluationcompleteevent2--getresult.md)|Gets the result of expression evaluation.|  
  
## Remarks  
 The DE must send this event, whether the evaluation was successful or not.  
  
 If the evaluation was not successful, the `DEBUG_PROPINFO_VALUE` and `DEBUG_PROPINFO_ATTRIB` flags will not be set in the [DEBUG_PROPERTY_INFO](../VS_csharp/debug_property_info.md) structure that is returned by [IDebugProperty2::GetPropertyInfo](../VS_csharp/idebugproperty2--getpropertyinfo.md) (the [IDebugProperty2](../VS_csharp/idebugproperty2.md) object is created by the DE and returned in the `IDebugExpressionEvaluationCompleteEvent2` event if the evaluation failed).  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugEvent2](../VS_csharp/idebugevent2.md)   
 [IDebugEventCallback2](../VS_csharp/idebugeventcallback2.md)   
 [IDebugExpression2::EvaluateAsync](../VS_csharp/idebugexpression2--evaluateasync.md)   
 [IDebugProperty2](../VS_csharp/idebugproperty2.md)