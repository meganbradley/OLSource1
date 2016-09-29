---
title: "IDebugDynamicFieldCOMPlus::GetTypeFromPrimitive"
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
  - "IDebugDynamicFieldCOMPlus::GetTypeFromPrimitive"
  - "GetTypeFromPrimitive"
ms.assetid: d7f51e2a-1b72-489c-b7b6-4af7b7e4d663
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDynamicFieldCOMPlus::GetTypeFromPrimitive
Retrieves a type given its primitive type.  
  
## Syntax  
  
```cpp#  
HRESULT GetTypeFromPrimitive(  
   DWORD         dwCorElementType,  
   IDebugField** ppType  
);  
```  
  
```c#  
int GetTypeFromPrimitive(  
   uint            dwCorElementType,  
   out IDebugField ppType  
);  
```  
  
#### Parameters  
 `dwCorElementType`  
 [in] Value from the [CorElementType Enumeration](assetId:///c3809c8f-1737-4f0f-9442-0c01ee689871) that represents the primitive type.  
  
 `ppType`  
 [out] Returns the [IDebugField](../vs140/idebugfield.md) that represents the type.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugDynamicFieldCOMPlus](../vs140/idebugdynamicfieldcomplus.md)