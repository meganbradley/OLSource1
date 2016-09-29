---
title: "CMap::Lookup"
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
  - "CMap::Lookup"
  - "CMap.Lookup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Lookup method"
  - "CMap class, operations"
ms.assetid: a20674d1-b767-4f47-8af4-a0b07eabca68
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMap::Lookup
Looks up the value mapped to a given key.  
  
## Syntax  
  
```  
  
      BOOL Lookup(  
   ARG_KEY key,  
   VALUE& rValue   
) const;  
```  
  
#### Parameters  
 `ARG_KEY`  
 Template parameter specifying the type of the `key` value.  
  
 `key`  
 Specifies the key that identifies the element to be looked up.  
  
 *VALUE*  
 Specifies the type of the value to be looked up.  
  
 `rValue`  
 Receives the looked-up value.  
  
## Return Value  
 Nonzero if the element was found; otherwise 0.  
  
## Remarks  
 `Lookup` uses a hashing algorithm to quickly find the map element with a key that exactly matches the given key.  
  
## Example  
 [!code[NVC_MFCCollections#58](../vs140/codesnippet/CPP/cmap--lookup_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CMap Class](../vs140/cmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMap::operator](../vs140/cmap--operator.md)