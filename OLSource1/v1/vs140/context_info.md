---
title: "CONTEXT_INFO"
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
  - "CONTEXT_INFO"
helpviewer_keywords: 
  - "CONTEXT_INFO structure"
ms.assetid: 6b513f4e-e7b0-4969-adf0-2205ccc1e09b
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# CONTEXT_INFO
This structure describes a memory context or code context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 dwFields  
 A combination of flags from he [CONTEXT_INFO_FIELDS](../vs140/context_info_fields.md) enumeration that specifies which fields are filled out**.**  
  
 bstrModuleUrl  
 The name of the module where the context is located.  
  
 bstrFunction  
 The function name where the context is located.  
  
 posFunctionOffset  
 A [TEXT_POSITION](../vs140/text_position.md) structure that identifies the line and column offset of the function associated with the code context.  
  
 bstrAddress  
 The address in code where the given context is located.  
  
 bstrAddressOffset  
 The offset of the address in code where the given context is located.  
  
 bstrAddressAbsolute  
 The absolute address in memory where the given context is located.  
  
## Remarks  
 This structure is returned from a call to the [GetInfo](../vs140/idebugmemorycontext2--getinfo.md) method.  
  
 A typical use for this structure is in support of a **Memory** debug window.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [GetInfo](../vs140/idebugmemorycontext2--getinfo.md)   
 [CONTEXT_INFO_FIELDS](../vs140/context_info_fields.md)   
 [TEXT_POSITION](../vs140/text_position.md)