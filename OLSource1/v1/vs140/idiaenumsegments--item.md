---
title: "IDiaEnumSegments::Item"
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
  - IDiaEnumSegments::Item method
ms.assetid: ee44dd55-39a0-4b7b-97ff-2e1226eeb2bd
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IDiaEnumSegments::Item
Retrieves a segment by means of an index.  
  
## Syntax  
  
```cpp#  
HRESULT Item (   
   DWORD         index,  
   IDiaSegment** segment  
);  
```  
  
#### Parameters  
 index  
 [in] Index of the [IDiaSegment](../vs140/idiasegment.md) object to be retrieved. The index is in the range 0 to `count`-1, where `count` is returned by the [IDiaEnumSegments::get_Count](../vs140/idiaenumsegments--get_count.md) method.  
  
 segment  
 [out] Returns an [IDiaSegment](../vs140/idiasegment.md) object representing the desired segment.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumSegments](../vs140/idiaenumsegments.md)   
 [IDiaSegment](../vs140/idiasegment.md)