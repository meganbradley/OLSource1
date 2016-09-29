---
title: "PROCESS_INFO"
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
  - "PROCESS_INFO"
helpviewer_keywords: 
  - "PROCESS_INFO structure"
ms.assetid: 260c33cc-a05e-4645-84b6-536d0b3b0537
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# PROCESS_INFO
Contains information about a process.  
  
## Syntax  
  
```cpp#  
typedef struct tagPROCESS_INFO {   
   PROCESS_INFO_FIELDS Fields;  
   BSTR                bstrFileName;  
   BSTR                bstrBaseName;  
   BSTR                bstrTitle;  
   AD_PROCESS_ID       ProcessId;  
   DWORD               dwSessionId;  
   BSTR                bstrAttachedSessionName;  
   FILETIME            CreationTime;  
   PROCESS_INFO_FLAGS  Flags;  
} PROCESS_INFO;  
```  
  
```c#  
public struct PROCESS_INFO {   
   public uint          Fields;  
   public string        bstrFileName;  
   public string        bstrBaseName;  
   public string        bstrTitle;  
   public AD_PROCESS_ID ProcessId;  
   public uint          dwSessionId;  
   public string        bstrAttachedSessionName;  
   public FILETIME      CreationTime;  
   public uint          Flags;  
};  
```  
  
## Members  
 Fields  
 A combination of flags from the [PROCESS_INFO_FIELDS](../vs140/process_info_fields.md) enumeration that specify which fields are filled out.  
  
 bstrFileName  
 The full path name of the process. Equivalent to calling the [IDebugProcess2::GetName](../vs140/idebugprocess2--getname.md) method with the parameter `GN_FILENAME`.  
  
 bstrBaseName  
 The file name and extension of the process. Equivalent to calling the `IDebugProcess2::Getname` method with the parameter `GN_BASENAME`.  
  
 bstrTitle  
 The title of the process, if one exists. Equivalent to calling the `IDebugProcess2::Getname` method with the parameter `GN_TITLE`.  
  
 ProcessId  
 The [AD_PROCESS_ID](../vs140/ad_process_id.md) structure that identifies the process. Equivalent to calling the [IDebugProcess2::GetPhysicalProcessId](../vs140/idebugprocess2--getphysicalprocessid.md) method.  
  
 dwSessionId  
 The identifier of the debug session that this process is running in.  
  
 bstrAttachedSessionName  
 The attached session name. Equivalent to calling the [IDebugProcess2::GetAttachedSessionName](../vs140/idebugprocess2--getattachedsessionname.md) method.  
  
 CreationTime  
 The time the process was created.  
  
 Flags  
 A combination of flags from the [PROCESS_INFO_FLAGS](../vs140/process_info_flags.md) enumeration that specify properties of the process.  
  
## Remarks  
 This structure is passed to the [GetInfo](../vs140/idebugprocess2--getinfo.md) method where it is filled in.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [PROCESS_INFO_FIELDS](../vs140/process_info_fields.md)   
 [PROCESS_INFO_FLAGS](../vs140/process_info_flags.md)   
 [GetInfo](../vs140/idebugprocess2--getinfo.md)   
 [IDebugProcess2::GetName](../vs140/idebugprocess2--getname.md)   
 [IDebugProcess2::GetPhysicalProcessId](../vs140/idebugprocess2--getphysicalprocessid.md)   
 [IDebugProcess2::GetAttachedSessionName](../vs140/idebugprocess2--getattachedsessionname.md)