---
title: "CRBMultiMap::GetNextValueWithKey"
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
  - "ATL::CRBMultiMap::GetNextValueWithKey"
  - "GetNextValueWithKey"
  - "ATL.CRBMultiMap.GetNextValueWithKey"
  - "CRBMultiMap.GetNextValueWithKey"
  - "CRBMultiMap::GetNextValueWithKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNextValueWithKey method"
ms.assetid: 0576ba91-7dd0-4912-baee-a9e2d97daa26
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRBMultiMap::GetNextValueWithKey
Call this method to get the value associated with a given key and update the position value.  
  
## Syntax  
  
```  
  
      const V& GetNextValueWithKey(  
   POSITION& pos,  
   KINARGTYPE key   
) const throw( );  
V& GetNextValueWithKey(  
   POSITION& pos,  
   KINARGTYPE key   
) throw( );  
```  
  
#### Parameters  
 `pos`  
 The position value, obtained with either a call to [CRBMultiMap::FindFirstWithKey](../vs140/crbmultimap--findfirstwithkey.md) or [CRBMultiMap::GetNextWithKey](../vs140/crbmultimap--getnextwithkey.md), or a previous call to `GetNextValueWithKey`.  
  
 `key`  
 Specifies the key that identifies the element to be found.  
  
## Return Value  
 Returns the element pair associated with the given key.  
  
## Remarks  
 The position value is updated to point to the next value associated with the key. If no more values exist, the position value is set to NULL.  
  
 See the documentation for the base class [CRBTree](../vs140/crbtree-class.md) for information on the other methods available.  
  
## Example  
 See the example for [CRBMultiMap::CRBMultiMap](../vs140/crbmultimap--crbmultimap.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CRBMultiMap Class](../vs140/crbmultimap-class.md)   
 [CRBMultiMap::FindFirstWithKey](../vs140/crbmultimap--findfirstwithkey.md)   
 [CRBMultiMap::GetNextWithKey](../vs140/crbmultimap--getnextwithkey.md)