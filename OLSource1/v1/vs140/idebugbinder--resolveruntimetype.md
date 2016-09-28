---
title: "IDebugBinder::ResolveRuntimeType"
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
  - "IDebugBinder::ResolveRuntimeType"
helpviewer_keywords: 
  - "IDebugBinder::ResolveRuntimeType method"
ms.assetid: 6456ab3e-1c03-4f3c-91f9-16797ab7f5e7
caps.latest.revision: 16
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBinder::ResolveRuntimeType
This method determines the run-time type of an object.  
  
## Syntax  
  
```cpp#  
HRESULT ResolveRuntimeType(   
   IDebugObject* pObject,  
   IDebugField** ppResolved  
);  
```  
  
```c#  
int ResolveRuntimeType(  
   IDebugObject     pObject,   
   out IDebugField  ppResolved  
);  
```  
  
#### Parameters  
 `pObject`  
 [in] The [IDebugObject](../vs140/idebugobject.md) to be resolved.  
  
 `ppResolved`  
 [out] Returns the type of the object as an [IDebugField](../vs140/idebugfield.md).  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The run-time type of an object is not always known at compile time. For example, using polymorphism, an argument can be passed to a function as its base class, such as a button class. The actual argument might be a derived class, such as a radio button class.  
  
## See Also  
 [IDebugBinder](../vs140/idebugbinder.md)   
 [IDebugObject](../vs140/idebugobject.md)   
 [IDebugField](../vs140/idebugfield.md)