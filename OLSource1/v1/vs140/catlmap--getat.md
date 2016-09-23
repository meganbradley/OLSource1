---
title: "CAtlMap::GetAt"
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
  - ATL::CAtlMap::GetAt
  - ATL.CAtlMap.GetAt
  - CAtlMap::GetAt
  - CAtlMap.GetAt
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetAt method [ATL]
ms.assetid: 548a6457-5f25-4af6-87e3-a9327ee7e1bb
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlMap::GetAt
Call this method to return the element at a specified position in the map.  
  
## Syntax  
  
```  
  
      void GetAt(  
   POSITION pos,  
   KOUTARGTYPE key,  
   VOUTARGTYPE value   
) const;  
CPair* GetAt(  
   POSITION& pos   
) throw( );  
```  
  
#### Parameters  
 `pos`  
 The position counter, returned by a previous call to [CAtlMap::GetNextAssoc](../vs140/catlmap--getnextassoc.md) or [CAtlMap::GetStartPosition](../vs140/catlmap--getstartposition.md).  
  
 `key`  
 Template parameter specifying the type of the map's key.  
  
 *value*  
 Template parameter specifying the type of the map's value.  
  
## Return Value  
 Returns a pointer to the current pair of key/value elements stored in the map.  
  
## Remarks  
 In debug builds, an assertion error will occur if `pos` is equal to NULL.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlMap Class](../vs140/catlmap-class.md)   
 [CAtlMap::SetAt](../vs140/catlmap--setat.md)   
 [CAtlMap::GetKeyAt](../vs140/catlmap--getkeyat.md)   
 [CAtlMap::GetValueAt](../vs140/catlmap--getvalueat.md)   
 [CAtlMap::CPair Class](../vs140/catlmap--cpair-class.md)