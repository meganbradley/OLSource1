---
title: "IDebugDefaultPort2"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - IDebugDefaultPort2
helpviewer_keywords: 
  - IDebugDefaultPort2 interface
ms.assetid: 7b3452af-9a96-4c4c-9946-4339b72d3d7b
caps.latest.revision: 12
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugDefaultPort2
This interface provides several methods for accessing a port's server and notification facilities.  
  
## Syntax  
  
```  
IDebugDefaultPort2 : IDebugPort2  
```  
  
## Notes for Implementers  
 Visual Studio implements this interface to represent the debug port for accessing programs. A custom port supplier can also implement this interface if it handles remote debugging.  
  
## Notes for Callers  
 An argument to methods on the [IDebugProgramProvider2](../vs140/idebugprogramprovider2.md) interface supplies this interface. Calling [QueryInterface](../vs140/queryinterface.md) on an [IDebugPort2](../vs140/idebugport2.md) interface can also obtain this interface.  
  
## Methods in Vtable order  
 In addition to the methods defined in [IDebugPort2](../vs140/idebugport2.md), this interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[GetPortNotify](../vs140/idebugdefaultport2--getportnotify.md)|Gets the port notification interface from this port.|  
|[GetServer](../vs140/idebugdefaultport2--getserver.md)|Gets the interface to the server hosting this port.|  
|[QueryIsLocal](../vs140/idebugdefaultport2--queryislocal.md)|Determines whether this port is running on the local machine.|  
  
## Remarks  
 The name "`IDebugDefaultPort2`" is a bit of a misnomer, as it does not represent a default port. It could be called "IDebugPort3."  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugPort2](../vs140/idebugport2.md)   
 [IDebugProgramProvider2](../vs140/idebugprogramprovider2.md)