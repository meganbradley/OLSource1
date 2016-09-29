---
title: "IDebugReference2::GetMemoryContext"
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
  - "IDebugReference2::GetMemoryContext"
helpviewer_keywords: 
  - "IDebugReference2::GetMemoryContext"
ms.assetid: 47fc3827-07a0-4eee-b7f4-fc1c62e6b25c
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugReference2::GetMemoryContext
Gets a memory context of a reference. Reserved for future use.  
  
## Syntax  
  
```cpp#  
HRESULT GetMemoryContext (   
   IDebugMemoryContext2** ppMemory  
);  
```  
  
```c#  
int GetMemoryContext (   
   out IDebugMemoryContext2 ppMemory  
);  
```  
  
#### Parameters  
 `ppMemory`  
 [out] Returns the [IDebugMemoryContext2](../vs140/idebugmemorycontext2.md) object that represents the memory associated with the value of the reference.  
  
## Return Value  
 Always returns `E_NOTIMPL`.  
  
## See Also  
 [IDebugReference2](../vs140/idebugreference2.md)   
 [IDebugMemoryContext2](../vs140/idebugmemorycontext2.md)