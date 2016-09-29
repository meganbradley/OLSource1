---
title: "BP_CONDITION"
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
  - "BP_CONDITION"
helpviewer_keywords: 
  - "BP_CONDITION structure"
ms.assetid: 407f87a3-2878-429b-8c65-b68feb36622a
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# BP_CONDITION
Describes the conditions under which a breakpoint fires.  
  
## Syntax  
  
```cpp#  
typedef struct _BP_CONDITION {   
   IDebugThread2* pThread;  
   BP_COND_STYLE  styleCondition;  
   BSTR           bstrContext;  
   BSTR           bstrCondition;  
   UINT           nRadix;  
} BP_CONDITION;  
```  
  
```c#  
public struct BP_CONDITION {   
   public IDebugThread2 pThread;  
   public uint          styleCondition;  
   public string        bstrContext;  
   public string        bstrCondition;  
   public uint          nRadix;  
};  
```  
  
## Members  
 `pThread`  
 The [IDebugThread2](../VS_csharp/idebugthread2.md) object that represents the active thread for the application that contains the breakpoint.  
  
 `styleCondition`  
 A value from the [BP_COND_STYLE](../VS_csharp/bp_cond_style.md) enumeration describing the style of this breakpoint condition.  
  
 `bstrContext`  
 The location of the breakpoint.  
  
 `bstrCondition`  
 The firing condition of the breakpoint.  
  
 `nRadix`  
 Radix to be used in evaluating any numerical information.  
  
## Remarks  
 This structure is a member of the [BP_REQUEST_INFO](../VS_csharp/bp_request_info.md) and [BP_REQUEST_INFO2](../VS_csharp/bp_request_info2.md) structures.  
  
 This structure is also passed as a parameter to the [SetCondition](../VS_csharp/idebugboundbreakpoint2--setcondition.md) and [SetCondition](../VS_csharp/idebugpendingbreakpoint2--setcondition.md) methods.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../VS_csharp/structures-and-unions.md)   
 [BP_REQUEST_INFO](../VS_csharp/bp_request_info.md)   
 [BP_REQUEST_INFO2](../VS_csharp/bp_request_info2.md)   
 [SetCondition](../VS_csharp/idebugboundbreakpoint2--setcondition.md)   
 [SetCondition](../VS_csharp/idebugpendingbreakpoint2--setcondition.md)   
 [IDebugThread2](../VS_csharp/idebugthread2.md)   
 [BP_COND_STYLE](../VS_csharp/bp_cond_style.md)