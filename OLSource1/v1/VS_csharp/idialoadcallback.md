---
title: "IDiaLoadCallback"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaLoadCallback interface"
ms.assetid: 2f18c64c-2cf0-43fc-a447-21e82702ca2a
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaLoadCallback
Receives callbacks from the DIA symbol locating procedure, thus enabling a user interface to report on the progress of the location attempt.  
  
## Syntax  
  
```  
IDiaLoadCallback : IUnknown  
```  
  
## Methods in Vtable Order  
 The following methods are exposed by this interface:  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaLoadCallback::NotifyDebugDir](../VS_csharp/idialoadcallback--notifydebugdir.md)|Called when a debug directory was found in the .exe file.|  
|[IDiaLoadCallback::NotifyOpenDBG](../VS_csharp/idialoadcallback--notifyopendbg.md)|Called when a candidate .dbg file has been opened.|  
|[IDiaLoadCallback::NotifyOpenPDB](../VS_csharp/idialoadcallback--notifyopenpdb.md)|Called when a candidate .pdb file has been opened.|  
|[IDiaLoadCallback::RestrictRegistryAccess](../VS_csharp/idialoadcallback--restrictregistryaccess.md)|Determines if registry queries can be used to locate symbol search paths.|  
|[IDiaLoadCallback::RestrictSymbolServerAccess](../VS_csharp/idialoadcallback--restrictsymbolserveraccess.md)|Determines if access is allowed to a symbol server to resolve symbols.|  
  
## Remarks  
 The client application implements this interface and provides a reference to it in the call to the [IDiaDataSource::loadDataForExe](../VS_csharp/idiadatasource--loaddataforexe.md) method.  
  
 For additional restrictions that can be imposed on a load process, see the [IDiaLoadCallback2](../VS_csharp/idialoadcallback2.md) interface.  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../VS_csharp/interfaces--debug-interface-access-sdk-.md)   
 [IDiaDataSource::loadDataForExe](../VS_csharp/idiadatasource--loaddataforexe.md)   
 [IDiaReadExeAtOffsetCallback](../VS_csharp/idiareadexeatoffsetcallback.md)   
 [IDiaReadExeAtRVACallback](../VS_csharp/idiareadexeatrvacallback.md)   
 [IDiaLoadCallback2](../VS_csharp/idialoadcallback2.md)