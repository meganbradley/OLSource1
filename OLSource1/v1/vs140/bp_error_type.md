---
title: "BP_ERROR_TYPE"
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
  - "BP_ERROR_TYPE"
helpviewer_keywords: 
  - "BP_ERROR_TYPE enumeration"
ms.assetid: c483eaab-db29-46de-bfdb-5c2a9a9cfb68
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# BP_ERROR_TYPE
Specifies the error type of a breakpoint.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 BPET_NONE  
 Specifies no breakpoint error.  
  
 BPET_TYPE_WARNING  
 Specifies a warning-style breakpoint error.  
  
 BPET_TYPE_ERROR  
 Specifies an error-style breakpoint error.  
  
 BPET_SEV_HIGH  
 Specifies a high-severity breakpoint error.  
  
 BPET_SEV_GENERAL  
 Specifies a medium-severity breakpoint error.  
  
 BPET_SEV_LOW  
 Specifies a low-severity breakpoint error.  
  
 BPET_TYPE_MASK  
 Specifies a mask-style breakpoint error.  
  
 BPET_SEV_MASK  
 Specifies a severity-mask-style breakpoint error.  
  
 BPET_GENERAL_WARNING  
 Specifies a general-warning-style breakpoint error.  
  
 BPET_GENERAL_ERROR  
 Specifies a general-error-style breakpoint error.  
  
 BPET_ALL  
 Specifies all breakpoint error types.  
  
## Remarks  
 These values may be combined with a bitwise <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and used for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member of the [BP_ERROR_RESOLUTION_INFO](../vs140/bp_error_resolution_info.md) structure. Passed as a parameter to the [EnumErrorBreakpoints](../vs140/idebugpendingbreakpoint2--enumerrorbreakpoints.md) method.  
  
 A breakpoint error type is composed of a type and a severity. This means that a breakpoint error type is never just a type (for example, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>,) or a severity (for example, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) by itself. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> provide predefined values for general warning and error breakpoints.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [BP_ERROR_RESOLUTION_INFO](../vs140/bp_error_resolution_info.md)   
 [EnumErrorBreakpoints](../vs140/idebugpendingbreakpoint2--enumerrorbreakpoints.md)