---
title: "IDebugStackFrame3::GetUnwindCodeContext"
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
  - "IDebugStackFrame3::GetUnwindCodeContext"
helpviewer_keywords: 
  - "IDebugStackFrame3::GetUnwindCodeContext method"
ms.assetid: b25f7e7d-2b24-48e4-93b3-829e61d73ebf
caps.latest.revision: 10
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugStackFrame3::GetUnwindCodeContext
Returns the code context representing a location if a stack unwind operation occurred.  
  
## Syntax  
  
```cpp#  
HRESULT GetUnwindCodeContext(  
   IDebugCodeContext2 **ppCodeContext  
);  
```  
  
```c#  
int GetUnwindCodeContext(  
   out IDebugCodeContext2 ppCodeContext  
);  
```  
  
#### Parameters  
 `ppCodeContext`  
 [out] Returns an [IDebugCodeContext2](../vs140/idebugcodecontext2.md) object that represents the code context location if a stack unwind occurred.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Even though this method might return a code context for the location after a stack unwind, it does not necessarily mean the stack unwind can actually occur in the current stack frame.  
  
## See Also  
 [IDebugStackFrame3](../vs140/idebugstackframe3.md)   
 [IDebugCodeContext2](../vs140/idebugcodecontext2.md)