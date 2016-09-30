---
title: "Implementing GetMethodProperty"
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
  - "GetMethodProperty method"
  - "IDebugExpressionEvaluator2 property"
ms.assetid: 6305874f-a2c4-4432-834c-07530ea84bff
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Implementing GetMethodProperty
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 Visual Studio calls the debug engine's (DE) [IDebugStackFrame2::GetDebugProperty](../vs140/idebugstackframe2--getdebugproperty.md), which in turn calls [IDebugExpressionEvaluator::GetMethodProperty](../vs140/idebugexpressionevaluator--getmethodproperty.md) to obtain information about the current method on the stack frame.  
  
 This implementation of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> performs the following tasks:  
  
1.  Calls [IDebugSymbolProvider::GetContainerField](../vs140/idebugsymbolprovider--getcontainerfield.md), passing in the [IDebugAddress](../vs140/idebugaddress.md) object. The symbol provider (SP) returns an [IDebugContainerField](../vs140/idebugcontainerfield.md) representing the method that contains the specified address.  
  
2.  Obtains the [IDebugMethodField](../vs140/idebugmethodfield.md) from the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
3.  Instantiates a class (called <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in this example) that implements the [IDebugProperty2](../vs140/idebugproperty2.md) interface and contains the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object returned from the SP.  
  
4.  Returns the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> interface from the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
## Managed Code  
 This example shows an implementation of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in managed code.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Unmanaged Code  
 This example shows an implementation of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in unmanaged code.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Sample Implementation of Locals](../vs140/sample-implementation-of-locals.md)