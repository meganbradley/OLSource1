---
title: "CAtlMap::DisableAutoRehash"
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
  - ATL.CAtlMap.DisableAutoRehash
  - CAtlMap.DisableAutoRehash
  - ATL::CAtlMap::DisableAutoRehash
  - DisableAutoRehash
  - CAtlMap::DisableAutoRehash
dev_langs: 
  - C++
helpviewer_keywords: 
  - DisableAutoRehash method
ms.assetid: ff0ae980-723d-45cd-af5e-59fff69041b9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlMap::DisableAutoRehash
Call this method to disable automatic rehashing of the `CAtlMap` object.  
  
## Syntax  
  
```  
  
void DisableAutoRehash( ) throw( );  
  
```  
  
## Remarks  
 When automatic rehashing is enabled (which it is by default), the number of bins in the hash table will automatically be recalculated if the load value (the ratio of the number of bins to the number of elements stored in the array) exceeds the maximum or minimum values specified at the time the map was created.  
  
 `DisableAutoRehash` is most useful when a large number of elements will be added to the map at once. Instead of triggering the rehashing process every time the limits are exceeded, it is more efficient to call `DisableAutoRehash`, add the elements, and finally call [CAtlMap::EnableAutoRehash](../vs140/catlmap--enableautorehash.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlMap Class](../vs140/catlmap-class.md)   
 [CAtlMap::EnableAutoRehash](../vs140/catlmap--enableautorehash.md)