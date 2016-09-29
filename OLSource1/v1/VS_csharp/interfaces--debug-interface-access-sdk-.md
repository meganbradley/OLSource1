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
 [IDiaAddressMap](../VS_csharp/idiaaddressmap.md)  
 Provides control over how the DIA SDK computes virtual and relative virtual addresses for debug objects.  
  
 [IDiaDataSource](../VS_csharp/idiadatasource.md)  
 Initiates access to a source of debugging symbols.  
  
 [IDiaEnumDebugStreamData](../VS_csharp/idiaenumdebugstreamdata.md)  
 Provides access to the records in a debug data stream.  
  
 [IDiaEnumDebugStreams](../VS_csharp/idiaenumdebugstreams.md)  
 Enumerates the various debug streams contained in the data source.  
  
 [IDiaEnumFrameData](../VS_csharp/idiaenumframedata.md)  
 Enumerates the various frame data elements contained in the data source.  
  
 [IDiaEnumInjectedSources](../VS_csharp/idiaenuminjectedsources.md)  
 Enumerate the various injected sources contained in the data source.  
  
 [IDiaEnumLineNumbers](../VS_csharp/idiaenumlinenumbers.md)  
 Enumerates the various line numbers contained in the data source.  
  
 [IDiaEnumSectionContribs](../VS_csharp/idiaenumsectioncontribs.md)  
 Enumerates the various section contributions contained in the data source.  
  
 [IDiaEnumSegments](../VS_csharp/idiaenumsegments.md)  
 Enumerates the various segments contained in the data source.  
  
 [IDiaEnumSourceFiles](../VS_csharp/idiaenumsourcefiles.md)  
 Enumerates the various source files contained in the data source.  
  
 [IDiaEnumStackFrames](../VS_csharp/idiaenumstackframes.md)  
 Enumerates the various stack frames available.  
  
 [IDiaEnumSymbols](../VS_csharp/idiaenumsymbols.md)  
 Enumerates the various symbols contained in the data source.  
  
 [IDiaEnumSymbolsByAddr](../VS_csharp/idiaenumsymbolsbyaddr.md)  
 Enumerates by address the various symbols contained in the data source.  
  
 [IDiaEnumTables](../VS_csharp/idiaenumtables.md)  
 Enumerates the various tables contained in the data source.  
  
 [IDiaFrameData](../VS_csharp/idiaframedata.md)  
 Exposes the details of a stack frame.  
  
 [IDiaImageData](../VS_csharp/idiaimagedata.md)  
 Exposes the details of the base location and memory offsets of the module or image.  
  
 [IDiaInjectedSource](../VS_csharp/idiainjectedsource.md)  
 Accesses the program source code stored in the DIA data source.  
  
 [IDiaLineNumber](../VS_csharp/idialinenumber.md)  
 Accesses information that describes the process of mapping from a block of bytes of image text to a source file line number.  
  
 [IDiaLoadCallback](../VS_csharp/idialoadcallback.md)  
 Receives callbacks from the DIA symbol locating procedure, thus enabling a user interface to report on the progress of the location attempt.  
  
 [IDiaLoadCallback2](../VS_csharp/idialoadcallback2.md)  
 Receives callbacks from the DIA symbol locating procedure, allowing restrictions to be imposed on the locating process.  
  
 [IDiaPropertyStorage](../VS_csharp/idiapropertystorage.md)  
 Allows you to read the persistent properties of a DIA property set.  
  
 [IDiaReadExeAtRVACallback](../VS_csharp/idiareadexeatrvacallback.md)  
 Enables a client application to supply bytes of an executable file as specified by file position.  
  
 [IDiaReadExeAtOffsetCallback](../VS_csharp/idiareadexeatoffsetcallback.md)  
 Enables a client application to supply bytes of an executable file as specified by a relative virtual address.  
  
 [IDiaSectionContrib](../VS_csharp/idiasectioncontrib.md)  
 Retrieves data describing a section contribution, that is, a contiguous block of memory contributed to the image by a compiland.  
  
 [IDiaSegment](../VS_csharp/idiasegment.md)  
 Maps data from the section number to segments of address space.  
  
 [IDiaSession](../VS_csharp/idiasession.md)  
 Provides a query context for debug symbols.  
  
 [IDiaSourceFile](../VS_csharp/idiasourcefile.md)  
 Represents a source file.  
  
 [IDiaStackFrame](../VS_csharp/idiastackframe.md)  
 Exposes the properties of a stack frame.  
  
 [IDiaStackWalker](../VS_csharp/idiastackwalker.md)  
 Provides methods to do a stack walk using the PDB file.  
  
 [IDiaStackWalkFrame](../VS_csharp/idiastackwalkframe.md)  
 Maintains stack context between invocations of the [IDiaFrameData::execute](../VS_csharp/idiaframedata--execute.md) method.  
  
 [IDiaStackWalkHelper](../VS_csharp/idiastackwalkhelper.md)  
 Facilitates walking the stack using the program debug database (PDB) file.  
  
 [IDiaSymbol](../VS_csharp/idiasymbol.md)  
 Describes the properties of a symbol instance.  
  
 [IDiaTable](../VS_csharp/idiatable.md)  
 Enumerates a DIA data source table.  
  
## Related Sections  
 [Enumerations and Structures](../VS_csharp/enumerations-and-structures.md)  
 Describes the enumerations and structures used by the various interfaces of the DIA SDK.  
  
 [Constants (Debug Interface Access SDK)](../VS_csharp/constants--debug-interface-access-sdk-.md)  
 Describes the constants available in the DIA SDK.  
  
## See Also  
 [Reference](../VS_csharp/debug-interface-access-sdk-reference.md)