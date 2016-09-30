---
title: "EncUnavailableReason"
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
  - "EncUnavailableReason"
helpviewer_keywords: 
  - "EncUnavailableReason enumeration"
ms.assetid: c10aa4c0-d7e0-4de1-b8ff-7e050985eb12
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# EncUnavailableReason
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> Represents the reasons that **Edit and Continue** is not available.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 ENCUN_NONE  
 No specific reason why Edit and Continue is not available.  
  
 ENCUN_INTEROP  
 Edit and Continue is not available during an InterOp call.  
  
 ENCUN_SQLCLR  
 Edit and Continue is not available during an SQL procedure call that uses the Common Language Runtime (CLR).  
  
 ENCUN_MINIDUMP  
 Edit and Continue is not available while processing a mini-dump.  
  
 ENCUN_EMBEDDED  
 Edit and Continue is not available when processing embedded code.  
  
 ENCUN_ATTACH  
 Edit and Continue is not available because the session was attached to, not launched by, the debugger.  
  
 ENCUN_WIN64  
 Edit and Continue is not available while processing 64-bit Windows code.  
  
## Remarks  
 This enumeration is for internal use only by [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. The [IDebugProcess3::GetENCAvailableState](../vs140/idebugprocess3--getencavailablestate.md) and [IDebugProcess3::DisableENC](../vs140/idebugprocess3--disableenc.md) methods as implemented by a custom port supplier should always return <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Requirements  
 Header: msdbg.idl  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [IDebugProcess3::DisableENC](../vs140/idebugprocess3--disableenc.md)   
 [IDebugProcess3::GetENCAvailableState](../vs140/idebugprocess3--getencavailablestate.md)