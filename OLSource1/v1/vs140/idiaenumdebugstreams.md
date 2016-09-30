---
title: "IDiaEnumDebugStreams"
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
  - "IDiaEnumDebugStreams interface"
ms.assetid: 611caf4f-7a5f-4aa4-b909-52feeb3cc752
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumDebugStreams
Enumerates the various debug streams contained in the data source.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Methods in Vtable Order  
 The following table shows the methods of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaEnumDebugStreams::get__NewEnum](../vs140/idiaenumdebugstreams--get__newenum.md)|Retrieves the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> version of this enumerator.|  
|[IDiaEnumDebugStreams::get_Count](../vs140/idiaenumdebugstreams--get_count.md)|Retrieves the number of debug streams.|  
|[IDiaEnumDebugStreams::Item](../vs140/idiaenumdebugstreams--item.md)|Retrieves a debug stream by means of an index.|  
|[IDiaEnumDebugStreams::Next](../vs140/idiaenumdebugstreams--next.md)|Retrieves a specified number of debug streams in the enumeration sequence.|  
|[IDiaEnumDebugStreams::Skip](../vs140/idiaenumdebugstreams--skip.md)|Skips a specified number of debug streams in an enumeration sequence.|  
|[IDiaEnumDebugStreams::Reset](../vs140/idiaenumdebugstreams--reset.md)|Resets an enumeration sequence to the beginning.|  
|[IDiaEnumDebugStreams::Clone](../vs140/idiaenumdebugstreams--clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
  
## Remarks  
 The content of debug streams is implementation-dependent and the data formats are undocumented.  
  
## Notes for Callers  
 Call the [IDiaSession::getEnumDebugStreams](../vs140/idiasession--getenumdebugstreams.md) method to obtain an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
## Example  
 This example shows how to access the data streams available from this interface. See the [IDiaEnumDebugStreamData](../vs140/idiaenumdebugstreamdata.md) interface for an implementation of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../vs140/interfaces--debug-interface-access-sdk-.md)   
 [IDiaEnumDebugStreamData](../vs140/idiaenumdebugstreamdata.md)   
 [IDiaSession::getEnumDebugStreams](../vs140/idiasession--getenumdebugstreams.md)