---
title: "CList::RemoveAt"
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
  - CList.RemoveAt
  - CList::RemoveAt
dev_langs: 
  - C++
helpviewer_keywords: 
  - CList class, retrieval/modification
  - RemoveAt method
ms.assetid: 48f8b9b2-63fc-4d7e-8c2b-fbd4b5629082
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CList::RemoveAt
Removes the specified element from this list.  
  
## Syntax  
  
```  
  
      void RemoveAt(  
   POSITION position   
);  
```  
  
#### Parameters  
 *position*  
 The position of the element to be removed from the list.  
  
## Remarks  
 You must ensure that your **POSITION** value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
## Example  
 [!code[NVC_MFCCollections#52](../vs140/codesnippet/CPP/clist--removeat_1.cpp)]
  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CList Class](../vs140/clist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CList::RemoveAll](../vs140/clist--removeall.md)