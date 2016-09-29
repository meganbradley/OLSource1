---
title: "IEEVisualizerServiceProvider::CreateVisualizerService"
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
  - "IEEVisualizerServiceProvider::CreateVisualizerService"
helpviewer_keywords: 
  - "IEEVisualizerServiceProvider::CreateVisualizerService method"
ms.assetid: f366f7c9-358d-46c8-993f-32ff86539833
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEEVisualizerServiceProvider::CreateVisualizerService
This method creates a visualizer service.  
  
## Syntax  
  
```cpp  
HRESULT CreateVisualizerService(  
   IDebugBinder*              binder,  
   IDebugSymbolProvider*      pSymProv,  
   IDebugAddress*             pAddress,  
   IEEVisualizerDataProvider* dataProvider,  
   IEEVisualizerService**     ppService  
);  
```  
  
```c#  
int CreateVisualizerService(  
   IDebugBinder binder,  
   IDebugSymbolProvider      pSymProv,  
   IDebugAddress             pAddress,  
   IEEVisualizerDataProvider dataProvider,  
   out IEEVisualizerService  ppService  
);  
```  
  
#### Parameters  
 `binder`  
 [in] The [IDebugBinder](../vs140/idebugbinder.md) object passed to [IDebugParsedExpression::EvaluateSync](../vs140/idebugparsedexpression--evaluatesync.md).  
  
 `pSymProv`  
 [in] The [IDebugSymbolProvider](../vs140/idebugsymbolprovider.md) object passed to `IDebugParsedExpression::EvaluateSync`.  
  
 `pAddress`  
 [in] The [IDebugAddress](../vs140/idebugaddress.md) object passed to `IDebugParsedExression::EvaluateSync`.  
  
 `dataProvider`  
 [in] An object implementing the [IEEVisualizerDataProvider](../vs140/ieevisualizerdataprovider.md) interface (supplied by the expression evaluator).  
  
 `ppService`  
 [out] The created service.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The `binder`, `pSymProv`, and `pAddress` parameters were all passed to the `IDebugParsedExpression::EvaluateSync` method. `CreateVisualizerService` is to be called only from `IDebugParsedExpression::EvaluateSync` as part of an expression evaluator's support for type visualizers.  
  
## See Also  
 [IEEVisualizerServiceProvider](../vs140/ieevisualizerserviceprovider.md)   
 [IDebugParsedExpression::EvaluateSync](../vs140/idebugparsedexpression--evaluatesync.md)   
 [IDebugBinder](../vs140/idebugbinder.md)   
 [IDebugSymbolProvider](../vs140/idebugsymbolprovider.md)   
 [IEEVisualizerDataProvider](../vs140/ieevisualizerdataprovider.md)