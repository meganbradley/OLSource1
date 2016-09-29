---
title: "AD_PROCESS_ID"
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
  - "AD_PROCESS_ID"
helpviewer_keywords: 
  - "AD_PROCESS_ID union"
ms.assetid: 4cb40d12-2e92-4f09-83f4-689928bd65b3
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# AD_PROCESS_ID
Specifies the process ID, which may be either a system ID or a GUID.  
  
## Syntax  
  
```cpp#  
typedef struct _AD_PROCESS_ID {  
   AD_PROCESS_ID_TYPE ProcessIdType;  
   union {  
      DWORD dwProcessId;   
      GUID  guidProcessId;   
      DWORD dwUnused;   
   } ProcessId;  
} AD_PROCESS_ID;  
```  
  
```c#  
public struct AD_PROCESS_ID {  
   AD_PROCESS_ID_TYPE ProcessIdType;  
   DWORD              dwProcessId;   
   GUID               guidProcessId;   
   DWORD              dwUnused;   
};  
```  
  
## Members  
 `ProcessIdType`  
 A value from the [AD_PROCESS_ID_TYPE](../VS_csharp/ad_process_id_type.md) enumeration specifying how to interpret the `ProcessId` union (or, for managed code, which member of the structure to access).  
  
 dwProcessId  
 The process ID as a value from the system.  
  
 guidProcessId  
 The process ID as a GUID.  
  
 dwUnused  
 Padding.  
  
## Remarks  
 This structure is passed to the following methods:  
  
-   [IDebugProgramProvider2::GetProviderProgramNode](../VS_csharp/idebugprogramprovider2--getproviderprogramnode.md)  
  
-   [IDebugProgramProvider2::WatchForProviderEvents](../VS_csharp/idebugprogramprovider2--watchforproviderevents.md)  
  
-   [IDebugProgramProvider2::GetProviderProcessData](../VS_csharp/idebugprogramprovider2--getproviderprocessdata.md)  
  
-   [IDebugPort2::GetProcess](../VS_csharp/idebugport2--getprocess.md)  
  
 And is returned from the following methods:  
  
-   [IDebugProcess2::GetPhysicalProcessId](../VS_csharp/idebugprocess2--getphysicalprocessid.md)  
  
-   [IDebugProgramHost2::GetHostId](../VS_csharp/idebugprogramhost2--gethostid.md)  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../VS_csharp/structures-and-unions.md)   
 [GetProcess](../VS_csharp/idebugport2--getprocess.md)   
 [PROCESS_INFO](../VS_csharp/process_info.md)   
 [AD_PROCESS_ID_TYPE](../VS_csharp/ad_process_id_type.md)   
 [GetPhysicalProcessId](../VS_csharp/idebugprocess2--getphysicalprocessid.md)   
 [GetHostId](../VS_csharp/idebugprogramhost2--gethostid.md)   
 [IDebugProgramProvider2::GetProviderProgramNode](../VS_csharp/idebugprogramprovider2--getproviderprogramnode.md)   
 [IDebugProgramProvider2::WatchForProviderEvents](../VS_csharp/idebugprogramprovider2--watchforproviderevents.md)   
 [IDebugProgramProvider2::GetProviderProcessData](../VS_csharp/idebugprogramprovider2--getproviderprocessdata.md)