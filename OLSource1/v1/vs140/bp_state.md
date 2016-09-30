---
title: "BP_STATE"
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
  - "BP_STATE"
helpviewer_keywords: 
  - "BP_STATE enumeration"
ms.assetid: 08aa6a3f-3e5f-4c83-8eca-7b7b5f8e208d
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# BP_STATE
Specifies the existence of a bound breakpoint and also specifies if it is enabled.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 BPS_NONE  
 Specifies that no breakpoint exists.  
  
 BPS_DELETED  
 Specifies that the breakpoint has been deleted.  
  
 BPS_DISABLED  
 Specifies that the breakpoint is disabled.  
  
 BPS_ENABLED  
 Specifies that the breakpoint is enabled.  
  
## Remarks  
 Returned from the [GetState](../vs140/idebugboundbreakpoint2--getstate.md) method.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [GetState](../vs140/idebugboundbreakpoint2--getstate.md)