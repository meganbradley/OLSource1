---
title: "IDebugProgramProvider2::GetProviderProgramNode"
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
  - "IDebugProgramProvider2::GetProviderProgramNode"
helpviewer_keywords: 
  - "IDebugProgramProvider2::GetProviderProgramNode"
ms.assetid: e62e8e83-acbb-4c52-aedf-ffbd4670db29
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgramProvider2::GetProviderProgramNode
Retrieves the program node for a specific program.  
  
## Syntax  
  
```cpp  
HRESULT GetProviderProgramNode(  
   PROVIDER_FLAGS       Flags,  
   IDebugDefaultPort2*  pPort,  
   AD_PROCESS_ID        processId,  
   REFGUID              guidEngine,  
   UINT64               programId,  
   IDebugProgramNode2** ppProgramNode  
);  
```  
  
```c#  
int GetProviderProgramNode(  
   enum_PROVIDER_FLAGS    Flags,  
   IDebugDefaultPort2     pPort,  
   AD_PROCESS_ID          ProcessId,  
   ref Guid               guidEngine,  
   ulong                  programId,  
   out IDebugProgramNode2 ppProgramNode  
);  
```  
  
#### Parameters  
 `Flags`  
 [in] A combination of flags from the [PROVIDER_FLAGS](../vs140/provider_flags.md) enumeration. The following flags are typical for this call:  
  
|Flag|Description|  
|----------|-----------------|  
|`PFLAG_REMOTE_PORT`|Caller is running on remote machine.|  
|`PFLAG_DEBUGGEE`|Caller is currently being debugged (additional information about marshalling will be returned for each node).|  
|`PFLAG_ATTACHED_TO_DEBUGGEE`|Caller was attached to but not launched by the debugger.|  
  
 `pPort`  
 [in] The port the calling process is running on.  
  
 `processId`  
 [in] An [AD_PROCESS_ID](../vs140/ad_process_id.md) structure holding the ID of the process that contains the program in question.  
  
 `guidEngine`  
 [in] GUID of the debug engine that the program is attached to (if any).  
  
 `programId`  
 [in] ID of the program for which to get the program node.  
  
 `ppProgramNode`  
 [out] An [IDebugProgramNode2](../vs140/idebugprogramnode2.md) object representing the requested program node.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugProgramProvider2](../vs140/idebugprogramprovider2.md)   
 [PROVIDER_FLAGS](../vs140/provider_flags.md)   
 [AD_PROCESS_ID](../vs140/ad_process_id.md)   
 [IDebugDefaultPort2](../vs140/idebugdefaultport2.md)   
 [IDebugProgramNode2](../vs140/idebugprogramnode2.md)