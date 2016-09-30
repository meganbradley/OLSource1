---
title: "IDebugProcessSecurity"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugProcessSecurity interface"
ms.assetid: 8a52ddca-bd99-49c0-9778-469dce7abd44
caps.latest.revision: 8
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProcessSecurity
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is implemented by a port supplier to warn the user that attaching to the process is unsafe.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Methods in Vtable Order  
 The following table shows the methods of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugProcessSecurity::GetUserName](../vs140/idebugprocesssecurity--getusername.md)|Gets the user name from the port supplier.|  
|[IDebugProcessSecurity::QueryCanSafelyAttach](../vs140/idebugprocesssecurity--querycansafelyattach.md)|Warns a user that attaching to the debugging process is unsafe.|  
  
## Remarks  
 Implement this interface to show a warning and allow the user to cancel if the process to which you are attaching can be considered unsafe.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Ports](../vs140/ports.md)   
 [Port Suppliers](../vs140/port-suppliers.md)   
 [Core Interfaces](../vs140/core-interfaces.md)   
 [IDebugProcess2](../vs140/idebugprocess2.md)