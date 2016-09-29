---
title: "CList::Find"
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
  - "CList::Find"
  - "CList.Find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CList class, searching"
  - "Find method"
ms.assetid: 1b010598-edc3-425b-a70a-bb6e42c16bcd
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CList::Find
Searches the list sequentially to find the first element matching the specified `searchValue`.  
  
## Syntax  
  
```  
  
      POSITION Find(  
   ARG_TYPE searchValue,  
   POSITION startAfter = NULL  
) const;   
```  
  
#### Parameters  
 `ARG_TYPE`  
 Template parameter specifying the type of the list element (can be a reference).  
  
 `searchValue`  
 The value to be found in the list.  
  
 `startAfter`  
 The start position for the search. If no value is specified, the search begins with the head element.  
  
## Return Value  
 A **POSITION** value that can be used for iteration or object pointer retrieval; **NULL** if the object is not found.  
  
## Example  
 [!code[NVC_MFCCollections#39](../vs140/codesnippet/CPP/clist--find_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CList Class](../vs140/clist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CList::GetNext](../vs140/clist--getnext.md)   
 [CList::GetPrev](../vs140/clist--getprev.md)