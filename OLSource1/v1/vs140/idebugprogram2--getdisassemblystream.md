---
title: "IDebugProgram2::GetDisassemblyStream"
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
  - "IDebugProgram2::GetDisassemblyStream"
helpviewer_keywords: 
  - "IDebugProgram2::GetDisassemblyStream"
ms.assetid: beda0da5-267e-4bf3-96c4-b659d29e2254
caps.latest.revision: 15
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgram2::GetDisassemblyStream
Gets the disassembly stream for this program or a part of this program.  
  
## Syntax  
  
```cpp#  
HRESULT GetDisassemblyStream(   
   DISASSEMBLY_STREAM_SCOPE   dwScope,  
   IDebugCodeContext2*        pCodeContext,  
   IDebugDisassemblyStream2** ppDisassemblyStream  
);  
```  
  
```c#  
int GetDisassemblyStream(   
   enum_DISASSEMBLY_STREAM_SCOPE  dwScope,  
   IDebugCodeContext2             pCodeContext,  
   out IDebugDisassemblyStream2   ppDisassemblyStream  
);  
```  
  
#### Parameters  
 `dwScope`  
 [in] Specifies a value from the [DISASSEMBLY_STREAM_SCOPE](../vs140/disassembly_stream_scope.md) enumeration that defines the scope of the disassembly stream.  
  
 `pCodeContext`  
 [in] An [IDebugCodeContext2](../vs140/idebugcodecontext2.md) object that represents the position of where to start the disassembly stream.  
  
 `ppDisassemblyStream`  
 [out] Returns an [IDebugDisassemblyStream2](../vs140/idebugdisassemblystream2.md) object that represents the disassembly stream.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code. Returns `E_DISASM_NOTSUPPORTED` if disassembly is not supported for this particular architecture.  
  
## Remarks  
 If the `dwScopes` parameter has the `DSS_HUGE` flag of the [DISASSEMBLY_STREAM_SCOPE](../vs140/disassembly_stream_scope.md) enumeration set, then the disassembly is expected to return a large number of disassembly instructions, for example, for an entire file or module. If the `DSS_HUGE` flag is not set, then the disassembly is expected to be confined to a small region, typically that of a single function.  
  
## See Also  
 [IDebugProgram2](../vs140/idebugprogram2.md)   
 [DISASSEMBLY_STREAM_SCOPE](../vs140/disassembly_stream_scope.md)   
 [IDebugCodeContext2](../vs140/idebugcodecontext2.md)   
 [IDebugDisassemblyStream2](../vs140/idebugdisassemblystream2.md)