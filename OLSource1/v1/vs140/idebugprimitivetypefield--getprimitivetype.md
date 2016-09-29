---
title: "IDebugPrimitiveTypeField::GetPrimitiveType"
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
  - "GetPrimitiveType"
  - "IDebugPrimitiveTypeField::GetPrimitiveType"
ms.assetid: a186c922-bbfe-478c-a744-b21eb4672d8f
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPrimitiveTypeField::GetPrimitiveType
Retrieves the primitive type that is associated with this field.  
  
## Syntax  
  
```cpp#  
HRESULT GetPrimitiveType (  
   DWORD* pdwType  
);  
```  
  
```c#  
int GetPrimitiveType (  
   out uint pdwType  
);  
```  
  
#### Parameters  
 `pdwType`  
 [out] Value from the [CorElementType Enumeration](assetId:///c3809c8f-1737-4f0f-9442-0c01ee689871) that represents the primitive type.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE`.  
  
## See Also  
 [IDebugPrimitiveTypeField](../vs140/idebugprimitivetypefield.md)