---
title: "Evaluating Locals"
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
  - "debugging [Debugging SDK], evaluating locals"
  - "expression evaluation, evaluating locals"
ms.assetid: 7d1ed528-4e7a-4d8f-87b4-162440644a75
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Evaluating Locals
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 [IDebugProperty2::GetPropertyInfo](../vs140/idebugproperty2--getpropertyinfo.md) is called to obtain the value of a local, as well as the local's name and type. Since the value of a local is dependent on the current state of the program, the local's value must be obtained from memory. The [IDebugBinder](../vs140/idebugbinder.md) object is used to bind the [IDebugField](../vs140/idebugfield.md) object representing the local to the appropriate location in memory containing the value. This location in memory is represented by an [IDebugObject](../vs140/idebugobject.md) object.  
  
 This functionality of retrieving the value of a local is encapsulated in a helper function that performs the following tasks:  
  
1.  Binds the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object to memory to obtain an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
2.  Gets the value from memory. This value is represented as a series of bytes.  
  
3.  Formats the value based on the local's type.  
  
4.  Returns a generic object that contains the local's value. In C#, this is an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and in C++, this is a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Managed Code  
 This is an implementation of a function that retrieves the value of a local in managed code.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Unmanaged Code  
 This is an implementation of a function that retrieves the value of a local in unmanaged code. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is shown in [Getting Local Values](../vs140/getting-local-values.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Sample Implementation of Locals](../vs140/sample-implementation-of-locals.md)   
 [Getting Local Values](../vs140/getting-local-values.md)   
 [Evaluation Context](../vs140/evaluation-context.md)