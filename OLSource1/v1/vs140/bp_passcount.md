---
title: "BP_PASSCOUNT"
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
  - "BP_PASSCOUNT"
helpviewer_keywords: 
  - "BP_PASSCOUNT structure"
ms.assetid: 791ac175-b897-4c70-873e-240da7e0ac89
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# BP_PASSCOUNT
Describes the count and conditions upon which a conditional breakpoint is fired.  
  
## Syntax  
  
```cpp#  
typedef struct _BP_PASSCOUNT {   
   DWORD              dwPassCount;  
   BP_PASSCOUNT_STYLE stylePassCount;  
} BP_PASSCOUNT;  
```  
  
```c#  
public struct BP_PASSCOUNT {   
   public uint dwPassCount;  
   public uint stylePassCount;  
};  
```  
  
## Members  
 `dwPassCount`  
 The number of times to pass over the breakpoint before firing it.  
  
 `stylePassCount`  
 A value from the [BP_PASSCOUNT_STYLE](../vs140/bp_passcount_style.md) enumeration that specifies the style of the breakpoint pass count.  
  
## Remarks  
 This structure is a member of the [BP_REQUEST_INFO](../vs140/bp_request_info.md) structure.  
  
 This structure is also passed as a parameter to the[SetPassCount](../vs140/idebugboundbreakpoint2--setpasscount.md) and[SetPassCount](../vs140/idebugpendingbreakpoint2--setpasscount.md) methods.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [BP_REQUEST_INFO](../vs140/bp_request_info.md)   
 [SetPassCount](../vs140/idebugboundbreakpoint2--setpasscount.md)   
 [SetPassCount](../vs140/idebugpendingbreakpoint2--setpasscount.md)   
 [BP_PASSCOUNT_STYLE](../vs140/bp_passcount_style.md)