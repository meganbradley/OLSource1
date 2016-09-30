---
title: "Expression Evaluator Implementation Strategy"
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
  - "expression evaluation, implementation strategy"
  - "debug engines, implementation strategies"
ms.assetid: 1bccaeb3-8109-4128-ae79-16fd8fbbaaa2
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Expression Evaluator Implementation Strategy
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 One approach to rapidly creating an expression evaluator (EE) is to first implement the minimum code necessary to display local variables in the **Locals** window. It is useful to realize that each line in the **Locals** window displays the name, type, and value of a local variable, and that all three are represented by an [IDebugProperty2](../vs140/idebugproperty2.md) object. The name, type, and value of a local variable can be obtained from an <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> object by calling its [GetPropertyInfo](../vs140/idebugproperty2--getpropertyinfo.md) method. For more information about how to display local variables in the **Locals** window, see [Displaying Locals](../vs140/displaying-locals.md).  
  
## Discussion  
 A possible implementation sequence starts with implementing [IDebugExpressionEvaluator](../vs140/idebugexpressionevaluator.md). The [IDebugExpressionEvaluator::Parse](../vs140/idebugexpressionevaluator--parse.md) and the [GetMethodProperty](../vs140/idebugexpressionevaluator--getmethodproperty.md) methods need to be implemented to display locals. Calling <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> returns an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object that represents a method: that is, an [IDebugMethodField](../vs140/idebugmethodfield.md) object. Methods themselves are not displayed in the **Locals** window.  
  
 The [EnumChildren](../vs140/idebugproperty2--enumchildren.md) method should be implemented next. The debug engine (DE) calls this method to get a list of local variables and arguments by passing <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> argument of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> calls [IDebugMethodField::EnumArguments](../vs140/idebugmethodfield--enumarguments.md) and [IDebugMethodField::EnumLocals](../vs140/idebugmethodfield--enumlocals.md), combining the results in a single enumeration. See [Displaying Locals](../vs140/displaying-locals.md) for more details.  
  
## See Also  
 [Implementing an Expression Evaluator](../vs140/implementing-an-expression-evaluator.md)   
 [Displaying Locals](../vs140/displaying-locals.md)