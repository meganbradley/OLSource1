---
title: "IDiaEnumDebugStreams::Next"
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
  - "IDiaEnumDebugStreams::Next method"
ms.assetid: eb8eae5a-be27-45f4-a7bd-6e4ef0652385
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumDebugStreams::Next
Retrieves a specified number of debug streams in the enumeration sequence.  
  
## Syntax  
  
```cpp#  
HRESULT Next (   
   ULONG                     celt,   
   IDiaEnumDebugStreamData** rgelt,  
   ULONG*                    pceltFetched  
);  
```  
  
#### Parameters  
 celt  
 [in] **T**he number of debug streams in the enumerator to be retrieved.  
  
 rgelt  
 [out] Returns an array of [IDiaEnumDebugStreamData](../vs140/idiaenumdebugstreamdata.md) objects that represents the debug streams being retrieved.  
  
 pceltFetched  
 [out] Returns the number of debug streams returned.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if there are no more streams. Otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumDebugStreams](../vs140/idiaenumdebugstreams.md)