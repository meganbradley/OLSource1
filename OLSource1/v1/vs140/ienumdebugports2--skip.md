---
title: "IEnumDebugPorts2::Skip"
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
  - "IEnumDebugPorts2::Skip"
helpviewer_keywords: 
  - "IEnumDebugPorts2::Skip"
ms.assetid: a837383f-7b39-4e06-b336-f1715b073dbe
caps.latest.revision: 13
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugPorts2::Skip
Skips over the specified number of elements.  
  
## Syntax  
  
```cpp#  
HRESULT Skip(  
   ULONG celt  
);  
```  
  
```c#  
int Skip(  
   uint celt  
);  
```  
  
#### Parameters  
 `celt`  
 [in] Number of elements to skip.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if `celt` is greater than the number of remaining elements; otherwise, returns an error code.  
  
## Remarks  
 If `celt` specifies a value greater than the number of remaining elements, the enumeration is set to the end and `S_FALSE` is returned.  
  
## See Also  
 [IEnumDebugPorts2](../vs140/ienumdebugports2.md)