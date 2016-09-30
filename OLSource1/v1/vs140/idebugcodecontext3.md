---
title: "IDebugCodeContext3"
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
  - "IDebugCodeContext3 interface"
ms.assetid: 524eb882-0ad5-4bfb-95eb-eb3abb3d0237
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugCodeContext3
Extends the [IDebugCodeContext2](../vs140/idebugcodecontext2.md) interface to enable the retrieval of module and process interfaces.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Notes for Implementers  
 Implemented by debug engines and consumed by the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Debug package.  
  
## Methods  
 In addition to the methods on the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface, this interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugCodeContext3::GetModule](../vs140/idebugcodecontext3--getmodule.md)|Retrieves a reference to the interface of the debug module.|  
|[IDebugCodeContext3::GetProcess](../vs140/idebugcodecontext3--getprocess.md)|Retrieves a reference to the interface of the debug process.|  
  
## Remarks  
 This is an optional interface which generally does not have to be implemented.  
  
## Requirements  
 Header: Msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll