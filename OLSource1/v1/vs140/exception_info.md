---
title: "EXCEPTION_INFO"
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
  - "EXCEPTION_INFO"
helpviewer_keywords: 
  - "EXCEPTION_INFO structure"
ms.assetid: d046957a-b97d-420b-b46b-c67cbaef709e
caps.latest.revision: 14
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# EXCEPTION_INFO
Describes an exception or run-time error thrown by the program being debugged.  
  
## Syntax  
  
```cpp#  
typedef struct tagEXCEPTION_INFO {   
   IDebugProgram2* pProgram;  
   BSTR            bstrProgramName;  
   BSTR            bstrExceptionName;  
   DWORD           dwCode;  
   EXCEPTION_STATE dwState;  
   GUID            guidType;  
} EXCEPTION_INFO;  
```  
  
```c#  
public struct EXCEPTION_INFO {   
   public IDebugProgram2 pProgram;  
   public string         bstrProgramName;  
   public string         bstrExceptionName;  
   public uint           dwCode;  
   public uint           dwState;  
   public Guid           guidType;  
};  
```  
  
## Members  
 pProgram  
 The [IDebugProgram2](../vs140/idebugprogram2.md) object that represents the program in which the exception occurred.  
  
 bstrProgramName  
 The name of the program in which the exception occurred.  
  
 bstrExceptionName  
 The name of the exception.  
  
 dwCode  
 The identification code for the exception or run-time error.  
  
 dwState  
 A value from the [EXCEPTION_STATE](../vs140/exception_state.md) enumeration that defines the state of the exception.  
  
 guidType  
 The GUID language identifier, either `guidLang` or `guidEng`.  
  
## Remarks  
 This structure is passed as a parameter to the [IDebugEngine2::SetException](../vs140/idebugengine2--setexception.md) and the [IDebugEngine2::RemoveSetException](../vs140/idebugengine2--removesetexception.md) methods. This structure is also passed to the [IDebugExceptionEvent2::GetException](../vs140/idebugexceptionevent2--getexception.md) method to be filled in.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [EXCEPTION_STATE](../vs140/exception_state.md)   
 [IDebugProgram2](../vs140/idebugprogram2.md)   
 [IDebugEngine2::SetException](../vs140/idebugengine2--setexception.md)   
 [IDebugEngine2::RemoveSetException](../vs140/idebugengine2--removesetexception.md)   
 [IDebugExceptionEvent2::GetException](../vs140/idebugexceptionevent2--getexception.md)