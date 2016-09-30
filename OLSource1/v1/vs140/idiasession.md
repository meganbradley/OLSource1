---
title: "IDiaSession"
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
  - "IDiaSession interface"
ms.assetid: 69dab9bf-2c68-4f70-9678-3b50fba3e6fa
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSession
Provides a query context for debug symbols.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Methods  
 The following table shows the methods of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaSession::get_loadAddress](../vs140/idiasession--get_loadaddress.md)|Retrieves the load address for the executable file that corresponds to the symbols in this symbol store. This is the same value that was passed to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method.|  
|[IDiaSession::put_loadAddress](../vs140/idiasession--put_loadaddress.md)|Sets the load address for the executable file that corresponds to the symbols in this symbol store. **Note:**  It is important to call this method when you get an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object and before you start using the object.|  
|[IDiaSession::get_globalScope](../vs140/idiasession--get_globalscope.md)|Retrieves a reference to the global scope.|  
|[IDiaSession::getEnumTables](../vs140/idiasession--getenumtables.md)|Retrieves an enumerator for all tables contained in the symbol store.|  
|[IDiaSession::getSymbolsByAddr](../vs140/idiasession--getsymbolsbyaddr.md)|Retrieves an enumerator for all named symbols at static locations.|  
|[IDiaSession::findChildren](../vs140/idiasession--findchildren.md)|Retrieves all children of a specified parent identifier that match the name and symbol type.|  
|[IDiaSession::findSymbolByAddr](../vs140/idiasession--findsymbolbyaddr.md)|Retrieves a specified symbol type that contains, or is closest to, a specified address.|  
|[IDiaSession::findSymbolByRVA](../vs140/idiasession--findsymbolbyrva.md)|Retrieves a specified symbol type that contains, or is closest to, a specified relative virtual address (RVA).|  
|[IDiaSession::findSymbolByVA](../vs140/idiasession--findsymbolbyva.md)|Retrieves a specified symbol type that contains, or is closest to, a specified virtual address (VA).|  
|[IDiaSession::findSymbolByToken](../vs140/idiasession--findsymbolbytoken.md)|Retrieves the symbol that contains a specified metadata token.|  
|[IDiaSession::symsAreEquiv](../vs140/idiasession--symsareequiv.md)|Checks to see if two symbols are equivalent.|  
|[IDiaSession::symbolById](../vs140/idiasession--symbolbyid.md)|Retrieves a symbol by its unique identifier.|  
|[IDiaSession::findSymbolByRVAEx](../vs140/idiasession--findsymbolbyrvaex.md)|Retrieves a specified symbol type that contains, or is closest to, a specified relative virtual address and offset.|  
|[IDiaSession::findSymbolByVAEx](../vs140/idiasession--findsymbolbyvaex.md)|Retrieves a specified symbol type that contains, or is closest to, a specified virtual address and offset.|  
|[IDiaSession::findFile](../vs140/idiasession--findfile.md)|Retrieves a source file by compiland and name.|  
|[IDiaSession::findFileById](../vs140/idiasession--findfilebyid.md)|Retrieves a source file by source file identifier.|  
|[IDiaSession::findLines](../vs140/idiasession--findlines.md)|Retrieves line numbers within a specified compiland and source file identifier.|  
|[IDiaSession::findLinesByAddr](../vs140/idiasession--findlinesbyaddr.md)|Retrieves the lines in a specified compiland that contain a specified address.|  
|[IDiaSession::findLinesByRVA](../vs140/idiasession--findlinesbyrva.md)|Retrieves the lines in a specified compiland that contain a specified relative virtual address.|  
|[IDiaSession::findLinesByVA](../vs140/idiasession--findlinesbyva.md)|Finds the line number information for lines contained in a specified address range.|  
|[IDiaSession::findLinesByLinenum](../vs140/idiasession--findlinesbylinenum.md)|Retrieves the lines in a specified compiland by source file and line number.|  
|[IDiaSession::findInjectedSource](../vs140/idiasession--findinjectedsource.md)|Retrieves a source that has been placed into the symbol store by attribute providers or other components of the compilation process.|  
|[IDiaSession::getEnumDebugStreams](../vs140/idiasession--getenumdebugstreams.md)|Retrieves an enumerated sequence of debug data streams.|  
|[findInlineFramesByAddr](../vs140/idiasession--findinlineframesbyaddr.md)|Retrieves an enumeration that allows a client to iterate through all of the inline frames on a given address.|  
|[findInlineFramesByRVA](../vs140/idiasession--findinlineframesbyrva.md)|Retrieves an enumeration that allows a client to iterate through all of the inline frames on a specified relative virtual address (RVA).|  
|[findInlineFramesByVA](../vs140/idiasession--findinlineframesbyva.md)|Retrieves an enumeration that allows a client to iterate through all of the inline frames on a specified virtual address (VA).|  
|[findInlineeLines](../vs140/idiasession--findinlineelines.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, by the specified parent symbol.|  
|[findInlineeLinesByAddr](../vs140/idiasession--findinlineelinesbyaddr.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, by the specified parent symbol and are contained within the specified address range.|  
|[findInlineeLinesByRVA](../vs140/idiasession--findinlineelinesbyrva.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, by the specified parent symbol and are contained within the specified relative virtual address (RVA).|  
|[findInlineeLinesByVA](../vs140/idiasession--findinlineelinesbyva.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, by the specified parent symbol and are contained within the specified virtual address (VA).|  
|[findInlineeLinesByLinenum](../vs140/idiasession--findinlineelinesbylinenum.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, in the specified source file and line number.|  
|[findInlineesByName](../vs140/idiasession--findinlineesbyname.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all inlined functions that match a specified name.|  
|[findSymbolsForAcceleratorPointerTag](../vs140/idiasession--findsymbolsforacceleratorpointertag.md)|Returns an enumeration of symbols for the variable that the specified tag value corresponds to in the parent Accelerator stub function.|  
|[findSymbolsByRVAForAcceleratorPointerTag](../vs140/idiasession--findsymbolsbyrvaforacceleratorpointertag.md)|Given a corresponding tag value, this method returns an enumeration of symbols that are contained in a specified parent Accelerator stub function at a specified relative virtual address.|  
|[findAcceleratorInlineesByName](../vs140/idiasession--findacceleratorinlineesbyname.md)|Returns an enumeration of symbols for inline frames corresponding to the specified inline function name.|  
|[findAcceleratorInlineesByLinenum](../vs140/idiasession--findacceleratorinlineesbylinenum.md)|Returns an enumeration of symbols for inline frames that correspond to the specified source location.|  
  
## Remarks  
 It is important to call the [IDiaSession::put_loadAddress](../vs140/idiasession--put_loadaddress.md) method after creating the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object — and the value passed to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method must be non-zero — for any virtual address (VA) properties of symbols to be accessible. The load address comes from whatever program loaded the executable being debugged. For example, you can call the Win32 function <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to retrieve the load address for the executable, given a handle to the executable.  
  
## Example  
 This example shows how to obtain the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> interface as part of a general initialization of the DIA SDK.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../vs140/interfaces--debug-interface-access-sdk-.md)   
 [Overview](../vs140/overview--debug-interface-access-sdk-.md)   
 [Exe](../vs140/exe.md)   
 [IDiaAddressMap](../vs140/idiaaddressmap.md)   
 [IDiaDataSource](../vs140/idiadatasource.md)   
 [IDiaDataSource::openSession](../vs140/idiadatasource--opensession.md)   
 [IDiaSymbol::findChildren](../vs140/idiasymbol--findchildren.md)   
 [Querying the .Pdb File](../vs140/querying-the-.pdb-file.md)