---
title: "CAtlMap::GetCount"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CAtlMap.GetCount
  - CAtlMap::GetCount
  - ATL.CAtlMap.GetCount
  - ATL::CAtlMap::GetCount
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetCount method [ATL]
ms.assetid: 95cb1205-c13b-410d-a12b-a0cb63393760
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlMap::GetCount
Call this method to retrieve the number of elements in the map.  
  
## Syntax  
  
```  
  
size_t GetCount( ) const throw( );  
  
```  
  
## Return Value  
 Returns the number of elements in the map object. A single element is a key/value pair.  
  
## Example  
 See the example for [CAtlMap::CAtlMap](../vs140/catlmap--catlmap.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlMap Class](../vs140/catlmap-class.md)   
 [CAtlMap::GetHashTableSize](../vs140/catlmap--gethashtablesize.md)