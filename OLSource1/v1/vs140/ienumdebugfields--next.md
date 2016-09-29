---
title: "IEnumDebugFields::Next"
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
  - "IEnumDebugFields::Next"
helpviewer_keywords: 
  - "IEnumDebugFields::Next method"
ms.assetid: 22c177a2-af81-4234-812b-f9b47be245a2
caps.latest.revision: 11
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugFields::Next
This method returns the next set of elements from the enumeration.  
  
## Syntax  
  
```cpp#  
HRESULT Next(  
   ULONG         celt,  
   IDebugField** rgelt,  
   ULONG*        pceltFetched  
);  
```  
  
```c#  
int Next(  
   uint          celt,  
   IDebugField[] rgelt,  
   ref uint      pceltFetched  
);  
```  
  
#### Parameters  
 `celt`  
 [in] The number of elements to retrieve. Also specifies the maximum size of the `rgelt` array.  
  
 `rgelt`  
 [in, out] Array of [IDebugField](../vs140/idebugfield.md) elements to be filled in.  
  
 `pceltFetched`  
 [out] Returns the number of elements actually returned in `rgelt`.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if fewer than the requested number of elements could be returned; otherwise, returns an error code.  
  
## See Also  
 [IEnumDebugFields](../vs140/ienumdebugfields.md)   
 [IDebugField](../vs140/idebugfield.md)