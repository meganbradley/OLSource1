---
title: "IEnumDebugObjects::Skip"
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
  - "IEnumDebugObjects::Skip"
helpviewer_keywords: 
  - "IEnumDebugObjects::Skip method"
ms.assetid: 957cead8-0a9c-4403-b190-b9fbadc49d42
caps.latest.revision: 8
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugObjects::Skip
This method skips over the specified number of elements.  
  
## Syntax  
  
```cpp#  
HRESULT Skip(  
   [in] ULONG celt  
);  
```  
  
```c#  
int Skip(  
   [In] uint celt  
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
 [IEnumDebugObjects](../vs140/ienumdebugobjects.md)