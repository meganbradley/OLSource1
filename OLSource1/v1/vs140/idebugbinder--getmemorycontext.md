---
title: "IDebugBinder::GetMemoryContext"
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
  - "IDebugBinder::GetMemoryContext"
helpviewer_keywords: 
  - "IDebugBinder::GetMemoryContext method"
ms.assetid: 801c5b60-acff-4822-b23d-e9c7bbca8a0f
caps.latest.revision: 16
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBinder::GetMemoryContext
This method converts either an object location or a memory address to a memory context.  
  
## Syntax  
  
```cpp#  
HRESULT GetMemoryContext(   
   IDebugField*           pField,  
   DWORD                  dwConstant,  
   IDebugMemoryContext2** ppMemCxt  
);  
```  
  
```c#  
int GetMemoryContext(  
   IDebugField              pField,   
   uint                     dwConstant,   
   out IDebugMemoryContext2 ppMemCxt  
);  
```  
  
#### Parameters  
 `pField`  
 [in] An [IDebugField](../vs140/idebugfield.md) describing the object to locate. If `NULL`, then use `dwConstant` instead.  
  
 `dwConstant`  
 [in] A constant memory address, such as 0x5000.  
  
 `ppMemCxt`  
 [out] Returns the [IDebugMemoryContext2](../vs140/idebugmemorycontext2.md) interface that represents the address of the object, or the address in memory.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugBinder](../vs140/idebugbinder.md)   
 [IDebugMemoryContext2](../vs140/idebugmemorycontext2.md)   
 [IDebugField](../vs140/idebugfield.md)