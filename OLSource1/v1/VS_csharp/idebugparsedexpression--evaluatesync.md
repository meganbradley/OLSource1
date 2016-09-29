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
  
```cpp#  
HRESULT EvaluateSync(   
   DWORD                 dwEvalFlags,  
   DWORD                 dwTimeout,  
   IDebugSymbolProvider* pSymbolProvider,  
   IDebugAddress*        pAddress,  
   IDebugBinder*         pBinder,  
   BSTR                  bstrResultType,  
   IDebugProperty2**     ppResult  
);  
```  
  
```c#  
int EvaluateSync(  
   uint                 dwEvalFlags,   
   uint                 dwTimeout,   
   IDebugSymbolProvider pSymbolProvider,   
   IDebugAddress        pAddress,   
   IDebugBinder         pBinder,   
   string               bstrResultType,   
   out IDebugProperty2  ppResult  
);  
```  
  
#### Parameters  
 `dwEvalFlags`  
 [in] A combination of [EVALFLAGS](../VS_csharp/evalflags.md) constants that control how the expression is to be evaluated.  
  
 `dwTimeout`  
 [in] Specifies the maximum time, in milliseconds, to wait before returning from this method. Use `INFINITE` to wait indefinitely.  
  
 `pSymbolProvider`  
 [in] The symbol provider, expressed as an [IDebugSymbolProvider](../VS_csharp/idebugsymbolprovider.md) interface.  
  
 `pAddress`  
 [in] The current execution location within a method, expressed as an [IDebugAddress](../VS_csharp/idebugaddress.md) interface.  
  
 `pBinder`  
 [in] The binder, expressed as an [IDebugBinder](../VS_csharp/idebugbinder.md) interface.  
  
 `bstrResultType`  
 [in] The type the result should be cast to. This argument can be a null value.  
  
 `ppResult`  
 [out] Returns the [IDebugProperty2](../VS_csharp/idebugproperty2.md) interface that represents the results of evaluation.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The expression evaluation context is given by `pAddress`, which makes it possible to determine the containing method and then use language scoping rules to determine the value of the symbols in the expression.  
  
## See Also  
 [IDebugSymbolProvider](../VS_csharp/idebugsymbolprovider.md)   
 [IDebugBinder](../VS_csharp/idebugbinder.md)   
 [IDebugAddress](../VS_csharp/idebugaddress.md)   
 [IDebugProperty2](../VS_csharp/idebugproperty2.md)   
 [IDebugParsedExpression](../VS_csharp/idebugparsedexpression.md)