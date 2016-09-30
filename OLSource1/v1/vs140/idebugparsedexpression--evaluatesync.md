---
title: "IDebugParsedExpression::EvaluateSync"
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
  - "IDebugParsedExpression::EvaluateSync"
helpviewer_keywords: 
  - "IDebugParsedExpression::EvaluateSync method"
ms.assetid: 0ea04cfa-de87-4b6c-897e-4572c1a28942
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugParsedExpression::EvaluateSync
This method evaluates the parsed expression and optionally casts the result to another data type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A combination of [EVALFLAGS](../vs140/evalflags.md) constants that control how the expression is to be evaluated.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Specifies the maximum time, in milliseconds, to wait before returning from this method. Use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to wait indefinitely.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] The symbol provider, expressed as an [IDebugSymbolProvider](../vs140/idebugsymbolprovider.md) interface.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] The current execution location within a method, expressed as an [IDebugAddress](../vs140/idebugaddress.md) interface.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in] The binder, expressed as an [IDebugBinder](../vs140/idebugbinder.md) interface.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] The type the result should be cast to. This argument can be a null value.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [out] Returns the [IDebugProperty2](../vs140/idebugproperty2.md) interface that represents the results of evaluation.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 The expression evaluation context is given by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, which makes it possible to determine the containing method and then use language scoping rules to determine the value of the symbols in the expression.  
  
## See Also  
 [IDebugSymbolProvider](../vs140/idebugsymbolprovider.md)   
 [IDebugBinder](../vs140/idebugbinder.md)   
 [IDebugAddress](../vs140/idebugaddress.md)   
 [IDebugProperty2](../vs140/idebugproperty2.md)   
 [IDebugParsedExpression](../vs140/idebugparsedexpression.md)