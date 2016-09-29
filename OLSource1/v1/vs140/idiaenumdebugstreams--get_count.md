---
title: "IDiaEnumDebugStreams::get_Count"
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
  - "IDiaEnumDebugStreams::get_Count method"
ms.assetid: 5c13fa9a-b35e-47b0-806f-1f53bfe1ba89
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumDebugStreams::get_Count
Retrieves the number of debug streams.  
  
## Syntax  
  
```cpp#  
HRESULT get_Count(   
   LONG* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the number of debug streams available in this enumerator.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumDebugStreams](../vs140/idiaenumdebugstreams.md)   
 [IDiaEnumDebugStreams::Item](../vs140/idiaenumdebugstreams--item.md)