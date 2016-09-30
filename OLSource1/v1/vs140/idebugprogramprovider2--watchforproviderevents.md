---
title: "IDebugProgramProvider2::WatchForProviderEvents"
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
  - "IDebugProgramProvider2::WatchForProviderEvents"
helpviewer_keywords: 
  - "IDebugProgramProvider2::WatchForProviderEvents"
ms.assetid: 2eb93653-b5fb-45b6-b136-56008c5d25ef
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgramProvider2::WatchForProviderEvents
Allows the process to be notified of port events.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] A combination of flags from the [PROVIDER_FLAGS](../vs140/provider_flags.md) enumeration. The following flags are typical for this call:  
  
|Flag|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Caller is running on remote machine.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Caller is currently being debugged (additional information about marshalling is returned for each node).|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Caller was attached to but not launched by the debugger.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Caller wants to watch for events. If this flag is not set. then the callback event is removed and the caller no longer receives notifications.|  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] The port the calling process is running on.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [in] An [AD_PROCESS_ID](../vs140/ad_process_id.md) structure holding the ID of the process that contains the program in question.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 [in] An array of GUIDs of debug engines associated with the process.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 [in] GUID of the debug engine that launched this process (if any).  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 [in] An [IDebugPortNotify2](../vs140/idebugportnotify2.md) object that receives the event notifications.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 When a caller wants to remove an event handler that was established with a previous call to this method, the caller passes the same parameters as it did the first time but leaves off the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> flag.  
  
## Example  
 The following example shows how to implement this method for a **CDebugEngine** object that exposes the [IDebugProgramProvider2](../vs140/idebugprogramprovider2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugProgramProvider2](../vs140/idebugprogramprovider2.md)   
 [PROVIDER_FLAGS](../vs140/provider_flags.md)   
 [AD_PROCESS_ID](../vs140/ad_process_id.md)   
 [CONST_GUID_ARRAY](../vs140/const_guid_array.md)   
 [IDebugDefaultPort2](../vs140/idebugdefaultport2.md)   
 [IDebugPortNotify2](../vs140/idebugportnotify2.md)