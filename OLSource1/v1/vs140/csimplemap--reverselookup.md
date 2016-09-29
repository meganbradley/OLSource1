---
title: "CSimpleMap::ReverseLookup"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL::CSimpleMap::ReverseLookup"
  - "ReverseLookup"
  - "CSimpleMap::ReverseLookup"
  - "ATL.CSimpleMap.ReverseLookup"
  - "CSimpleMap.ReverseLookup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ReverseLookup method"
ms.assetid: c204e81b-e1e7-4d22-af98-beb4c1600d57
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleMap::ReverseLookup
Returns the key associated with the given value.  
  
## Syntax  
  
```  
  
      TKey ReverseLookup(  
   const TVal& val   
) const;  
```  
  
#### Parameters  
 *val*  
 The value.  
  
## Return Value  
 Returns the associated key. If no matching key is found, NULL is returned.  
  
## Requirements  
 **Header:** atlsimpcoll.h  
  
## See Also  
 [CSimpleMap Class](../vs140/csimplemap-class.md)   
 [CSimpleMap::Lookup](../vs140/csimplemap--lookup.md)