---
title: "IDiaEnumDebugStreamData::get_Count"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - IDiaEnumDebugStreamData::get_Count method
ms.assetid: 74ff3a85-3cc2-4aa8-ad9a-7f335b795ed1
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IDiaEnumDebugStreamData::get_Count
Retrieves the number records in the debug data stream.  
  
## Syntax  
  
```cpp#  
HRESULT get_Count (   
   LONG* pRetVal  
);  
```  
  
#### Parameters  
 pRetVal  
 [out, retval] Returns the number of records.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumDebugStreamData](../vs140/idiaenumdebugstreamdata.md)   
 [IDiaEnumDebugStreamData::Item](../vs140/idiaenumdebugstreamdata--item.md)