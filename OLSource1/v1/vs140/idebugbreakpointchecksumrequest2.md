---
title: "IDebugBreakpointChecksumRequest2"
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
  - "IDebugBreakpointChecksumRequest2 interface"
ms.assetid: 9cfdbca5-052c-48e9-8411-e2e9e4065d00
caps.latest.revision: 11
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBreakpointChecksumRequest2
Represents a document checksum for a breakpoint request.  
  
## Syntax  
  
```  
IDebugBreakpointChecksumRequest2 : IUnknown  
```  
  
## Notes for Implementers  
 Implemented by the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Debug package and consumed by debug engines.  
  
## Methods  
 The following table shows the methods of `IDebugBreakpointChecksumRequest2`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugBreakpointChecksumRequest2::GetChecksum](../vs140/idebugbreakpointchecksumrequest2--getchecksum.md)|Retrieves the document checksum for a breakpoint request given the unique identifier of the checksum algorithm to use.|  
|[IDebugBreakpointChecksumRequest2::IsChecksumEnabled](../vs140/idebugbreakpointchecksumrequest2--ischecksumenabled.md)|Determines if the checksum is enabled for this document.|  
  
## Requirements  
 Header: Msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll