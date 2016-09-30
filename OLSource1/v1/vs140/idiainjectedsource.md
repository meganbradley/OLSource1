---
title: "IDiaInjectedSource"
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
  - "IDiaInjectedSource interface"
ms.assetid: 75192c5c-812d-4675-9dc5-4c2cff3ba503
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaInjectedSource
Accesses injected source code stored in the DIA data source.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Methods in Vtable Order  
 The following table shows the methods of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaInjectedSource::get_crc](../vs140/idiainjectedsource--get_crc.md)|Retrieves a cyclic redundancy check (CRC) calculated from the bytes of the source code.|  
|[IDiaInjectedSource::get_length](../vs140/idiainjectedsource--get_length.md)|Retrieves the number of bytes of code.|  
|[IDiaInjectedSource::get_filename](../vs140/idiainjectedsource--get_filename.md)|Retrieves the file name for the source.|  
|[IDiaInjectedSource::get_objectFilename](../vs140/idiainjectedsource--get_objectfilename.md)|Retrieves the object file name to which the source was compiled.|  
|[IDiaInjectedSource::get_virtualFilename](../vs140/idiainjectedsource--get_virtualfilename.md)|Retrieves the name given to non-file source code; that is, code that was injected.|  
|[IDiaInjectedSource::get_sourceCompression](../vs140/idiainjectedsource--get_sourcecompression.md)|Retrieves the indicator of the source compression used.|  
|[IDiaInjectedSource::get_source](../vs140/idiainjectedsource--get_source.md)|Retrieves the source code bytes.|  
  
## Remarks  
 Injected source is text that is injected during compilation. This does not mean the preprocessor <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> used in C++.  
  
## Notes for Callers  
 Obtain this interface by calling the [IDiaEnumInjectedSources::Item](../vs140/idiaenuminjectedsources--item.md) or [IDiaEnumInjectedSources::Next](../vs140/idiaenuminjectedsources--next.md) methods. See the [IDiaEnumInjectedSources](../vs140/idiaenuminjectedsources.md) interface for an example of obtaining the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> interface.  
  
## Example  
 This example displays the data available from the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> interface. For an alternative approach using the [IDiaPropertyStorage](../vs140/idiapropertystorage.md) interface, see the example in the [IDiaEnumInjectedSources](../vs140/idiaenuminjectedsources.md) interface.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../vs140/interfaces--debug-interface-access-sdk-.md)   
 [IDiaEnumInjectedSources::Item](../vs140/idiaenuminjectedsources--item.md)   
 [IDiaEnumInjectedSources::Next](../vs140/idiaenuminjectedsources--next.md)   
 [IDiaEnumInjectedSources](../vs140/idiaenuminjectedsources.md)