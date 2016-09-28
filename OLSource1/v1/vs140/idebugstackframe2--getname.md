---
title: "IDebugStackFrame2::GetName"
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
  - "IDebugStackFrame2::GetName"
helpviewer_keywords: 
  - "IDebugStackFrame2::GetName"
ms.assetid: 069d4f96-363f-404e-9c89-5318c4c9821b
caps.latest.revision: 14
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugStackFrame2::GetName
Gets the name of the stack frame.  
  
## Syntax  
  
```cpp#  
HRESULT GetName (   
   BSTR* pbstrName  
);  
```  
  
```c#  
int GetName (   
   out string pbstrName  
);  
```  
  
#### Parameters  
 `pbstrName`  
 [out] Returns the name of the stack frame.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The name of a stack frame is typically the name of the method being executed.  
  
## See Also  
 [IDebugStackFrame2](../vs140/idebugstackframe2.md)