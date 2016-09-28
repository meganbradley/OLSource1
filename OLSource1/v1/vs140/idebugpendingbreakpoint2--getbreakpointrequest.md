---
title: "IDebugPendingBreakpoint2::GetBreakpointRequest"
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
  - "IDebugPendingBreakpoint2::GetBreakpointRequest"
helpviewer_keywords: 
  - "IDebugPendingBreakpoint2::GetBreakpointRequest method"
  - "GetBreakpointRequest method"
ms.assetid: cb1e36aa-4302-455c-98fb-6638a1ef5c46
caps.latest.revision: 14
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPendingBreakpoint2::GetBreakpointRequest
Gets the breakpoint request that was used to create this pending breakpoint.  
  
## Syntax  
  
```cpp#  
HRESULT GetBreakpointRequest(   
   IDebugBreakpointRequest2** ppBPRequest  
);  
```  
  
```c#  
int GetBreakpointRequest(   
   out IDebugBreakpointRequest2 ppBPRequest  
);  
```  
  
#### Parameters  
 `ppBPRequest`  
 [out] Returns an [IDebugBreakpointRequest2](../vs140/idebugbreakpointrequest2.md) object representing the breakpoint request that was used to create this pending breakpoint.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code. Returns `E_BP_DELETED` if the breakpoint has been deleted.  
  
## See Also  
 [IDebugPendingBreakpoint2](../vs140/idebugpendingbreakpoint2.md)   
 [IDebugBreakpointRequest2](../vs140/idebugbreakpointrequest2.md)