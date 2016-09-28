---
title: "CMap::PLookup"
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
  - "PLookup"
  - "CMap::PLookup"
  - "CMap.PLookup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PLookup method"
  - "CMap class, operations"
ms.assetid: 6e81903b-ecf6-429f-bb8e-ea97d4d8301c
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMap::PLookup
Finds the value mapped to a given key.  
  
## Syntax  
  
```  
  
      const CPair* PLookup(  
   ARG_KEY key  
) const;  
CPair* PLookup(   
   ARG_KEY key   
);  
```  
  
#### Parameters  
 `key`  
 Key for the element to be searched for.  
  
## Return Value  
 A pointer to a key structure; see [CMap::CPair](../vs140/cmap--cpair.md). If no match is found, `CMap::PLookup` returns `NULL`.  
  
## Remarks  
 Call this method to search for a map element with a key that exactly matches the given key.  
  
## Example  
 [!code[NVC_MFCCollections#60](../vs140/codesnippet/CPP/cmap--plookup_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CMap Class](../vs140/cmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMap::PGetNextAssoc](../vs140/cmap--pgetnextassoc.md)   
 [CMap::PGetFirstAssoc](../vs140/cmap--pgetfirstassoc.md)