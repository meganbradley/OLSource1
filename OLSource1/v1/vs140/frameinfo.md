---
title: "FRAMEINFO"
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
  - "FRAMEINFO"
helpviewer_keywords: 
  - "FRAMEINFO structure"
ms.assetid: 95001b89-dddb-45bb-889d-8327994e38a5
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# FRAMEINFO
Describes a stack frame.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 m_dwValidFields  
 A combination of flags from the [FRAMEINFO_FLAGS](../vs140/frameinfo_flags.md) enumeration that specifies which fields are filled in.  
  
 m_bstrFuncName  
 The function name associated with the stack frame.  
  
 m_bstrReturnType  
 The return type associated with the stack frame.  
  
 m_bstrArgs  
 The arguments to the function associated with the stack frame.  
  
 m_bstrLanguage  
 The language in which the function is implemented.  
  
 m_bstrModule  
 The module name associated with the stack frame.  
  
 m_addrMin  
 The minimum physical stack address.  
  
 m_addrMAX  
 The maximum physical stack address.  
  
 m_pFrame  
 The [IDebugStackFrame2](../vs140/idebugstackframe2.md) object that represents this stack frame.  
  
 m_pFrame  
 The [IDebugModule2](../vs140/idebugmodule2.md) object that represents the module that contains this stack frame.  
  
 m_fHasDebugInfo  
 Non-zero (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) if debug information exists in the given frame.  
  
 m_fHasDebugInfo  
 Non-zero (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) if the stack frame is associated with code that is no longer valid.  
  
 m_fHasDebugInfo  
 Non-zero (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) if the stack frame is annotated by the session debug manager (SDM).  
  
## Remarks  
 This structure is passed to the [IDebugStackFrame2::GetInfo](../vs140/idebugstackframe2--getinfo.md) method to be filled in. This structure is also contained in a list that is contained in the [IEnumDebugFrameInfo2](../vs140/ienumdebugframeinfo2.md) interface which, in turn, is returned from a call to the [IDebugThread2::EnumFrameInfo](../vs140/idebugthread2--enumframeinfo.md) method.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [FRAMEINFO_FLAGS](../vs140/frameinfo_flags.md)   
 [IDebugStackFrame2](../vs140/idebugstackframe2.md)   
 [IDebugModule2](../vs140/idebugmodule2.md)   
 [GetInfo](../vs140/idebugstackframe2--getinfo.md)   
 [IEnumDebugFrameInfo2](../vs140/ienumdebugframeinfo2.md)   
 [IDebugThread2::EnumFrameInfo](../vs140/idebugthread2--enumframeinfo.md)