---
title: "Changing the Value of a Local"
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
  - "debugging [Debugging SDK], expression evaluation"
  - "expression evaluation, changing values programmatically"
ms.assetid: 8407d3df-d38a-4328-82d1-98084bef43ec
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Changing the Value of a Local
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 When a new value is typed in the value field of the **Locals** window, the debug package passes the string, as typed, to the expression evaluator (EE). The EE evaluates this string, which can contain either a simple value or an expression, and stores the resulting value in the associated local.  
  
 This is an overview of the process of changing the value of a local:  
  
1.  After the user enters the new value, Visual Studio calls [IDebugProperty2::SetValueAsString](../vs140/idebugproperty2--setvalueasstring.md) on the [IDebugProperty2](../vs140/idebugproperty2.md) object associated with the local.  
  
2.  <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> performs the following tasks:  
  
    1.  Evaluates the string to produce a value.  
  
    2.  Binds the associated [IDebugField](../vs140/idebugfield.md) object to obtain an [IDebugObject](../vs140/idebugobject.md) object.  
  
    3.  Converts the value to a series of bytes.  
  
    4.  Calls [IDebugObject::SetValue](../vs140/idebugobject--setvalue.md) to put the value's bytes into memory so the program being debugged can access them.  
  
3.  Visual Studio refreshes the **Locals** display (see [Displaying Locals](../vs140/displaying-locals.md) for details).  
  
 This procedure is also used to change the value of a variable in the **Watch** window except it is the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object associated with the value of the local that is used instead of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object associated with the local itself.  
  
## In This Section  
 [Sample Implementation of Changing Values](../vs140/sample-implementation-of-changing-values.md)  
 Uses the MyCEE sample to step through the process of changing values.  
  
## See Also  
 [Writing a Common Language Run-time Expression Evaluator](../vs140/writing-a-common-language-runtime-expression-evaluator.md)   
 [Displaying Locals](../vs140/displaying-locals.md)