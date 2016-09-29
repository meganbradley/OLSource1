---
title: "Interfaces (Debug Interface Access SDK)"
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
  - "interfaces [DIA SDK]"
  - "DIA SDK, interfaces"
ms.assetid: 62aee7c3-d314-4272-a32b-b2818f32fab8
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Interfaces (Debug Interface Access SDK)
Methods are listed alphabetically under each interface in the table of contents and on the interface page in Vtable order.  
  
## In This Section  
 [IDiaAddressMap](../vs140/idiaaddressmap.md)  
 Provides control over how the DIA SDK computes virtual and relative virtual addresses for debug objects.  
  
 [IDiaDataSource](../vs140/idiadatasource.md)  
 Initiates access to a source of debugging symbols.  
  
 [IDiaEnumDebugStreamData](../vs140/idiaenumdebugstreamdata.md)  
 Provides access to the records in a debug data stream.  
  
 [IDiaEnumDebugStreams](../vs140/idiaenumdebugstreams.md)  
 Enumerates the various debug streams contained in the data source.  
  
 [IDiaEnumFrameData](../vs140/idiaenumframedata.md)  
 Enumerates the various frame data elements contained in the data source.  
  
 [IDiaEnumInjectedSources](../vs140/idiaenuminjectedsources.md)  
 Enumerate the various injected sources contained in the data source.  
  
 [IDiaEnumLineNumbers](../vs140/idiaenumlinenumbers.md)  
 Enumerates the various line numbers contained in the data source.  
  
 [IDiaEnumSectionContribs](../vs140/idiaenumsectioncontribs.md)  
 Enumerates the various section contributions contained in the data source.  
  
 [IDiaEnumSegments](../vs140/idiaenumsegments.md)  
 Enumerates the various segments contained in the data source.  
  
 [IDiaEnumSourceFiles](../vs140/idiaenumsourcefiles.md)  
 Enumerates the various source files contained in the data source.  
  
 [IDiaEnumStackFrames](../vs140/idiaenumstackframes.md)  
 Enumerates the various stack frames available.  
  
 [IDiaEnumSymbols](../vs140/idiaenumsymbols.md)  
 Enumerates the various symbols contained in the data source.  
  
 [IDiaEnumSymbolsByAddr](../vs140/idiaenumsymbolsbyaddr.md)  
 Enumerates by address the various symbols contained in the data source.  
  
 [IDiaEnumTables](../vs140/idiaenumtables.md)  
 Enumerates the various tables contained in the data source.  
  
 [IDiaFrameData](../vs140/idiaframedata.md)  
 Exposes the details of a stack frame.  
  
 [IDiaImageData](../vs140/idiaimagedata.md)  
 Exposes the details of the base location and memory offsets of the module or image.  
  
 [IDiaInjectedSource](../vs140/idiainjectedsource.md)  
 Accesses the program source code stored in the DIA data source.  
  
 [IDiaLineNumber](../vs140/idialinenumber.md)  
 Accesses information that describes the process of mapping from a block of bytes of image text to a source file line number.  
  
 [IDiaLoadCallback](../vs140/idialoadcallback.md)  
 Receives callbacks from the DIA symbol locating procedure, thus enabling a user interface to report on the progress of the location attempt.  
  
 [IDiaLoadCallback2](../vs140/idialoadcallback2.md)  
 Receives callbacks from the DIA symbol locating procedure, allowing restrictions to be imposed on the locating process.  
  
 [IDiaPropertyStorage](../vs140/idiapropertystorage.md)  
 Allows you to read the persistent properties of a DIA property set.  
  
 [IDiaReadExeAtRVACallback](../vs140/idiareadexeatrvacallback.md)  
 Enables a client application to supply bytes of an executable file as specified by file position.  
  
 [IDiaReadExeAtOffsetCallback](../vs140/idiareadexeatoffsetcallback.md)  
 Enables a client application to supply bytes of an executable file as specified by a relative virtual address.  
  
 [IDiaSectionContrib](../vs140/idiasectioncontrib.md)  
 Retrieves data describing a section contribution, that is, a contiguous block of memory contributed to the image by a compiland.  
  
 [IDiaSegment](../vs140/idiasegment.md)  
 Maps data from the section number to segments of address space.  
  
 [IDiaSession](../vs140/idiasession.md)  
 Provides a query context for debug symbols.  
  
 [IDiaSourceFile](../vs140/idiasourcefile.md)  
 Represents a source file.  
  
 [IDiaStackFrame](../vs140/idiastackframe.md)  
 Exposes the properties of a stack frame.  
  
 [IDiaStackWalker](../vs140/idiastackwalker.md)  
 Provides methods to do a stack walk using the PDB file.  
  
 [IDiaStackWalkFrame](../vs140/idiastackwalkframe.md)  
 Maintains stack context between invocations of the [IDiaFrameData::execute](../vs140/idiaframedata--execute.md) method.  
  
 [IDiaStackWalkHelper](../vs140/idiastackwalkhelper.md)  
 Facilitates walking the stack using the program debug database (PDB) file.  
  
 [IDiaSymbol](../vs140/idiasymbol.md)  
 Describes the properties of a symbol instance.  
  
 [IDiaTable](../vs140/idiatable.md)  
 Enumerates a DIA data source table.  
  
## Related Sections  
 [Enumerations and Structures](../vs140/enumerations-and-structures.md)  
 Describes the enumerations and structures used by the various interfaces of the DIA SDK.  
  
 [Constants (Debug Interface Access SDK)](../vs140/constants--debug-interface-access-sdk-.md)  
 Describes the constants available in the DIA SDK.  
  
## See Also  
 [Reference](../vs140/debug-interface-access-sdk-reference.md)