---
title: "IEnumDebugPorts2::Next"
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
  - "IEnumDebugPorts2::Next"
helpviewer_keywords: 
  - "IEnumDebugPorts2::Next"
ms.assetid: 3f43d18c-6bd1-4ddd-95ef-9550abd2ad09
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugPorts2::Next
Returns the next set of elements from the enumeration.  
  
## Syntax  
  
```cpp#  
HRESULT Next(  
   ULONG         celt,  
   IDebugPort2** rgelt,  
   ULONG*        pceltFetched  
);  
```  
  
```c#  
int Next(  
   uint          celt,  
   IDebugPort2[] rgelt,  
   ref uint      pceltFetched  
);  
```  
  
#### Parameters  
 `celt`  
 [in] The number of elements to retrieve. Also specifies the maximum size of the `rgelt` array.  
  
 `rgelt`  
 [in, out] Array of [IDebugPort2](../VS_csharp/idebugport2.md) elements to be filled in.  
  
 `pceltFetched`  
 [out] Returns the number of elements actually returned in `rgelt`.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if fewer than the requested number of elements could be returned; otherwise, returns an error code.  
  
## See Also  
 [IEnumDebugPorts2](../VS_csharp/ienumdebugports2.md)   
 [IDebugPort2](../VS_csharp/idebugport2.md)