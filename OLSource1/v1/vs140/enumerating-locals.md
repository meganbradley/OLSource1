---
title: "Enumerating Locals"
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
  - "debugging [Debugging SDK], enumerating locals"
  - "expression evaluation, enumerating locals"
ms.assetid: 254a88e7-d3a7-447a-bd0c-8985e73d85cf
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Enumerating Locals
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 When Visual Studio is ready to populate the **Locals** window, it calls [IDebugProperty2::EnumChildren](../vs140/idebugproperty2--enumchildren.md) on the [IDebugProperty2](../vs140/idebugproperty2.md) object returned from [IDebugExpressionEvaluator::GetMethodProperty](../vs140/idebugexpressionevaluator--getmethodproperty.md) (see [Implementing GetMethodProperty](../vs140/implementing-getmethodproperty.md)). <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> returns an [IEnumDebugPropertyInfo2](../vs140/ienumdebugpropertyinfo2.md) object.  
  
 This implementation of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> performs the following tasks:  
  
1.  Ensures this is representing a method.  
  
2.  Uses the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> argument to determine which method to call on the [IDebugMethodField](../vs140/idebugmethodfield.md) object. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> equals:  
  
    1.  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, call [IDebugMethodField::EnumLocals](../vs140/idebugmethodfield--enumlocals.md) to obtain an [IEnumDebugFields](../vs140/ienumdebugfields.md) object.  
  
    2.  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, call [IDebugMethodField::EnumArguments](../vs140/idebugmethodfield--enumarguments.md) to obtain an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
    3.  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, synthesize an enumeration that combines the results from <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. This synthesis is represented by the class <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
3.  Instantiates a class (called <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> in this example) that implements the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> interface and contains the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.  
  
4.  Returns the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> interface from the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.  
  
## Managed Code  
 This example shows an implementation of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> in managed code.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Unmanaged Code  
 This example shows an implementation of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> in unmanaged code.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Sample Implementation of Locals](../vs140/sample-implementation-of-locals.md)   
 [Implementing GetMethodProperty](../vs140/implementing-getmethodproperty.md)   
 [Evaluation Context](../vs140/evaluation-context.md)