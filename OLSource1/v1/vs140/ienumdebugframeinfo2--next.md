---
title: "IEnumDebugFrameInfo2::Next"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - IEnumDebugFrameInfo2::Next
helpviewer_keywords: 
  - IEnumDebugFrameInfo2::Next
ms.assetid: 64a64eeb-5dea-4119-8a22-03771015d1e5
caps.latest.revision: 16
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IEnumDebugFrameInfo2::Next
Returns the next set of elements from the enumeration.  
  
## Syntax  
  
```cpp#  
HRESULT Next(  
   ULONG       celt,  
   FRAMEINFO** rgelt,  
   ULONG*      pceltFetched  
);  
```  
  
```c#  
int Next(  
   uint        celt,  
   FRAMEINFO[] rgelt,  
   ref uint    pceltFetched  
);  
```  
  
#### Parameters  
 `celt`  
 [in] The number of elements to retrieve. Also specifies the maximum size of the `rgelt` array.  
  
 `rgelt`  
 [in, out] Array of [FRAMEINFO](../vs140/frameinfo.md) elements to be filled in.  
  
 `pceltFetched`  
 [out] Returns the number of elements actually returned in `rgelt`.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if fewer than the requested number of elements could be returned; otherwise, returns an error code.  
  
## See Also  
 [IEnumDebugFrameInfo2](../vs140/ienumdebugframeinfo2.md)   
 [FRAMEINFO](../vs140/frameinfo.md)