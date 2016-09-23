---
title: "CMap::GetStartPosition"
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
  - CMap.GetStartPosition
  - CMap::GetStartPosition
dev_langs: 
  - C++
helpviewer_keywords: 
  - CMap class, operations
  - GetStartPosition method
ms.assetid: 85f5ba04-a792-45dc-a1e5-ae92057dca72
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMap::GetStartPosition
Starts a map iteration by returning a **POSITION** value that can be passed to a `GetNextAssoc` call.  
  
## Syntax  
  
```  
  
POSITION GetStartPosition( ) const;  
```  
  
## Return Value  
 A **POSITION** value that indicates a starting position for iterating the map; or **NULL** if the map is empty.  
  
## Remarks  
 The iteration sequence is not predictable; therefore, the "first element in the map" has no special significance.  
  
## Example  
 See the example for [CMap::SetAt](../vs140/cmap--setat.md).  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CMap Class](../vs140/cmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMap::GetNextAssoc](../vs140/cmap--getnextassoc.md)