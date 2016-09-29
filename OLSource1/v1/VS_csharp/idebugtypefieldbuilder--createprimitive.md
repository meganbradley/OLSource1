---
title: "IDebugTypeFieldBuilder::CreatePrimitive"
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
  - "CreatePrimitive"
  - "IDebugTypeFieldBuilder::CreatePrimitive"
ms.assetid: 512c6ff0-97c5-409f-939f-4cc969bc4bb9
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugTypeFieldBuilder::CreatePrimitive
Creates an object that represents a primitive type.  
  
## Syntax  
  
```cpp#  
HRESULT CreatePrimitive (  
   DWORD          dwElementType,  
   IDebugField ** pTypeField  
);  
```  
  
```c#  
int CreatePrimitive (  
   uint            dwElementType,  
   out IDebugField pTypeField  
);  
```  
  
#### Parameters  
 `dwElementType`  
 [in] Value from the [CorElementType Enumeration](assetId:///c3809c8f-1737-4f0f-9442-0c01ee689871) that represents the primitive type.  
  
 `pTypeField`  
 [out] Returns the IDebugField interface for the new type.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugTypeFieldBuilder](../VS_csharp/idebugtypefieldbuilder.md)