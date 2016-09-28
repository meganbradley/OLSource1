---
title: "IEnumCodePaths2::Next"
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
  - "IEnumCodePaths2::Next"
helpviewer_keywords: 
  - "IEnumCodePaths2::Next"
ms.assetid: c7a8fe97-2abc-4cee-8aef-64f1daa93b5c
caps.latest.revision: 17
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumCodePaths2::Next
Returns the next set of elements from the enumeration.  
  
## Syntax  
  
```cpp#  
HRESULT Next(  
   ULONG       celt,  
   CODE_PATH** rgelt,  
   ULONG*      pceltFetched  
);  
```  
  
```c#  
int Next(  
   uint        celt,  
   CODE_PATH[] rgelt,  
   ref uint    pceltFetched  
);  
```  
  
#### Parameters  
 `celt`  
 [in] The number of elements to retrieve. Also specifies the maximum size of the `rgelt` array.  
  
 `rgelt`  
 [in, out] Array of [CODE_PATH](../vs140/code_path.md) elements to be filled in.  
  
 `pceltFetched`  
 [out] Returns the number of elements actually returned in `rgelt`.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if fewer than the requested number of elements could be returned; otherwise, returns an error code.  
  
## See Also  
 [IEnumCodePaths2](../vs140/ienumcodepaths2.md)   
 [CODE_PATH](../vs140/code_path.md)