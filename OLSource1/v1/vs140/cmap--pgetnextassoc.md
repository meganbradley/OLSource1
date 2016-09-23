---
title: "CMap::PGetNextAssoc"
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
  - CMap::PGetNextAssoc
  - CMap.PGetNextAssoc
  - PGetNextAssoc
dev_langs: 
  - C++
helpviewer_keywords: 
  - CMap class, operations
  - PGetNextAssoc method
ms.assetid: 05659586-3aeb-4740-9ea7-40f2bf754dd3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMap::PGetNextAssoc
Retrieves the map element pointed to by `pAssocRec`.  
  
## Syntax  
  
```  
  
      const CPair *PGetNextAssoc(  
   const CPair* pAssocRet  
) const;  
CPair *PGetNextAssoc(  
   const CPair* pAssocRet  
);  
```  
  
#### Parameters  
 *pAssocRet*  
 Points to a map entry returned by a previous [PGetNextAssoc](#vclrfcmappgetnextassoc) or [CMap::PGetFirstAssoc](../vs140/cmap--pgetfirstassoc.md) call.  
  
## Return Value  
 A pointer to the next entry in the map; see [CMap::CPair](../vs140/cmap--cpair.md). If the element is the last in the map, the value is **NULL**.  
  
## Remarks  
 Call this method to iterate through all the elements in the map. Retrieve the first element with a call to `PGetFirstAssoc` and then iterate through the map with successive calls to `PGetNextAssoc`.  
  
## Example  
 See the example for [CMap::PGetFirstAssoc](../vs140/cmap--pgetfirstassoc.md).  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CMap Class](../vs140/cmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMap::PGetFirstAssoc](../vs140/cmap--pgetfirstassoc.md)   
 [CMap::PLookup](../vs140/cmap--plookup.md)