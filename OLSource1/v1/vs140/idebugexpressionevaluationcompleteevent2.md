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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Notes for Implementers  
 The DE implements this interface to report completion of an expression evaluation started by a call to [IDebugExpression2::EvaluateAsync](../vs140/idebugexpression2--evaluateasync.md). The [IDebugEvent2](../vs140/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](../vs140/queryinterface.md) to access the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface.  
  
## Notes for Callers  
 The DE creates and sends this event object to report the completion of an expression evaluation. The event is sent by using the [IDebugEventCallback2](../vs140/idebugeventcallback2.md) callback function that is supplied by the SDM when it attached to the program being debugged.  
  
## Methods in Vtable Order  
 The following table shows the methods of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
|Method|Description|  
|------------|-----------------|  
|[GetExpression](../vs140/idebugexpressionevaluationcompleteevent2--getexpression.md)|Gets the original expression.|  
|[GetResult](../vs140/idebugexpressionevaluationcompleteevent2--getresult.md)|Gets the result of expression evaluation.|  
  
## Remarks  
 The DE must send this event, whether the evaluation was successful or not.  
  
 If the evaluation was not successful, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> flags will not be set in the [DEBUG_PROPERTY_INFO](../vs140/debug_property_info.md) structure that is returned by [IDebugProperty2::GetPropertyInfo](../vs140/idebugproperty2--getpropertyinfo.md) (the [IDebugProperty2](../vs140/idebugproperty2.md) object is created by the DE and returned in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> event if the evaluation failed).  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugEvent2](../vs140/idebugevent2.md)   
 [IDebugEventCallback2](../vs140/idebugeventcallback2.md)   
 [IDebugExpression2::EvaluateAsync](../vs140/idebugexpression2--evaluateasync.md)   
 [IDebugProperty2](../vs140/idebugproperty2.md)