---
title: "PENDING_BP_STATE_INFO"
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
  - "PENDING_BP_STATE_INFO"
helpviewer_keywords: 
  - "PENDING_BP_STATE_INFO structure"
ms.assetid: 4d73ceff-43f9-4e95-8dba-88e1fab2def3
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# PENDING_BP_STATE_INFO
Contains information about the state of a breakpoint that is ready to bind to a code location.  
  
## Syntax  
  
```cpp#  
typedef struct _tagPENDING_BP_STATE_INFO {   
   PENDING_BP_STATE       state;  
   PENDING_BP_STATE_FLAGS flags;  
} PENDING_BP_STATE_INFO;  
```  
  
```c#  
public struct PENDING_BP_STATE_INFO {   
   public uint state;  
   public uint flags;  
};  
```  
  
## Members  
 state  
 A value from the [PENDING_BP_STATE](../vs140/pending_bp_state.md) enumeration that specifies the state of the pending breakpoint.  
  
 flags  
 A combination of flags from the [PENDING_BP_STATE_FLAGS](../vs140/pending_bp_state_flags.md) enumeration that specifies whether the breakpoint is virtualized.  
  
## Remarks  
 This structure is passed to the [GetState](../vs140/idebugpendingbreakpoint2--getstate.md) method where it is filled in.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [GetState](../vs140/idebugpendingbreakpoint2--getstate.md)   
 [PENDING_BP_STATE](../vs140/pending_bp_state.md)   
 [PENDING_BP_STATE_FLAGS](../vs140/pending_bp_state_flags.md)