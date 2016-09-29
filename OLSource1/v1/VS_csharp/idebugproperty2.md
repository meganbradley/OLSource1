---
title: "IDebugProperty2"
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
  - "IDebugProperty2"
helpviewer_keywords: 
  - "IDebugProperty2 interface"
ms.assetid: a7d5c70f-a1a5-4120-9f70-184e01c25bff
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProperty2
This interface represents a stack frame property, a program document property, or some other property. The property is usually the result of an expression evaluation.  
  
> [!NOTE]
>  This use of "property" should not be confused with that meaning a member variable of a class, although an `IDebugProperty2` can represent such an entity.  
  
## Syntax  
  
```  
IDebugProperty2 : IUnknown  
```  
  
## Notes for Implementers  
 The DE implements this interface to represent a particular kind of value. For example, the value could be a numerical value as a result of an expression evaluation, a memory context used for displaying memory, or a list of registers and their values.  
  
## Notes for Callers  
 Call [IDebugExpression2::EvaluateSync](../VS_csharp/idebugexpression2--evaluatesync.md) or [IDebugExpression2::EvaluateAsync](../VS_csharp/idebugexpression2--evaluateasync.md) to obtain this interface, which represents the result of an evaluation. `IDebugExpression2::EvaluateAsync` returns this interface by sending an [IDebugExpressionEvaluationCompleteEvent2](../VS_csharp/idebugexpressionevaluationcompleteevent2.md) interface to the SDM, which in turn calls [IDebugExpressionEvaluationCompleteEvent2::GetResult](../VS_csharp/idebugexpressionevaluationcompleteevent2--getresult.md) to retrieve the property.  
  
 [IDebugPropertyCreateEvent2::GetDebugProperty](../VS_csharp/idebugpropertycreateevent2--getdebugproperty.md) returns this interface to provide the associated script document.  
  
 [IDebugReturnValueEvent2::GetReturnValue](../VS_csharp/idebugreturnvalueevent2--getreturnvalue.md) returns this interface to represent the return value of a function.  
  
 [IDebugProgram2::GetDebugProperty](../VS_csharp/idebugprogram2--getdebugproperty.md) returns this interface to represent various properties of the program such as a name or a memory context.  
  
 [IDebugStackFrame2::GetDebugProperty](../VS_csharp/idebugstackframe2--getdebugproperty.md) returns this interface to represent various properties of the stack frame such as local variables.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugProperty2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetPropertyInfo](../VS_csharp/idebugproperty2--getpropertyinfo.md)|Fills in a [DEBUG_PROPERTY_INFO](../VS_csharp/debug_property_info.md) structure that describes a property.|  
|[SetValueAsString](../VS_csharp/idebugproperty2--setvalueasstring.md)|Sets the value of a property from a string.|  
|[IDebugProperty2::SetValueAsReference](../VS_csharp/idebugproperty2--setvalueasreference.md)|Sets the value of the property from the value of a given reference.|  
|[EnumChildren](../VS_csharp/idebugproperty2--enumchildren.md)|Enumerates the children of a property.|  
|[GetParent](../VS_csharp/idebugproperty2--getparent.md)|Returns the parent of a property.|  
|[GetDerivedMostProperty](../VS_csharp/idebugproperty2--getderivedmostproperty.md)|Returns the property that describes the most-derived property of a property.|  
|[GetMemoryBytes](../VS_csharp/idebugproperty2--getmemorybytes.md)|Returns the memory bytes that compose the value of a property.|  
|[GetMemoryContext](../VS_csharp/idebugproperty2--getmemorycontext.md)|Returns the memory context for a property value.|  
|[GetSize](../VS_csharp/idebugproperty2--getsize.md)|Returns the size, in bytes, of the property value.|  
|[IDebugProperty2::GetReference](../VS_csharp/idebugproperty2--getreference.md)|Returns a reference to this property's value.|  
|[GetExtendedInfo](../VS_csharp/idebugproperty2--getextendedinfo.md)|Returns the extended information of a property.|  
  
## Remarks  
 A property, as represented by an `IDebugProperty2` interface, can be thought of as a value with a name, a type, and an address. In more general terms, an `IDebugProperty2` can represent anything that has a hierarchical structure, with parents and child nodes.  
  
 A property is usually transitory, lasting only as long as the current stack frame, for example. On the other hand, a reference, as represented by an [IDebugReference2](../VS_csharp/idebugreference2.md) interface, lasts as long as the value remains in memory.  
  
 The IDE can use the `IDebugProperty2` interface to let users browse and modify properties at run time.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../VS_csharp/core-interfaces.md)   
 [DEBUG_PROPERTY_INFO](../VS_csharp/debug_property_info.md)   
 [IDebugReference2](../VS_csharp/idebugreference2.md)