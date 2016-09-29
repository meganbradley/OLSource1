---
title: "PROVIDER_FIELDS"
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
  - "PROVIDER_FIELDS"
helpviewer_keywords: 
  - "PROVIDER_FIELDS enumeration"
ms.assetid: 39631545-2b0e-45b4-978b-d63656484b02
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# PROVIDER_FIELDS
Specifies properties associated with a program provider.  
  
## Syntax  
  
```cpp#  
enum enum_PROVIDER_FIELDS {  
   PFIELD_PROGRAM_NODES       = 0x01,  
   PFIELD_IS_DEBUGGER_PRESENT = 0x02  
};  
typedef DWORD PROVIDER_FIELDS;  
```  
  
```c#  
public enum enum_PROVIDER_FIELDS {  
   PFIELD_PROGRAM_NODES       = 0x01,  
   PFIELD_IS_DEBUGGER_PRESENT = 0x02  
};  
```  
  
## Members  
 PFIELD_PROGRAM_NODES  
 The `ProgramNodes` field is valid.  
  
 PFIELD_IS_DEBUGGER_PRESENT  
 The `fIsDebuggerPresent` field is valid.  
  
## Remarks  
 These values are returned in the `Fields` member of the [PROVIDER_PROCESS_DATA](../VS_csharp/provider_process_data.md) structure to indicate which fields of the structure were explicitly filled in.  
  
 These values can be combined with a bitwise `OR`.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../VS_csharp/enumerations--visual-studio-debugging-.md)   
 [PROVIDER_PROCESS_DATA](../VS_csharp/provider_process_data.md)