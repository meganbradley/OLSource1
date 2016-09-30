---
title: "IDiaEnumDebugStreamData::Next"
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
  - "IDiaEnumDebugStreamData::Next method"
ms.assetid: 114171dd-38fd-4bd7-a702-8ff887ffc99b
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumDebugStreamData::Next
Retrieves a specified number of records in the enumerated sequence.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 celt  
 [in] The number of records to be retrieved.  
  
 cbData  
 [in] Size of the data buffer, in bytes.  
  
 pcbData  
 [out] Returns the number of bytes returned. If <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is NULL, then <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> contains the total number of bytes of data available for all requested records.  
  
 data[]  
 [out] A buffer that is to be filled with the debug stream record data.  
  
 pceltFetched  
 [in, out] Returns the number of records in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if there are no more records. Otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumDebugStreamData](../vs140/idiaenumdebugstreamdata.md)   
 [IDiaEnumDebugStreams::Next](../vs140/idiaenumdebugstreams--next.md)