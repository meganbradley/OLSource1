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
  
```cpp#  
HRESULT GetMethodLocationProperty(   
   LPCOLESTR             upstrFullyQualifiedMethodPlusOffset,  
   IDebugSymbolProvider* pSymbolProvider,  
   IDebugAddress*        pAddress,  
   IDebugBinder*         pBinder,  
   IDebugProperty2**     ppProperty  
);  
```  
  
```c#  
int GetMethodLocationProperty(  
   string               upstrFullyQualifiedMethodPlusOffset,   
   IDebugSymbolProvider pSymbolProvider,   
   IDebugAddress        pAddress,   
   IDebugBinder         pBinder,   
   out IDebugProperty2  ppProperty  
);  
```  
  
#### Parameters  
 `upstrFullyQualifiedMethodPlusOffset`  
 [in] The method location and offset, expressed as a string.  
  
 `pSymbolProvider`  
 [in] The symbol provider expressed as an [IDebugSymbolProvider](../VS_csharp/idebugsymbolprovider.md) object.  
  
 `pAddress`  
 [in] An address within the method, expressed as an [IDebugAddress](../VS_csharp/idebugaddress.md) object.  
  
 `pBinder`  
 [in] The binder expressed as an [IDebugBinder](../VS_csharp/idebugbinder.md) object.  
  
 `ppProperty`  
 [out] Returns an [IDebugProperty2](../VS_csharp/idebugproperty2.md) interface that represents the memory address.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The returned address can be used to set a breakpoint, for example.  
  
 Despite the name `upstrFullyQualifiedMethodPlusOffset`, this parameter can be passed a partially qualified method name. In that case, the selected method is the one that encloses `pAddress`. How this parameter is interpreted is up to the implementation of the expression evaluator and the language it supports.  
  
## See Also  
 [IDebugSymbolProvider](../VS_csharp/idebugsymbolprovider.md)   
 [IDebugBinder](../VS_csharp/idebugbinder.md)   
 [IDebugProperty2](../VS_csharp/idebugproperty2.md)   
 [IDebugExpressionEvaluator](../VS_csharp/idebugexpressionevaluator.md)