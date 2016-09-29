---
title: "CRBMultiMap::Insert"
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
  - "ATL::CRBMultiMap::Insert"
  - "CRBMultiMap::Insert"
  - "CRBMultiMap.Insert"
  - "ATL.CRBMultiMap.Insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Insert method"
ms.assetid: 2f9229c4-f00e-4321-b32d-867514fe3ef0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRBMultiMap::Insert
Call this method to insert an element pair into the map.  
  
## Syntax  
  
```  
  
      POSITION Insert(  
   KINARGTYPE key,  
   VINARGTYPE value  
) throw(...);  
```  
  
#### Parameters  
 `key`  
 The key value to add to the `CRBMultiMap` object.  
  
 *value*  
 The value to add to the `CRBMultiMap` object, associated with `key`.  
  
## Return Value  
 Returns the position of the key/value element pair in the `CRBMultiMap` object.  
  
## Remarks  
 See the documentation for the base class [CRBTree](../vs140/crbtree-class.md) for information on the other methods available.  
  
## Example  
 See the example for [CRBMultiMap::CRBMultiMap](../vs140/crbmultimap--crbmultimap.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CRBMultiMap Class](../vs140/crbmultimap-class.md)   
 [CRBMultiMap::RemoveKey](../vs140/crbmultimap--removekey.md)