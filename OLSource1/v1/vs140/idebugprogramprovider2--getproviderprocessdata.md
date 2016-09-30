---
title: "IDebugProgramProvider2::GetProviderProcessData"
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
  - "IDebugProgramProvider2::GetProviderProcessData"
helpviewer_keywords: 
  - "IDebugProgramProvider2::GetProviderProcessData"
ms.assetid: 90cf7b7f-53d2-487e-b793-94501a6e24dd
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgramProvider2::GetProviderProcessData
Retrieves a list of running programs from a specified process.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A combination of flags from the [PROVIDER_FLAGS](../vs140/provider_flags.md) enumeration. The following flags are typical for this call:  
  
|Flag|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Caller is running on remote machine.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Caller is currently being debugged (additional information about marshalling will be returned for each node).|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Caller was attached to but not launched by the debugger.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Caller is asking for a list of program nodes to be returned.|  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in] The port the calling process is running on.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] An [AD_PROCESS_ID](../vs140/ad_process_id.md) structure holding the ID of the process that contains the program in question.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [in] An array of GUIDs for debug engines assigned to debug this process (these will be used to filter the programs that are actually returned based on what the supplied engines support; if no engines are specified, then all programs will be returned).  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 [out] A [PROVIDER_PROCESS_DATA](../vs140/provider_process_data.md) structure that is filled in with the requested information.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 This method is normally called by a process to obtain a list of programs running in that process. The returned information is a list of [IDebugProgramNode2](../vs140/idebugprogramnode2.md) objects.  
  
## See Also  
 [IDebugProgramProvider2](../vs140/idebugprogramprovider2.md)   
 [IDebugDefaultPort2](../vs140/idebugdefaultport2.md)   
 [AD_PROCESS_ID](../vs140/ad_process_id.md)   
 [CONST_GUID_ARRAY](../vs140/const_guid_array.md)   
 [PROVIDER_FLAGS](../vs140/provider_flags.md)   
 [PROVIDER_PROCESS_DATA](../vs140/provider_process_data.md)   
 [IDebugProgramNode2](../vs140/idebugprogramnode2.md)