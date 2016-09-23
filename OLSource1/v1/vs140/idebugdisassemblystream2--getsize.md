---
title: "IDebugDisassemblyStream2::GetSize"
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
  - IDebugDisassemblyStream2::GetSize
helpviewer_keywords: 
  - IDebugDisassemblyStream2::GetSize
ms.assetid: 8f512704-12d0-46d2-959a-4f8dffe117b5
caps.latest.revision: 14
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugDisassemblyStream2::GetSize
Gets the size in instructions of this disassembly stream.  
  
## Syntax  
  
```cpp#  
HRESULT GetSize(   
   UINT64* pnSize  
);  
```  
  
```c#  
int GetSize(   
   out ulong pnSize  
);  
```  
  
#### Parameters  
 `pnSize`  
 [out] Returns the size, in instructions.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The value returned from this method can be used to allocate an array of [DisassemblyData](../vs140/disassemblydata.md) structures which is then passed to the [IDebugDisassemblyStream2::Read](../vs140/idebugdisassemblystream2--read.md) method.  
  
## See Also  
 [IDebugDisassemblyStream2](../vs140/idebugdisassemblystream2.md)   
 [DisassemblyData](../vs140/disassemblydata.md)   
 [IDebugDisassemblyStream2::Read](../vs140/idebugdisassemblystream2--read.md)