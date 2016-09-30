---
title: "IDebugExpressionEvaluator::GetMethodLocationProperty"
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
  - "IDebugExpressionEvaluator::GetMethodLocationProperty"
helpviewer_keywords: 
  - "IDebugExpressionEvaluator::GetMethodLocationProperty method"
ms.assetid: 52c42a2e-f144-476b-8bef-442464c8fe8e
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugExpressionEvaluator::GetMethodLocationProperty
This method converts a method location and offset into a memory address.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The method location and offset, expressed as a string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The symbol provider expressed as an [IDebugSymbolProvider](../vs140/idebugsymbolprovider.md) object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] An address within the method, expressed as an [IDebugAddress](../vs140/idebugaddress.md) object.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] The binder expressed as an [IDebugBinder](../vs140/idebugbinder.md) object.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [out] Returns an [IDebugProperty2](../vs140/idebugproperty2.md) interface that represents the memory address.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 The returned address can be used to set a breakpoint, for example.  
  
 Despite the name <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, this parameter can be passed a partially qualified method name. In that case, the selected method is the one that encloses <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. How this parameter is interpreted is up to the implementation of the expression evaluator and the language it supports.  
  
## See Also  
 [IDebugSymbolProvider](../vs140/idebugsymbolprovider.md)   
 [IDebugBinder](../vs140/idebugbinder.md)   
 [IDebugProperty2](../vs140/idebugproperty2.md)   
 [IDebugExpressionEvaluator](../vs140/idebugexpressionevaluator.md)