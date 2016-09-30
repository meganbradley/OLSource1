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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 index  
 [in] Index of the record to be retrieved. The index is in the range 0 to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>-1, where <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is returned by [IDiaEnumDebugStreamData::get_Count](../vs140/idiaenumdebugstreamdata--get_count.md).  
  
 cbData  
 [in] Size of the data buffer, in bytes.  
  
 pcbData  
 [out] Returns the number of bytes returned. If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> contains the total number of bytes of data available in the specified record.  
  
 data[]  
 [out] A buffer that is filled in with the debug stream record data.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns an error code. Returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> for invalid parameters and if the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter is out of bounds.  
  
## See Also  
 [IDiaEnumDebugStreamData](../vs140/idiaenumdebugstreamdata.md)   
 [IDiaEnumDebugStreamData::Next](../vs140/idiaenumdebugstreamdata--next.md)   
 [IDiaEnumDebugStreams::Item](../vs140/idiaenumdebugstreams--item.md)   
 [IDiaEnumDebugStreamData::get_Count](../vs140/idiaenumdebugstreamdata--get_count.md)   
 [IDiaEnumDebugStreamData::Skip](../vs140/idiaenumdebugstreamdata--skip.md)