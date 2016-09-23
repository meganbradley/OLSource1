---
title: "Displaying Locals"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - debugging [Debugging SDK], expression evaluation
  - expression evaluation, displaying locals
ms.assetid: 62264cec-845b-4233-aed7-0b038fa79250
caps.latest.revision: 15
translation.priority.mt: 
  - de-de
  - ja-jp
---
# Displaying Locals
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 Execution always takes place within the context of a method, also known as the containing method or current method. When execution pauses, Visual Studio calls the debug engine (DE) to get a list of local variables and arguments, collectively called the locals of the method. Visual Studio displays these locals and their values in the **Locals** window.  
  
 To display locals, the DE calls the [GetMethodProperty](../vs140/idebugexpressionevaluator--getmethodproperty.md) method belonging to the EE and gives it an evaluation context, that is, a symbol provider (SP), the current execution address, and a binder object. For more information, see [Evaluation Context](../vs140/evaluation-context.md). If the call succeeds, the `IDebugExpressionEvaluator::GetMethodProperty` method returns an [IDebugProperty2](../vs140/idebugproperty2.md) object, which represents the method that contains the current execution address.  
  
 The DE calls [EnumChildren](../vs140/idebugproperty2--enumchildren.md) to get an [IEnumDebugPropertyInfo2](../vs140/ienumdebugpropertyinfo2.md) object, which is filtered to return only locals and enumerated to produce a list of [DEBUG_PROPERTY_INFO](../vs140/debug_property_info.md) structures. Each structure contains the name, type, and value of a local. The type and value are stored as formatted strings, suitable for display. The name, type, and value are typically displayed together in one line of the **Locals** window.  
  
> [!NOTE]
>  The **QuickWatch** and **Watch** windows also display variables with the same format of name, value, and type. However, those values are obtained by calling [IDebugProperty2::GetPropertyInfo](../vs140/idebugproperty2--getpropertyinfo.md) instead of `IDebugProperty2::EnumChildren`.  
  
## In This Section  
 [Sample Implementation of Locals](../vs140/sample-implementation-of-locals.md)  
 Uses examples to step through the process of implementing locals.  
  
## Related Sections  
 [Evaluation Context](../vs140/evaluation-context.md)  
 Explains that when the debug engine (DE) calls the expression evaluator (EE), it passes three arguments.  
  
## See Also  
 [Writing a Common Language Run-time Expression Evaluator](../vs140/writing-a-common-language-runtime-expression-evaluator.md)