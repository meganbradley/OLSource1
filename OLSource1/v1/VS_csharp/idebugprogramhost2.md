---
title: "IDebugProgramHost2"
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
  - "IDebugProgramHost2"
helpviewer_keywords: 
  - "IDebugProgramHost2 interface"
ms.assetid: 2c37b3aa-97a9-4665-8709-edd917f18cb1
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgramHost2
This interface provides host (process) information about a program.  
  
## Syntax  
  
```  
IDebugProgramHost2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine implements this interface on the same object as the [IDebugProgram2](../VS_csharp/idebugprogram2.md) interface to provide information about the hosting process. This is an optional interface.  
  
## Notes for Callers  
 Call [QueryInterface](../VS_csharp/queryinterface.md) on an `IDebugProgram2` interface to obtain this interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugProgramHost2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetHostName](../VS_csharp/idebugprogramhost2--gethostname.md)|Gets the title, friendly name, or file name of the hosting process of this program.|  
|[GetHostId](../VS_csharp/idebugprogramhost2--gethostid.md)|Gets the process identifier of the hosting process of this program.|  
|[GetHostMachineName](../VS_csharp/idebugprogramhost2--gethostmachinename.md)|Gets the name of the machine the hosting process of this program is running on.|  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../VS_csharp/core-interfaces.md)   
 [IDebugProgram2](../VS_csharp/idebugprogram2.md)