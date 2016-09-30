---
title: "IDiaReadExeAtOffsetCallback"
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
  - "IDiaReadExeAtOffsetCallback interface"
ms.assetid: 3c961641-3ce3-4bc3-bd6e-a802fa3bec49
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaReadExeAtOffsetCallback
Enables a client application to supply bytes of an executable file as  specified by file position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Methods in Vtable Order  
 The following table shows the methods of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaReadExeAtOffsetCallback::ReadExecutableAt](../vs140/idiareadexeatoffsetcallback--readexecutableat.md)|Reads the specified number of bytes starting at the specified offset from an executable file.|  
  
## Remarks  
 The client application implements this interface in order to provide the bytes of the executable using an absolute offset into the executable's file. To use a relative virtual address, implement the [IDiaReadExeAtRVACallback](../vs140/idiareadexeatrvacallback.md) interface.  
  
## Notes for Callers  
 This method is implemented by the client application and passed to the [IDiaDataSource::loadDataForExe](../vs140/idiadatasource--loaddataforexe.md) method as an alternative method for reading the file.  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../vs140/interfaces--debug-interface-access-sdk-.md)   
 [IDiaDataSource::loadDataForExe](../vs140/idiadatasource--loaddataforexe.md)   
 [IDiaReadExeAtRVACallback](../vs140/idiareadexeatrvacallback.md)