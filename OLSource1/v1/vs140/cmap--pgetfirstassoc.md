---
title: "CMap::PGetFirstAssoc"
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
  - "PGetFirstAssoc"
  - "CMap.PGetFirstAssoc"
  - "CMap::PGetFirstAssoc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMap class, operations"
  - "PGetFirstAssoc method"
ms.assetid: 7bbe86e2-f61b-4f51-b837-f4dfa536e09a
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMap::PGetFirstAssoc
Returns the first entry of the map object.  
  
## Syntax  
  
```  
  
      const CPair* PGetFirstAssoc( ) const;   
CPair* PGetFirstAssoc( );  
```  
  
## Return Value  
 A pointer to the first entry in the map; see [CMap::CPair](../vs140/cmap--cpair.md). If the map contains no entries, the value is **NULL**.  
  
## Remarks  
 Call this function to return a pointer the first element in the map object.  
  
## Example  
 [!code[NVC_MFCCollections#59](../vs140/codesnippet/CPP/cmap--pgetfirstassoc_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CMap Class](../vs140/cmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMap::PGetNextAssoc](../vs140/cmap--pgetnextassoc.md)   
 [CMap::PLookup](../vs140/cmap--plookup.md)