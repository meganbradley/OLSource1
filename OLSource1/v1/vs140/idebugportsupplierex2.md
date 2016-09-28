---
title: "IDebugPortSupplierEx2"
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
  - "IDebugPortSupplierEx2 interface"
ms.assetid: dae0050a-a50a-4f35-bfbd-e538f537b20f
caps.latest.revision: 8
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPortSupplierEx2
Provides support for a port supplier to select and interact with a core server.  
  
## Syntax  
  
```  
IDebugPortSupplierEx2 : IUnknown  
```  
  
## Notes for Implementers  
 A custom port supplier implements this interface so that it can select the core server to use.  
  
## Methods  
 The following table shows the methods of **IDebugPortSupplierEx2**.  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugPortSupplierEx2::SetServer](../vs140/idebugportsupplierex2--setserver.md)|Sets the core server for the port supplier.|  
  
## Requirements  
 Header: Portpriv.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../vs140/core-interfaces.md)   
 [IDebugPortSupplier2](../vs140/idebugportsupplier2.md)   
 [IDebugPortSupplier3](../vs140/idebugportsupplier3.md)