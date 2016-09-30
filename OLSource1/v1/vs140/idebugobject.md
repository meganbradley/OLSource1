---
title: "IDebugObject"
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
  - "IDebugObject"
helpviewer_keywords: 
  - "IDebugObject interface"
ms.assetid: 05cd8bf4-c9ee-4b49-b782-2263c33067d6
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugObject
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 This interface represents an object that the binder creates to encapsulate the values of symbols and expressions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Notes for Implementers  
 An expression evaluator implements this interface to represent an object.  
  
## Notes for Callers  
 This interface is the base class for all objects that the expression evaluator uses in parsed expressions. It is returned by a call to the [IDebugBinder::Bind](../vs140/idebugbinder--bind.md) method. [QueryInterface](../vs140/queryinterface.md) obtains the more specialized interfaces from this interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
|Method|Description|  
|------------|-----------------|  
|[GetSize](../vs140/idebugobject--getsize.md)|Gets the size of the object.|  
|[GetValue](../vs140/idebugobject--getvalue.md)|Gets the value of the object as a consecutive series of bytes.|  
|[SetValue](../vs140/idebugobject--setvalue.md)|Sets the value of the object from a consecutive series of bytes.|  
|[SetReferenceValue](../vs140/idebugobject--setreferencevalue.md)|Sets the reference value of this object.|  
|[GetMemoryContext](../vs140/idebugobject--getmemorycontext.md)|Gets the memory context that represents the address of the value of the object.|  
|[GetManagedDebugObject](../vs140/idebugobject--getmanageddebugobject.md)|Creates a copy of the managed object in the address space of the debug engine.|  
|[IsNullReference](../vs140/idebugobject--isnullreference.md)|Tests whether this object is a null reference.|  
|[IsEqual](../vs140/idebugobject--isequal.md)|Compares an object to this one.|  
|[IsReadOnly](../vs140/idebugobject--isreadonly.md)|Determines if this object is read-only.|  
|[IDebugObject::IsProxy](../vs140/idebugobject--isproxy.md)|Determines if the object is a transparent proxy.|  
  
## Remarks  
 The expression evaluator uses this interface as the base class to represent objects in a parse tree.  
  
## Requirements  
 Header: ee.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Expression Evaluation Interfaces](../vs140/expression-evaluation-interfaces.md)   
 [GetElement](../vs140/idebugarrayobject--getelement.md)   
 [Bind](../vs140/idebugbinder--bind.md)