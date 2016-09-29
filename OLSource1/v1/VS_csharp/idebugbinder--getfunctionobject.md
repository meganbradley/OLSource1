---
title: "IDebugBinder::GetFunctionObject"
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
  - "IDebugBinder::GetFunctionObject"
helpviewer_keywords: 
  - "IDebugBinder::GetFunctionObject method"
ms.assetid: 8fb789df-8f30-420d-8ca5-bb496a6738f1
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBinder::GetFunctionObject
This method gets an [IDebugFunctionObject](../VS_csharp/idebugfunctionobject.md) object used to create function parameters.  
  
## Syntax  
  
```cpp#  
HRESULT GetFunctionObject(   
   IDebugFunctionObject **ppFunction  
);  
```  
  
```c#  
int GetFunctionObject(  
   out IDebugFunctionObject ppFunction  
);  
```  
  
#### Parameters  
 `ppFunction`  
 [out] Returns the [IDebugFunctionObject](../VS_csharp/idebugfunctionobject.md) interface that is used to create function parameters.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## See Also  
 [IDebugBinder](../VS_csharp/idebugbinder.md)   
 [IDebugFunctionObject](../VS_csharp/idebugfunctionobject.md)