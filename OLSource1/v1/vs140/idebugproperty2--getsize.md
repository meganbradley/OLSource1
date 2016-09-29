---
title: "IDebugProperty2::GetSize"
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
  - "IDebugProperty2::GetSize"
helpviewer_keywords: 
  - "IDebugProperty2::GetSize"
ms.assetid: 0deb8ec5-d6fb-4622-bb14-0c46b9459cc6
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProperty2::GetSize
Gets the size, in bytes, of the property value.  
  
## Syntax  
  
```cpp#  
HRESULT GetSize (   
   DWORD* pdwSize  
);  
```  
  
```c#  
int GetSize (   
   out uint pdwSize  
);  
```  
  
#### Parameters  
 `pdwSize`  
 [out] Returns the size, in bytes, of the property value.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise returns error code. Returns `S_GETSIZE_NO_SIZE` if the property has no size.  
  
## See Also  
 [IDebugProperty2](../vs140/idebugproperty2.md)