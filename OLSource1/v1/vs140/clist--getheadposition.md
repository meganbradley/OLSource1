---
title: "CList::GetHeadPosition"
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
  - CList::GetHeadPosition
  - CList.GetHeadPosition
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetHeadPosition method
  - CList class, iteration
ms.assetid: a8b56474-4709-4059-8245-06ee2626f274
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CList::GetHeadPosition
Gets the position of the head element of this list.  
  
## Syntax  
  
```  
  
POSITION GetHeadPosition( ) const;  
```  
  
## Return Value  
 A **POSITION** value that can be used for iteration or object pointer retrieval; **NULL** if the list is empty.  
  
## Example  
 [!code[NVC_MFCCollections#42](../vs140/codesnippet/CPP/clist--getheadposition_1.cpp)]
  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CList Class](../vs140/clist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CList::GetTailPosition](../vs140/clist--gettailposition.md)