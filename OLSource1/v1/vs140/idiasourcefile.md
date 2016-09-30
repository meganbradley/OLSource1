---
title: "IDiaSourceFile"
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
  - "IDiaSourceFile interface"
ms.assetid: 6e9be757-797f-4960-ba62-c14092620bbd
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSourceFile
Represents a source file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Methods in Vtable Order  
 The following table shows the methods of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaSourceFile::get_uniqueId](../vs140/idiasourcefile--get_uniqueid.md)|Retrieves a simple integer key value that is unique for this image.|  
|[IDiaSourceFile::get_fileName](../vs140/idiasourcefile--get_filename.md)|Retrieves the source file name.|  
|[IDiaSourceFile::get_checksumType](../vs140/idiasourcefile--get_checksumtype.md)|Retrieves the checksum type.|  
|[IDiaSourceFile::get_compilands](../vs140/idiasourcefile--get_compilands.md)|Retrieves an enumerator of the compilands with line numbers referencing this file.|  
|[IDiaSourceFile::get_checksum](../vs140/idiasourcefile--get_checksum.md)|Retrieves the checksum bytes.|  
  
## Remarks  
  
## Notes for Callers  
 Obtain this interface by calling the [IDiaEnumSourceFiles::Item](../vs140/idiaenumsourcefiles--item.md) or [IDiaEnumSourceFiles::Next](../vs140/idiaenumsourcefiles--next.md) methods. See the example for details.  
  
## Example  
 This function displays the names of all source files contributing to the specified table.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../vs140/interfaces--debug-interface-access-sdk-.md)   
 [IDiaEnumSourceFiles::Item](../vs140/idiaenumsourcefiles--item.md)   
 [IDiaEnumSourceFiles::Next](../vs140/idiaenumsourcefiles--next.md)   
 [IDiaLineNumber::get_sourceFile](../vs140/idialinenumber--get_sourcefile.md)   
 [IDiaSession::findFileById](../vs140/idiasession--findfilebyid.md)   
 [IDiaSession::findLines](../vs140/idiasession--findlines.md)   
 [IDiaSession::findLinesByLinenum](../vs140/idiasession--findlinesbylinenum.md)