---
title: "Sample Implementation of Locals"
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
  - "debugging [Debugging SDK], local variables"
  - "expression evaluation, local variables"
ms.assetid: 66a2e00a-f558-4e87-96b8-5ecf5509e04c
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Sample Implementation of Locals
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 Here is an overview of how Visual Studio obtains the locals for a method from the expression evaluator (EE):  
  
1.  Visual Studio calls the debug engine's (DE) [IDebugStackFrame2::GetDebugProperty](../vs140/idebugstackframe2--getdebugproperty.md) to get an [IDebugProperty2](../vs140/idebugproperty2.md) object that represents all the properties of the stack frame, including the locals.  
  
2.  <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> calls [IDebugExpressionEvaluator::GetMethodProperty](../vs140/idebugexpressionevaluator--getmethodproperty.md) to obtain an object that describes the method within which the breakpoint occurred. The DE supplies a symbol provider ([IDebugSymbolProvider](../vs140/idebugsymbolprovider.md)), an address ([IDebugAddress](../vs140/idebugaddress.md)), and a binder ([IDebugBinder](../vs140/idebugbinder.md)).  
  
3.  <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> calls [IDebugSymbolProvider::GetContainerField](../vs140/idebugsymbolprovider--getcontainerfield.md) with the supplied <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object to get an [IDebugContainerField](../vs140/idebugcontainerfield.md) representing the method containing the specified address.  
  
4.  The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> interface is queried for the [IDebugMethodField](../vs140/idebugmethodfield.md) interface. It is this interface that gives access to the method's locals.  
  
5.  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> instantiates a class (called <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in the sample) that implements the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> interface to represent the method's locals. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object is placed in this <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object along with the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> objects.  
  
6.  When the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object is initialized, [IDebugField::GetInfo](../vs140/idebugfield--getinfo.md) is called on the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object to obtain a [FIELD_INFO](../vs140/field_info.md) structure that contains all displayable information about the method itself.  
  
7.  <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> returns the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object as an <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.  
  
8.  Visual Studio calls [IDebugProperty2::EnumChildren](../vs140/idebugproperty2--enumchildren.md) on the returned <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object with the filter <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. This returns an [IEnumDebugPropertyInfo2](../vs140/ienumdebugpropertyinfo2.md) object containing the method's locals. This enumeration is filled in by calls to [IDebugMethodField::EnumLocals](../vs140/idebugmethodfield--enumlocals.md) and [IDebugMethodField::EnumArguments](../vs140/idebugmethodfield--enumarguments.md).  
  
9. Visual Studio calls [IEnumDebugPropertyInfo2::Next](../vs140/ienumdebugpropertyinfo2--next.md) to obtain a [DEBUG_PROPERTY_INFO](../vs140/debug_property_info.md) structure for each local. This structure contains a pointer to an <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> interface for a local.  
  
10. Visual Studio calls [IDebugProperty2::GetPropertyInfo](../vs140/idebugproperty2--getpropertyinfo.md) for each local to obtain the local's name, value, and type. This is the information that is displayed in the **Locals** window.  
  
## In This Section  
 [Implementing GetMethodProperty](../vs140/implementing-getmethodproperty.md)  
 Describes an implementation of [IDebugExpressionEvaluator::GetMethodProperty](../vs140/idebugexpressionevaluator--getmethodproperty.md).  
  
 [Enumerating Locals](../vs140/enumerating-locals.md)  
 Describes how the debug engine (DE) makes a call to enumerate local variables or arguments.  
  
 [Getting Local Properties](../vs140/getting-local-properties.md)  
 Describes how the DE makes a call to get the name, type, and value of one or more locals.  
  
 [Getting Local Values](../vs140/getting-local-values.md)  
 Discusses obtaining the value of the local, which requires the services of a binder object given by the evaluation context.  
  
 [Evaluating Locals](../vs140/evaluating-locals.md)  
 Explains how locals are evaluated.  
  
## Related Sections  
 [Evaluation Context](../vs140/evaluation-context.md)  
 Provides the arguments that are passed when the DE calls the expression evaluator (EE).  
  
 [MyCEE Sample](assetId:///624a018b-9179-402f-9d48-3aec87b48f4f)  
 Demonstrates one implementation approach to creating an expression evaluator for the MyC language.  
  
## See Also  
 [Displaying Locals](../vs140/displaying-locals.md)