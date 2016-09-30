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
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] The port the calling process is running on.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in] An [AD_PROCESS_ID](../vs140/ad_process_id.md) structure holding the ID of the process that contains the program in question.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] GUID of the debug engine that the program is attached to (if any).  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [in] ID of the program for which to get the program node.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 [out] An [IDebugProgramNode2](../vs140/idebugprogramnode2.md) object representing the requested program node.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDebugProgramProvider2](../vs140/idebugprogramprovider2.md)   
 [PROVIDER_FLAGS](../vs140/provider_flags.md)   
 [AD_PROCESS_ID](../vs140/ad_process_id.md)   
 [IDebugDefaultPort2](../vs140/idebugdefaultport2.md)   
 [IDebugProgramNode2](../vs140/idebugprogramnode2.md)