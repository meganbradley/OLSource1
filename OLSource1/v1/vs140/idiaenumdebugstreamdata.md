---
title: "IDiaEnumDebugStreamData"
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
  - "IDiaEnumDebugStreamData interface"
ms.assetid: e2023c32-4c05-4d0c-a0be-f016a230c788
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumDebugStreamData
Provides access to the records in a debug data stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Methods in Vtable Order  
 The following table shows the methods of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaEnumDebugStreamData::get__NewEnum](../vs140/idiaenumdebugstreamdata--get__newenum.md)|Retrieves the [IEnumVARIANT Interface](assetId:///139e3c93-faef-4003-9079-e0e94494db3e) version of this enumerator.|  
|[IDiaEnumDebugStreamData::get_Count](../vs140/idiaenumdebugstreamdata--get_count.md)|Retrieves the number of records in the debug data stream.|  
|[IDiaEnumDebugStreamData::get_name](../vs140/idiaenumdebugstreamdata--get_name.md)|Retrieves the name of the debug data stream.|  
|[IDiaEnumDebugStreamData::Item](../vs140/idiaenumdebugstreamdata--item.md)|Retrieves the specified record.|  
|[IDiaEnumDebugStreamData::Next](../vs140/idiaenumdebugstreamdata--next.md)|Retrieves the specified number of records  from the enumerated sequence.|  
|[IDiaEnumDebugStreamData::Skip](../vs140/idiaenumdebugstreamdata--skip.md)|Skips a specified number of records in an enumerated sequence.|  
|[IDiaEnumDebugStreamData::Reset](../vs140/idiaenumdebugstreamdata--reset.md)|Resets the enumerated sequence to the beginning.|  
|[IDiaEnumDebugStreamData::Clone](../vs140/idiaenumdebugstreamdata--clone.md)|Creates an enumerator that contains the same enumerated sequence as the current enumerator.|  
  
## Remarks  
 This interface represents a stream of records in a debug data stream. The size and interpretation of each record is dependent on the data stream the record comes from. This interface effectively provides access to the raw data bytes in the symbol file.  
  
## Notes for Callers  
 Call the [IDiaEnumDebugStreams::Item](../vs140/idiaenumdebugstreams--item.md) or [IDiaEnumDebugStreams::Next](../vs140/idiaenumdebugstreams--next.md) methods to obtain an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
## Example  
 This example shows how to access a single data stream and its records.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../vs140/interfaces--debug-interface-access-sdk-.md)   
 [IDiaEnumDebugStreams::Item](../vs140/idiaenumdebugstreams--item.md)   
 [IDiaEnumDebugStreams::Next](../vs140/idiaenumdebugstreams--next.md)