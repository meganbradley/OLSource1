---
title: "IEnumDebugObjects::Next"
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
  - "IEnumDebugObjects::Next"
helpviewer_keywords: 
  - "IEnumDebugObjects::Next method"
ms.assetid: e54c3055-6030-4dc9-9f7a-5e3ce75f252f
caps.latest.revision: 10
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugObjects::Next
This method returns the next set of elements from the enumeration.  
  
## Syntax  
  
```cpp#  
HRESULT Next(  
   ULONG          celt,  
   IDebugObject** rgelt,  
   ULONG*         pceltFetched  
);  
```  
  
```c#  
int Next(  
   uint           celt,  
   IDebugObject[] rgelt,  
   ref uint       pceltFetched  
);  
```  
  
#### Parameters  
 `celt`  
 [in] The number of elements to retrieve. Also specifies the maximum size of the `rgelt` array.  
  
 `rgelt`  
 [in, out] Array of [IDebugObject](../vs140/idebugobject.md) elements to be filled in.  
  
 `pceltFetched`  
 [out] Returns the number of elements actually returned in `rgelt`.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if fewer than the requested number of elements could be returned; otherwise, returns an error code.  
  
## See Also  
 [IEnumDebugObjects](../vs140/ienumdebugobjects.md)   
 [IDebugObject](../vs140/idebugobject.md)