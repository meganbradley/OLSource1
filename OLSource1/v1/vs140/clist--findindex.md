---
title: "CList::FindIndex"
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
  - "CList::FindIndex"
  - "CList.FindIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CList class, searching"
  - "FindIndex method"
ms.assetid: c747e1d6-62bb-45a1-9a69-2714d153f00a
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CList::FindIndex
Uses the value of `nIndex` as an index into the list.  
  
## Syntax  
  
```  
  
      POSITION FindIndex(  
   INT_PTR nIndex   
) const;  
```  
  
#### Parameters  
 `nIndex`  
 The zero-based index of the list element to be found.  
  
## Return Value  
 A **POSITION** value that can be used for iteration or object pointer retrieval; **NULL** if `nIndex` is negative or too large.  
  
## Remarks  
 It starts a sequential scan from the head of the list, stopping on the *n*th element.  
  
## Example  
 [!code[NVC_MFCCollections#40](../vs140/codesnippet/CPP/clist--findindex_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CList Class](../vs140/clist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObList::Find](../vs140/coblist--find.md)   
 [CObList::GetNext](../vs140/coblist--getnext.md)   
 [CObList::GetPrev](../vs140/coblist--getprev.md)