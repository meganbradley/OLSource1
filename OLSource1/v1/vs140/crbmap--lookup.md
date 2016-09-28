---
title: "CRBMap::Lookup"
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
  - "CRBMap.Lookup"
  - "CRBMap::Lookup"
  - "ATL::CRBMap::Lookup"
  - "ATL.CRBMap.Lookup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Lookup method"
ms.assetid: e82722fc-aea4-46d1-90e5-d27b596b6c9a
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRBMap::Lookup
Call this method to look up keys or values in the `CRBMap` object.  
  
## Syntax  
  
```  
  
      bool Lookup(  
   KINARGTYPE key,  
   VOUTARGTYPE value   
) const throw(...);  
const CPair* Lookup(  
   KINARGTYPE key   
) const throw( );  
CPair* Lookup(  
   KINARGTYPE key   
) throw( );  
```  
  
#### Parameters  
 `key`  
 Specifies the key that identifies the element to be looked up.  
  
 *value*  
 Variable that receives the looked-up value.  
  
## Return Value  
 The first form of the method returns true if the key is found, otherwise false. The second and third forms return a pointer to a [CPair](../vs140/crbtree--cpair-class.md).  
  
## Remarks  
 See the documentation for the base class [CRBTree](../vs140/crbtree-class.md) for information on the other methods available.  
  
## Example  
 [!code[NVC_ATL_Utilities#82](../vs140/codesnippet/CPP/crbmap--lookup_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CRBMap Class](../vs140/crbmap-class.md)