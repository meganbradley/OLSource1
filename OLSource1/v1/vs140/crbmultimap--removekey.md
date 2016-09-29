---
title: "CRBMultiMap::RemoveKey"
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
  - "CRBMultiMap.RemoveKey"
  - "CRBMultiMap::RemoveKey"
  - "ATL.CRBMultiMap.RemoveKey"
  - "ATL::CRBMultiMap::RemoveKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveKey method"
ms.assetid: bccea4ac-2259-43a2-b32c-8cc0f03023f4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRBMultiMap::RemoveKey
Call this method to remove all of the key/value elements for a given key.  
  
## Syntax  
  
```  
  
      size_t RemoveKey(  
   KINARGTYPE key   
) throw( );  
```  
  
#### Parameters  
 `key`  
 Specifies the key that identifies the element(s) to be deleted.  
  
## Return Value  
 Returns the number of values associated with the given key.  
  
## Remarks  
 `RemoveKey` deletes all of the key/value elements that have a key that matches `key`.  
  
 See the documentation for the base class [CRBTree](../vs140/crbtree-class.md) for information on the other methods available.  
  
## Example  
 See the example for [CRBMultiMap::CRBMultiMap](../vs140/crbmultimap--crbmultimap.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CRBMultiMap Class](../vs140/crbmultimap-class.md)   
 [CRBMultiMap::Insert](../vs140/crbmultimap--insert.md)