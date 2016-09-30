---
title: "Sample Implementation of Changing Values"
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
  - "expression evaluation, local values"
  - "debugging [Debugging SDK], expression evaluation"
ms.assetid: ee2d955b-12ca-4f27-89aa-c2d0e768b6b6
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Sample Implementation of Changing Values
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 Every local displayed in the **Locals** window has an [IDebugProperty2](../vs140/idebugproperty2.md) object associated with it. This <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object contains the local's name, value, and type. When a user changes the value of a local, Visual Studio calls [IDebugProperty2::SetValueAsString](../vs140/idebugproperty2--setvalueasstring.md) to update the value of the local in memory. In this example, the local is represented by the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class that implements the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> interface.  
  
> [!NOTE]
>  For **Watch** and **QuickWatch** expressions, the value being changed is represented by the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class in the MyCEE sample. However, the implementation of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is the same as shown here.  
  
 This implementation of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> performs the following tasks:  
  
1.  Evaluates the expression to produce a value.  
  
2.  Binds the associated [IDebugField](../vs140/idebugfield.md) object to its memory location and produce an [IDebugObject](../vs140/idebugobject.md) object.  
  
3.  Converts the value to a series of bytes.  
  
4.  Calls [IDebugObject::SetValue](../vs140/idebugobject--setvalue.md) to store the bytes in memory.  
  
## Managed Code  
 This is an implementation of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in managed code.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Unmanaged Code  
 This is an implementation of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in managed code. The helper function <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> (not shown) forces a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to be a specific type and makes sure the value is one of the types <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> can handle.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Changing the Value of a Local](../vs140/changing-the-value-of-a-local.md)   
 [Evaluation Context](../vs140/evaluation-context.md)