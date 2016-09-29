---
title: "IDebugField::GetKind"
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
  - "IDebugField::GetKind"
helpviewer_keywords: 
  - "IDebugField::GetKind method"
ms.assetid: e7c9c60a-8e55-4ecc-aa63-0c814a1e92cc
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugField::GetKind
This method gets the kind of field.  
  
## Syntax  
  
```cpp#  
HRESULT GetKind(   
   FIELD_KIND* pdwKind  
);  
```  
  
```c#  
int GetKind(  
   out enum_FIELD_KIND pdwKind  
);  
```  
  
#### Parameters  
 `pdwKind`  
 [out] Returns the kind of field as a combination of [FIELD_KIND](../VS_csharp/field_kind.md) constants.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugField](../VS_csharp/idebugfield.md)   
 [FIELD_KIND](../VS_csharp/field_kind.md)