---
title: "IDebugPendingBreakpoint2::Bind"
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
  - "IDebugPendingBreakpoint2::Bind"
helpviewer_keywords: 
  - "Bind method"
  - "IDebugPendingBreakpoint2::Bind method"
ms.assetid: 46e3f307-219d-40cd-a929-d41399c60ecf
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPendingBreakpoint2::Bind
Binds this pending breakpoint to one or more code locations.  
  
## Syntax  
  
```cpp#  
HRESULT Bind(   
   void   
);  
```  
  
```c#  
int Bind();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code. Returns `E_BP_DELETED` if the breakpoint has been deleted.  
  
## Remarks  
 When this method is called, a debug engine (DE) should attempt to bind this pending breakpoint to all code locations that match.  
  
 After this method returns, the caller needs to wait for events indicating that the pending breakpoint has bound or is in error before assuming that calls to the [EnumBoundBreakpoints](../VS_csharp/idebugpendingbreakpoint2--enumboundbreakpoints.md) or [EnumErrorBreakpoints](../VS_csharp/idebugpendingbreakpoint2--enumerrorbreakpoints.md).methods will enumerate all bound or error breakpoints, respectively.  
  
## See Also  
 [IDebugPendingBreakpoint2](../VS_csharp/idebugpendingbreakpoint2.md)   
 [IDebugBreakpointBoundEvent2](../VS_csharp/idebugbreakpointboundevent2.md)   
 [IDebugBreakpointErrorEvent2](../VS_csharp/idebugbreakpointerrorevent2.md)   
 [EnumBoundBreakpoints](../VS_csharp/idebugpendingbreakpoint2--enumboundbreakpoints.md)   
 [EnumErrorBreakpoints](../VS_csharp/idebugpendingbreakpoint2--enumerrorbreakpoints.md)