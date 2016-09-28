---
title: "IDebugProcess3::GetDebugReason"
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
  - "IDebugProcess3::GetDebugReason"
helpviewer_keywords: 
  - "IDebugProcess3::GetDebugReason"
ms.assetid: f23fbabc-8b18-4278-bebf-4cdc7091513c
caps.latest.revision: 15
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProcess3::GetDebugReason
This method returns the reason that the process was launched for debugging.  
  
## Syntax  
  
```cpp  
HRESULT GetDebugReason(  
   DEBUG_REASON* pReason  
);  
```  
  
```c#  
int GetDebugReason(  
   out enum_DEBUG_REASON pReason  
);  
```  
  
#### Parameters  
 `pReason`  
 [out] Returns a value from the [DEBUG_REASON](../vs140/debug_reason.md) enumeration.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns error code.  
  
## See Also  
 [IDebugProcess3](../vs140/idebugprocess3.md)   
 [DEBUG_REASON](../vs140/debug_reason.md)