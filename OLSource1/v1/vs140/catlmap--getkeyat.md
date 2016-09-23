---
title: "CAtlMap::GetKeyAt"
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
  - GetKeyAt
  - CAtlMap::GetKeyAt
  - ATL::CAtlMap::GetKeyAt
  - ATL.CAtlMap.GetKeyAt
  - CAtlMap.GetKeyAt
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetKeyAt method
ms.assetid: 5c49dc7c-66ee-49cf-ae9f-4262bfbe83f9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlMap::GetKeyAt
Call this method to retrieve the key stored at the given position in the `CAtlMap` object.  
  
## Syntax  
  
```  
  
      const K& GetKeyAt(  
   POSITION pos   
) const throw( );  
```  
  
#### Parameters  
 `pos`  
 The position counter, returned by a previous call to [CAtlMap::GetNextAssoc](../vs140/catlmap--getnextassoc.md) or [CAtlMap::GetStartPosition](../vs140/catlmap--getstartposition.md).  
  
## Return Value  
 Returns a reference to the key stored at the given position in the `CAtlMap` object.  
  
## Example  
 See the example for [CAtlMap::CAtlMap](../vs140/catlmap--catlmap.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlMap Class](../vs140/catlmap-class.md)   
 [CAtlMap::SetValueAt](../vs140/catlmap--setvalueat.md)