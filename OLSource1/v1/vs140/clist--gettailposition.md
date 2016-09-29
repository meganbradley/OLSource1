---
title: "CList::GetTailPosition"
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
  - "CList.GetTailPosition"
  - "CList::GetTailPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTailPosition method"
  - "CList class, iteration"
ms.assetid: c464b7ee-5d58-4cf5-9fec-11a1a419a8af
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CList::GetTailPosition
Gets the position of the tail element of this list; **NULL** if the list is empty.  
  
## Syntax  
  
```  
  
POSITION GetTailPosition( ) const;  
```  
  
## Return Value  
 A **POSITION** value that can be used for iteration or object pointer retrieval; **NULL** if the list is empty.  
  
## Example  
 [!code[NVC_MFCCollections#47](../vs140/codesnippet/CPP/clist--gettailposition_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CList Class](../vs140/clist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CList::GetHeadPosition](../vs140/clist--getheadposition.md)   
 [CList::GetTail](../vs140/clist--gettail.md)