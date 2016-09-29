---
title: "IDebugProgramNodeAttach2"
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
  - "IDebugProgramNodeAttach2"
helpviewer_keywords: 
  - "IDebugProgramNodeAttach2 interface"
ms.assetid: 46b37ac9-a026-4ad3-997b-f19e2f8deb73
caps.latest.revision: 7
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgramNodeAttach2
Allows a program node to be notified of an attempt to attach to the associated program.  
  
## Syntax  
  
```  
IDebugProgramNodeAttach2 : IUnknown  
```  
  
## Notes for Implementers  
 This interface is implemented on the same class that implements the [IDebugProgramNode2](../vs140/idebugprogramnode2.md) interface in order to receive notification of an attach operation and to provide an opportunity to cancel the attach operation.  
  
## Notes for Callers  
 Obtain this interface by calling the `QueryInterface` method in an [IDebugProgramNode2](../vs140/idebugprogramnode2.md) object. The [IDebugProgramNodeAttach2::OnAttach](../vs140/idebugprogramnodeattach2--onattach.md) method must be called before the [IDebugEngine2::Attach](../vs140/idebugengine2--attach.md) method to give the program node a chance to stop the attach process.  
  
## Methods in Vtable Order  
 This interface implements the following method:  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugProgramNodeAttach2::OnAttach](../vs140/idebugprogramnodeattach2--onattach.md)|Attaches to the associated program or defers the attach process to the [IDebugEngine2::Attach](../vs140/idebugengine2--attach.md) method.|  
  
## Remarks  
 This interface is the preferred alternative to the deprecated [IDebugProgramNode2::Attach_V7](../vs140/idebugprogramnode2--attach_v7.md) method. All debug engines are always loaded with the `CoCreateInstance` function, that is, they are instantiated outside the address space of the program being debugged.  
  
 If a previous implementation of the `IDebugProgramNode2::Attach_V7` method was simply setting the `GUID` of the program being debugged, then only the [IDebugProgramNodeAttach2::OnAttach](../vs140/idebugprogramnodeattach2--onattach.md) method needs to be implemented.  
  
 If a previous implementation of the `IDebugProgramNode2::Attach_V7` method used the callback interface that was provided, then that functionality needs to be moved to an implementation of the [IDebugEngine2::Attach](../vs140/idebugengine2--attach.md) method and the `IDebugProgramNodeAttach2` interface does not have to be implemented.  
  
## Requirements  
 Header: Msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../vs140/core-interfaces.md)   
 [IDebugProgramNode2](../vs140/idebugprogramnode2.md)   
 [IDebugEngine2::Attach](../vs140/idebugengine2--attach.md)   
 [IDebugProgramNode2::Attach_V7](../vs140/idebugprogramnode2--attach_v7.md)