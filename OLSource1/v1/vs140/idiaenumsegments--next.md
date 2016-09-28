---
title: "IDiaEnumSegments::Next"
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
  - "IDiaEnumSegments::Next method"
ms.assetid: 53f61874-d821-47ab-a1f5-27e982804a6a
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumSegments::Next
Retrieves a specified number of segments in the enumeration sequence.  
  
## Syntax  
  
```cpp#  
HRESULT Next (   
   ULONG         celt,   
   IDiaSegment** rgelt,  
   ULONG*        pceltFetched  
);  
```  
  
#### Parameters  
 celt  
 [in] The number of segments in the enumerator to be retrieved.  
  
 rgelt  
 [out] An array that is to be filled in with the desired [IDiaSegment](../vs140/idiasegment.md) objects that represent the segments.  
  
 pceltFetched  
 [out] Returns the number of segments in the fetched enumerator.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if there are no more segments. Otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumSegments](../vs140/idiaenumsegments.md)   
 [IDiaSegment](../vs140/idiasegment.md)