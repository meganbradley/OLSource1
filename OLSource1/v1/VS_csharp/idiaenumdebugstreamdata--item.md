---
title: "IDiaEnumDebugStreamData::Item"
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
  - "IDiaEnumDebugStreamData::Item method"
ms.assetid: 761e61a5-44a6-4d5d-a98e-c2e9b89d2343
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumDebugStreamData::Item
Retrieves the specified record.  
  
## Syntax  
  
```cpp#  
HRESULT Item (   
   DWORD  index,  
   DWORD  cbData,  
   DWORD* pcbData,  
   BYTE   data[]  
);  
```  
  
#### Parameters  
 index  
 [in] Index of the record to be retrieved. The index is in the range 0 to `count`-1, where `count` is returned by [IDiaEnumDebugStreamData::get_Count](../VS_csharp/idiaenumdebugstreamdata--get_count.md).  
  
 cbData  
 [in] Size of the data buffer, in bytes.  
  
 pcbData  
 [out] Returns the number of bytes returned. If `data` is `NULL`, then `pcbData` contains the total number of bytes of data available in the specified record.  
  
 data[]  
 [out] A buffer that is filled in with the debug stream record data.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code. Returns `E_INVALIDARG` for invalid parameters and if the `index` parameter is out of bounds.  
  
## See Also  
 [IDiaEnumDebugStreamData](../VS_csharp/idiaenumdebugstreamdata.md)   
 [IDiaEnumDebugStreamData::Next](../VS_csharp/idiaenumdebugstreamdata--next.md)   
 [IDiaEnumDebugStreams::Item](../VS_csharp/idiaenumdebugstreams--item.md)   
 [IDiaEnumDebugStreamData::get_Count](../VS_csharp/idiaenumdebugstreamdata--get_count.md)   
 [IDiaEnumDebugStreamData::Skip](../VS_csharp/idiaenumdebugstreamdata--skip.md)