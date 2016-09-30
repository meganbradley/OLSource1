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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The [IDebugThread2](../vs140/idebugthread2.md) object that represents the active thread for the application that contains the breakpoint.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A value from the [BP_COND_STYLE](../vs140/bp_cond_style.md) enumeration describing the style of this breakpoint condition.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The location of the breakpoint.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The firing condition of the breakpoint.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Radix to be used in evaluating any numerical information.  
  
## Remarks  
 This structure is a member of the [BP_REQUEST_INFO](../vs140/bp_request_info.md) and [BP_REQUEST_INFO2](../vs140/bp_request_info2.md) structures.  
  
 This structure is also passed as a parameter to the [SetCondition](../vs140/idebugboundbreakpoint2--setcondition.md) and [SetCondition](../vs140/idebugpendingbreakpoint2--setcondition.md) methods.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [BP_REQUEST_INFO](../vs140/bp_request_info.md)   
 [BP_REQUEST_INFO2](../vs140/bp_request_info2.md)   
 [SetCondition](../vs140/idebugboundbreakpoint2--setcondition.md)   
 [SetCondition](../vs140/idebugpendingbreakpoint2--setcondition.md)   
 [IDebugThread2](../vs140/idebugthread2.md)   
 [BP_COND_STYLE](../vs140/bp_cond_style.md)