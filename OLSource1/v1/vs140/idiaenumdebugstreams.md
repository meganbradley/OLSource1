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
  
```  
IDiaEnumDebugStreams : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaEnumDebugStreams`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaEnumDebugStreams::get__NewEnum](../vs140/idiaenumdebugstreams--get__newenum.md)|Retrieves the `IEnumVARIANT` version of this enumerator.|  
|[IDiaEnumDebugStreams::get_Count](../vs140/idiaenumdebugstreams--get_count.md)|Retrieves the number of debug streams.|  
|[IDiaEnumDebugStreams::Item](../vs140/idiaenumdebugstreams--item.md)|Retrieves a debug stream by means of an index.|  
|[IDiaEnumDebugStreams::Next](../vs140/idiaenumdebugstreams--next.md)|Retrieves a specified number of debug streams in the enumeration sequence.|  
|[IDiaEnumDebugStreams::Skip](../vs140/idiaenumdebugstreams--skip.md)|Skips a specified number of debug streams in an enumeration sequence.|  
|[IDiaEnumDebugStreams::Reset](../vs140/idiaenumdebugstreams--reset.md)|Resets an enumeration sequence to the beginning.|  
|[IDiaEnumDebugStreams::Clone](../vs140/idiaenumdebugstreams--clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
  
## Remarks  
 The content of debug streams is implementation-dependent and the data formats are undocumented.  
  
## Notes for Callers  
 Call the [IDiaSession::getEnumDebugStreams](../vs140/idiasession--getenumdebugstreams.md) method to obtain an `IDiaEnumDebugStreams` object.  
  
## Example  
 This example shows how to access the data streams available from this interface. See the [IDiaEnumDebugStreamData](../vs140/idiaenumdebugstreamdata.md) interface for an implementation of the `PrintStreamData` function.  
  
```cpp#  
void DumpAllDebugStreams( IDiaSession* pSession)  
{  
    IDiaEnumDebugStreams* pEnumStreams;  
  
    wprintf(L"\n\n*** DEBUG STREAMS\n\n");  
    // Retrieve an enumerated sequence of debug data streams  
    if(pSession->getEnumDebugStreams(&pEnumStreams) == S_OK)  
    {  
        IDiaEnumDebugStreamData* pStream;  
        ULONG celt = 0;  
  
        for(; pEnumStreams->Next(1, &pStream, &celt) == S_OK; pStream = NULL)  
        {  
            PrintStreamData(pStream);  
            pStream->Release();  
        }  
        pEnumStreams->Release();  
    }  
    else  
    {  
      wprintf(L"Failed to get any debug streams!\n");  
    }  
    wprintf(L"\n");  
}  
```  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../vs140/interfaces--debug-interface-access-sdk-.md)   
 [IDiaEnumDebugStreamData](../vs140/idiaenumdebugstreamdata.md)   
 [IDiaSession::getEnumDebugStreams](../vs140/idiasession--getenumdebugstreams.md)