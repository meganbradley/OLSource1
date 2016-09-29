---
title: "IDebugDisassemblyStream2::GetCodeContext"
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
  - "IDebugDisassemblyStream2::GetCodeContext"
helpviewer_keywords: 
  - "IDebugDisassemblyStream2::GetCodeContext"
ms.assetid: a6d0ae82-7617-4915-9713-369abe3e2e53
caps.latest.revision: 14
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDisassemblyStream2::GetCodeContext
Returns a code context object corresponding to a specified code location identifier.  
  
## Syntax  
  
```cpp#  
HRESULT GetCodeContext(   
   UINT64               uCodeLocationId,  
   IDebugCodeContext2** ppCodeContext  
);  
```  
  
```c#  
int GetCodeContext(   
   ulong                  uCodeLocationId,  
   out IDebugCodeContext2 ppCodeContext  
);  
```  
  
#### Parameters  
 `uCodeLocationId`  
 [in] Specifies the code location identifier. See the Remarks section for the [IDebugDisassemblyStream2::GetCodeLocationId](../vs140/idebugdisassemblystream2--getcodelocationid.md) method for a description of a code location identifier.  
  
 `ppCodeContext`  
 [out] Returns an [IDebugCodeContext2](../vs140/idebugcodecontext2.md) object that represents the associated code context.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The code location identifier can be returned from a call to the [IDebugDisassemblyStream2::GetCurrentLocation](../vs140/idebugdisassemblystream2--getcurrentlocation.md) method and can appear in the [DisassemblyData](../vs140/disassemblydata.md) structure.  
  
 To convert a code context into a code location identifier, call the [IDebugDisassemblyStream2::GetCodeLocationId](../vs140/idebugdisassemblystream2--getcodelocationid.md) method.  
  
## See Also  
 [IDebugDisassemblyStream2](../vs140/idebugdisassemblystream2.md)   
 [IDebugCodeContext2](../vs140/idebugcodecontext2.md)   
 [IDebugDisassemblyStream2::GetCodeLocationId](../vs140/idebugdisassemblystream2--getcodelocationid.md)   
 [IDebugDisassemblyStream2::GetCurrentLocation](../vs140/idebugdisassemblystream2--getcurrentlocation.md)   
 [DisassemblyData](../vs140/disassemblydata.md)